// Copyright (c) 2004, Brian Takita All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//
// * Redistributions of source code must retain the above copyright notice, this
//   list of conditions and the following disclaimer.
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution.
// * Neither the name of NetAdventurer nor the names of its contributors may
//   be used to endorse or promote products derived from this software without
//   specific prior written permission. 
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
// ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
// LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
// OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
// DAMAGE.
#region Using directives

using System;
using System.Data.OleDb;
using System.Windows.Forms;
using NetAdventurer.GenericQueryAnalyzer.Data;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	public sealed class QueryUI {
		private MainUI _Parent;
		private QueryUIForm _Form;

		public QueryUI(MainUI parent, QueryUIForm form) {
			if (parent == null) throw new ArgumentNullException("parent");
			if (form == null) throw new ArgumentNullException("queryUIForm");

			_Parent = parent;
			_Form = form;
			_Form.ExecuteQuery+=new ExecuteQueryEventHandler(OnFormExecuteQuery);
			_Form.ChangeConnectionString+=new EventHandler(OnFormChangeConnectionString);
			_Form.CloseQueryForm+=new EventHandler(OnFormCloseQueryForm);
			_Form.ExitApplication+=new EventHandler(OnFormExitApplication);
		}

		#region public void ChangeConnectionString()
		public void ChangeConnectionString() {
			MSDASC.DataLinks dlg = new MSDASC.DataLinks();
			object result = dlg.PromptNew();

			string connectionString = "";
			if (result != null) {
				ADODB.Connection adodbConn = (ADODB.Connection)result;
				connectionString = adodbConn.ConnectionString;
			}
			_Form.ConnectionString = connectionString;
		}
		#endregion

		#region public void ExecuteQuery(string connectionString, string queryString)
		public void ExecuteQuery(string connectionString, string queryString) {
			// HACK: Workaround for a Windows.Forms bug.
			if (_Parent.ActiveQueryUI != this) {
				_Parent.ActiveQueryUI.ExecuteQuery(connectionString, queryString);
				return;
			}

			OleDbConnection conn = new OleDbConnection(connectionString);
			OleDbCommand cmd = new OleDbCommand(queryString, conn);

			Query query = new Query();
			query.QueryCompleted += new QueryCompletedEventHandler(OnQueryCompleted);
			query.ExceptionThrown +=new System.Threading.ThreadExceptionEventHandler(OnQueryExceptionThrown);
			query.Execute(cmd);
		}
		#endregion

		#region public void Activate()
		public void Activate() {
			_Form.Show();
			_Form.Activate();
		}
		#endregion

		#region Event Handlers
		#region private void OnQueryCompleted(object sender, QueryCompletedEventArgs e) {
		private void OnQueryCompleted(object sender, QueryCompletedEventArgs e) {
			_Form.ShowQueryResults(sender, e);
		}
		#endregion

		private void OnQueryExceptionThrown(object sender, System.Threading.ThreadExceptionEventArgs e) {
			_Parent.ShowError(e.Exception.Message);
		}

		private void OnFormExecuteQuery(object sender, ExecuteQueryEventArgs e) {
			ExecuteQuery(e.ConnectionString, e.QueryString);
		}

		private void OnFormChangeConnectionString(object sender, EventArgs e) {
			ChangeConnectionString();
		}
		#endregion

		private void OnFormCloseQueryForm(object sender, EventArgs e) {
			_Form.Close();
		}

		private void OnFormExitApplication(object sender, EventArgs e) {
			_Parent.Exit();
		}
	}
}

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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetAdventurer.GenericQueryAnalyzer.Data;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	public sealed partial class QueryUIForm : Form {
		public QueryUIForm() {
			InitializeComponent();
		}

		#region public string ConnectionString {get;set;}
		public string ConnectionString {
			get { return _TxtConnectionString.Text; }
			set { _TxtConnectionString.Text = value; }
		}
		#endregion

		#region private string QueryString {get;}
		private string QueryString {
			get { return _TxtQuery.Text; }
		}
		#endregion

		#region private int RecordsAffected {get;set;}
		private int _RecordsAffected;

		private int RecordsAffected {
			get { return _RecordsAffected; }
			set {
				_RecordsAffected = value;
				_SspRecordsAffected.Text = _RecordsAffected.ToString() + " record(s) affected";
			}
		}
		#endregion

		#region private string SuccessResult {get;set;}
		private string SuccessResult {
			get { return _SspSuccessResult.Text; }
			set { _SspSuccessResult.Text = value; }
		}
		#endregion

		#region public void ShowQueryResults(QueryCompletedEventArgs e)
		public void ShowQueryResults(object sender, QueryCompletedEventArgs e) {
			if (this.InvokeRequired)
				BeginInvoke(new QueryCompletedEventHandler(DoShowQueryResults), new object[] { sender, e });
			else
				DoShowQueryResults(sender, e);
		}

		public void DoShowQueryResults(object sender, QueryCompletedEventArgs e) {
			_DgvResults.DataSource = e.Table;
			RecordsAffected = e.RecordsAffected;
			_SspExecutionTime.Text = e.ExecutionTime.ToString() + " seconds";
		}
		#endregion

		#region Events
		#region public event EventHandler ChangeConnectionString {get;set;}
		private event EventHandler _ChangeConnectionString;
		public event EventHandler ChangeConnectionString {
			add {
				_ChangeConnectionString += value;
			}
			remove {
				_ChangeConnectionString -= value;
			}
		}

		private void OnChangeConnectionString(object sender, EventArgs e) {
			if (_ChangeConnectionString != null) _ChangeConnectionString(sender, e);
		}
		#endregion

		#region public event ExecuteQueryEventHandler ExecuteQuery {get;set;}
		private event ExecuteQueryEventHandler _ExecuteQuery;
		public event ExecuteQueryEventHandler ExecuteQuery {
			add {
				_ExecuteQuery += value;
			}
			remove {
				_ExecuteQuery -= value;
			}
		}

		private void OnExecuteQuery(ExecuteQueryEventArgs e) {
			if (_ExecuteQuery != null) _ExecuteQuery(this, e);
		}
		#endregion

		#region public event EventHandler CloseQueryForm {get;set;}
		public event EventHandler CloseQueryForm {
			add {
				_MnuFileClose.Click += value;
			}
			remove {
				_MnuFileClose.Click -= value;
			}
		}
		#endregion

		#region public event EventHandler ExitApplication {get;set;}
		public event EventHandler ExitApplication {
			add {
				_MnuFileExit.Click += value;
			}
			remove {
				_MnuFileExit.Click -= value;
			}
		}
		#endregion
		#endregion

		#region Event Handlers
		#region private void OnMnuQueryExecuteClick(object sender, EventArgs e) {
		private void OnMnuQueryExecuteClick(object sender, EventArgs e) {
			OnExecuteQuery(new ExecuteQueryEventArgs(ConnectionString, QueryString));
		}
		#endregion
		#endregion
	}
}
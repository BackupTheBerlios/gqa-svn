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

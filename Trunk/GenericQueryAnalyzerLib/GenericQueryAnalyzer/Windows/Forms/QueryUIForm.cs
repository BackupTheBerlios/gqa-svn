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
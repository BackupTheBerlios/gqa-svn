#region Using directives

using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	public sealed class MainUI {
		private MainUIForm _Form;
		private Dictionary<QueryUIForm, QueryUI> _QueryUIChildren = new Dictionary<QueryUIForm, QueryUI>();

		public MainUI(MainUIForm form) {
			if (form == null) throw new ArgumentNullException("queryUIForm");
			_Form = form;
			_Form.NewQuery+=new EventHandler(OnFormNewQuery);
			_Form.CloseForm+=new EventHandler(OnFormCloseForm);
			_Form.ShowAbout+=new EventHandler(OnFormShowAbout);
		}

		#region Properties
		#region public QueryUI ActiveQueryUI {get;}
		public QueryUI ActiveQueryUI {
			get {
				if (_Form.ActiveMdiChild == null)
					throw new Exception("There is no active MDI child.");

				return _QueryUIChildren[(QueryUIForm) _Form.ActiveMdiChild];
			}
		}
		#endregion
		#endregion

		#region public void Exit()
		public void Exit() {
			_Form.Close();
		}
		#endregion

		#region public void ShowError(string message)
		public void ShowError(string message) {
			MessageBox.Show(message, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		#endregion

		#region public void ShowMessage(string message, string title)
		public void ShowMessage(string message, string title) {
			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		#endregion

		private void OnFormNewQuery(object sender, EventArgs e) {
			QueryUIForm queryUIForm = new QueryUIForm();
			QueryUI queryUI = new QueryUI(this, queryUIForm);
			_QueryUIChildren.Add(queryUIForm, queryUI);

			queryUIForm.MdiParent = _Form;
			queryUI.Activate();
		}

		private void OnFormCloseForm(object sender, EventArgs e) {
			Exit();
		}

		private void OnFormShowAbout(object sender, EventArgs e) {
			AssemblyName assemblyName = Assembly.GetEntryAssembly().GetName();
			this.GetType().Assembly.GetName();

			string version = string.Format("{0:D}.{1:D}.{1:D}" ,
				assemblyName.Version.Major ,
				assemblyName.Version.Minor
			);

			StringBuilder aboutBoxBuilder = new StringBuilder();
			aboutBoxBuilder.AppendLine("https://developer.berlios.de/projects/gqa/");
			aboutBoxBuilder.AppendLine("Author: Brian Takita");
			aboutBoxBuilder.AppendLine("Version " + version);
			ShowMessage(aboutBoxBuilder.ToString(), "About Generic Query Analyzer");
		}
	}
}

#region Using directives

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NetAdventurer.GenericQueryAnalyzer.Windows.Forms;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer {
	static class Program {
		private static MainUI _MainUI;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.EnableRTLMirroring();

			MainUIForm form = new MainUIForm();
			_MainUI = new MainUI(form);
			Application.ThreadException+=new System.Threading.ThreadExceptionEventHandler(OnThreadException);
			
			Application.Run(form);
		}

		static void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
			_MainUI.ShowError(e.Exception.Message);
		}
	}
}
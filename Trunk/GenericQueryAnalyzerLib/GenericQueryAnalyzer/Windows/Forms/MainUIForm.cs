#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	public sealed partial class MainUIForm : Form {
		public MainUIForm() {
			InitializeComponent();
		}

		#region Events
		#region public event EventHandler NewQuery {get;set;}
		public event EventHandler NewQuery {
			add {
				_MnuFileNew.Click += value;
			}
			remove {
				_MnuFileNew.Click -= value;
			}
		}
		#endregion

		#region public event EventHandler CloseForm {get;set;}
		public event EventHandler CloseForm {
			add {
				_MnuFileExit.Click += value;
			}
			remove {
				_MnuFileExit.Click -= value;
			}
		}
		#endregion

		#region public event EventHandler ShowAbout {get;set;}
		public event EventHandler ShowAbout {
			add {
				_MnuAbout.Click += value;
			}
			remove {
				_MnuAbout.Click -= value;
			}
		}
		#endregion
		#endregion
	}
}
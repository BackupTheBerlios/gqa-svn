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
namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	partial class MainUIForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUIForm));
			this._MnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._MnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this._MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this._MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.leftRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this.topRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this.bottomRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this.rightRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this._MnuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).BeginInit();
			this.topRaftingContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).BeginInit();
			this.SuspendLayout();
// 
// _MnuMain
// 
			this._MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this._MnuAbout});
			this._MnuMain.Location = new System.Drawing.Point(0, 0);
			this._MnuMain.Name = "_MnuMain";
			this._MnuMain.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
			this._MnuMain.Raft = System.Windows.Forms.RaftingSides.Top;
			this._MnuMain.TabIndex = 0;
			this._MnuMain.Text = "menuStrip1";
// 
// fileToolStripMenuItem
// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MnuFileNew,
            this._MnuFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.SettingsKey = "FormMain.fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "&File";
// 
// _MnuFileNew
// 
			this._MnuFileNew.Name = "_MnuFileNew";
			this._MnuFileNew.SettingsKey = "FormMain.newToolStripMenuItem";
			this._MnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this._MnuFileNew.Text = "&New";
// 
// _MnuFileExit
// 
			this._MnuFileExit.Name = "_MnuFileExit";
			this._MnuFileExit.SettingsKey = "FormMain.exitToolStripMenuItem";
			this._MnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this._MnuFileExit.Text = "E&xit";
// 
// _MnuAbout
// 
			this._MnuAbout.Name = "_MnuAbout";
			this._MnuAbout.SettingsKey = "MainUIForm.aboutToolStripMenuItem";
			this._MnuAbout.Text = "&About";
// 
// leftRaftingContainer
// 
			this.leftRaftingContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftRaftingContainer.Name = "leftRaftingContainer";
// 
// topRaftingContainer
// 
			this.topRaftingContainer.Controls.Add(this._MnuMain);
			this.topRaftingContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.topRaftingContainer.Name = "topRaftingContainer";
// 
// bottomRaftingContainer
// 
			this.bottomRaftingContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomRaftingContainer.Name = "bottomRaftingContainer";
// 
// rightRaftingContainer
// 
			this.rightRaftingContainer.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightRaftingContainer.Name = "rightRaftingContainer";
// 
// MainUIForm
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(654, 352);
			this.Controls.Add(this.leftRaftingContainer);
			this.Controls.Add(this.rightRaftingContainer);
			this.Controls.Add(this.topRaftingContainer);
			this.Controls.Add(this.bottomRaftingContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "MainUIForm";
			this.Text = "Generic Query Analyzer";
			this._MnuMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).EndInit();
			this.topRaftingContainer.ResumeLayout(false);
			this.topRaftingContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _MnuMain;
		private System.Windows.Forms.RaftingContainer leftRaftingContainer;
		private System.Windows.Forms.RaftingContainer topRaftingContainer;
		private System.Windows.Forms.RaftingContainer bottomRaftingContainer;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _MnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem _MnuFileExit;
		private System.Windows.Forms.RaftingContainer rightRaftingContainer;
		private System.Windows.Forms.ToolStripMenuItem _MnuAbout;



	}
}
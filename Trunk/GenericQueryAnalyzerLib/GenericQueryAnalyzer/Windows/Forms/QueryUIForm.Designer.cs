namespace NetAdventurer.GenericQueryAnalyzer.Windows.Forms {
	partial class QueryUIForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryUIForm));
			this._ScQuery = new System.Windows.Forms.SplitContainer();
			this._TxtQuery = new System.Windows.Forms.TextBox();
			this._DgvResults = new System.Windows.Forms.DataGridView();
			this.leftRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this.rightRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this.topRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this._MsTop = new System.Windows.Forms.MenuStrip();
			this._MnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this._MnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this._MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bottomRaftingContainer = new System.Windows.Forms.RaftingContainer();
			this._SsQuery = new System.Windows.Forms.StatusStrip();
			this._SspSuccessResult = new System.Windows.Forms.StatusStripPanel();
			this._SspRecordsAffected = new System.Windows.Forms.StatusStripPanel();
			this._SspExecutionTime = new System.Windows.Forms.StatusStripPanel();
			this._ScMain = new System.Windows.Forms.SplitContainer();
			this._BtnConnect = new System.Windows.Forms.Button();
			this._TxtConnectionString = new System.Windows.Forms.TextBox();
			this._ScQuery.Panel1.SuspendLayout();
			this._ScQuery.Panel2.SuspendLayout();
			this._ScQuery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._DgvResults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).BeginInit();
			this.topRaftingContainer.SuspendLayout();
			this._MsTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).BeginInit();
			this.bottomRaftingContainer.SuspendLayout();
			this._SsQuery.SuspendLayout();
			this._ScMain.Panel1.SuspendLayout();
			this._ScMain.Panel2.SuspendLayout();
			this._ScMain.SuspendLayout();
			this.SuspendLayout();
// 
// _ScQuery
// 
			this._ScQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ScQuery.Location = new System.Drawing.Point(0, 0);
			this._ScQuery.Name = "_ScQuery";
			this._ScQuery.Orientation = System.Windows.Forms.Orientation.Horizontal;
// 
// Panel1
// 
			this._ScQuery.Panel1.Controls.Add(this._TxtQuery);
// 
// Panel2
// 
			this._ScQuery.Panel2.Controls.Add(this._DgvResults);
			this._ScQuery.Size = new System.Drawing.Size(658, 339);
			this._ScQuery.SplitterDistance = 181;
			this._ScQuery.TabIndex = 0;
			this._ScQuery.Text = "_SCQuery";
// 
// _TxtQuery
// 
			this._TxtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._TxtQuery.Location = new System.Drawing.Point(0, 0);
			this._TxtQuery.Multiline = true;
			this._TxtQuery.Name = "_TxtQuery";
			this._TxtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._TxtQuery.Size = new System.Drawing.Size(658, 181);
			this._TxtQuery.TabIndex = 0;
// 
// _DgvResults
// 
			this._DgvResults.AllowUserToAddRows = false;
			this._DgvResults.AllowUserToDeleteRows = false;
			this._DgvResults.AllowUserToOrderColumns = true;
			this._DgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this._DgvResults.Location = new System.Drawing.Point(0, 0);
			this._DgvResults.Name = "_DgvResults";
			this._DgvResults.ReadOnly = true;
			this._DgvResults.Size = new System.Drawing.Size(658, 154);
			this._DgvResults.TabIndex = 0;
// 
// leftRaftingContainer
// 
			this.leftRaftingContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftRaftingContainer.Name = "leftRaftingContainer";
// 
// rightRaftingContainer
// 
			this.rightRaftingContainer.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightRaftingContainer.Name = "rightRaftingContainer";
// 
// topRaftingContainer
// 
			this.topRaftingContainer.Controls.Add(this._MsTop);
			this.topRaftingContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.topRaftingContainer.Name = "topRaftingContainer";
// 
// _MsTop
// 
			this._MsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MnuFile,
            this.queryToolStripMenuItem});
			this._MsTop.Location = new System.Drawing.Point(0, 0);
			this._MsTop.Name = "_MsTop";
			this._MsTop.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
			this._MsTop.Raft = System.Windows.Forms.RaftingSides.Top;
			this._MsTop.TabIndex = 0;
			this._MsTop.Text = "menuStrip1";
// 
// _MnuFile
// 
			this._MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MnuFileClose,
            this._MnuFileExit});
			this._MnuFile.Name = "_MnuFile";
			this._MnuFile.SettingsKey = "QueryUIForm.fileToolStripMenuItem";
			this._MnuFile.Text = "&File";
// 
// _MnuFileClose
// 
			this._MnuFileClose.Name = "_MnuFileClose";
			this._MnuFileClose.SettingsKey = "QueryUIForm.closeToolStripMenuItem";
			this._MnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this._MnuFileClose.Text = "&Close Query";
// 
// _MnuFileExit
// 
			this._MnuFileExit.Name = "_MnuFileExit";
			this._MnuFileExit.SettingsKey = "QueryUIForm.exitToolStripMenuItem";
			this._MnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this._MnuFileExit.Text = "E&xit";
// 
// queryToolStripMenuItem
// 
			this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.executeToolStripMenuItem});
			this.queryToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Append;
			this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
			this.queryToolStripMenuItem.SettingsKey = "FormQuery.queryToolStripMenuItem";
			this.queryToolStripMenuItem.Text = "&Query";
// 
// connectToolStripMenuItem
// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.SettingsKey = "FormQuery.connectToolStripMenuItem";
			this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.connectToolStripMenuItem.Text = "&Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.OnChangeConnectionString);
// 
// executeToolStripMenuItem
// 
			this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
			this.executeToolStripMenuItem.SettingsKey = "FormQuery.executeToolStripMenuItem";
			this.executeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.executeToolStripMenuItem.Text = "&Execute";
			this.executeToolStripMenuItem.Click += new System.EventHandler(this.OnMnuQueryExecuteClick);
// 
// bottomRaftingContainer
// 
			this.bottomRaftingContainer.Controls.Add(this._SsQuery);
			this.bottomRaftingContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomRaftingContainer.Name = "bottomRaftingContainer";
// 
// _SsQuery
// 
			this._SsQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SspSuccessResult,
            this._SspRecordsAffected,
            this._SspExecutionTime});
			this._SsQuery.Location = new System.Drawing.Point(0, 0);
			this._SsQuery.Name = "_SsQuery";
			this._SsQuery.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
			this._SsQuery.Raft = System.Windows.Forms.RaftingSides.Bottom;
			this._SsQuery.TabIndex = 0;
// 
// _SspSuccessResult
// 
			this._SspSuccessResult.Name = "_SspSuccessResult";
			this._SspSuccessResult.SettingsKey = "FormQuery.sStatusStripPanel";
// 
// _SspRecordsAffected
// 
			this._SspRecordsAffected.Name = "_SspRecordsAffected";
			this._SspRecordsAffected.SettingsKey = "FormQuery.testStatusStripPanel";
// 
// _SspExecutionTime
// 
			this._SspExecutionTime.Name = "_SspExecutionTime";
			this._SspExecutionTime.SettingsKey = "FormQuery.statusStripPanel1";
// 
// _ScMain
// 
			this._ScMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ScMain.Location = new System.Drawing.Point(0, 21);
			this._ScMain.Name = "_ScMain";
			this._ScMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
// 
// Panel1
// 
			this._ScMain.Panel1.Controls.Add(this._BtnConnect);
			this._ScMain.Panel1.Controls.Add(this._TxtConnectionString);
// 
// Panel2
// 
			this._ScMain.Panel2.Controls.Add(this._ScQuery);
			this._ScMain.Size = new System.Drawing.Size(658, 370);
			this._ScMain.SplitterDistance = 27;
			this._ScMain.TabIndex = 5;
			this._ScMain.Text = "splitContainer1";
// 
// _BtnConnect
// 
			this._BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._BtnConnect.Location = new System.Drawing.Point(577, 0);
			this._BtnConnect.Name = "_BtnConnect";
			this._BtnConnect.TabIndex = 1;
			this._BtnConnect.Text = "&Connect";
			this._BtnConnect.Click += new System.EventHandler(this.OnChangeConnectionString);
// 
// _TxtConnectionString
// 
			this._TxtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._TxtConnectionString.Location = new System.Drawing.Point(0, 0);
			this._TxtConnectionString.Multiline = true;
			this._TxtConnectionString.Name = "_TxtConnectionString";
			this._TxtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._TxtConnectionString.Size = new System.Drawing.Size(573, 25);
			this._TxtConnectionString.TabIndex = 0;
// 
// QueryUIForm
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(658, 410);
			this.Controls.Add(this._ScMain);
			this.Controls.Add(this.leftRaftingContainer);
			this.Controls.Add(this.rightRaftingContainer);
			this.Controls.Add(this.topRaftingContainer);
			this.Controls.Add(this.bottomRaftingContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "QueryUIForm";
			this.Text = "Query";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this._ScQuery.Panel1.ResumeLayout(false);
			this._ScQuery.Panel1.PerformLayout();
			this._ScQuery.Panel2.ResumeLayout(false);
			this._ScQuery.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._DgvResults)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).EndInit();
			this.topRaftingContainer.ResumeLayout(false);
			this.topRaftingContainer.PerformLayout();
			this._MsTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).EndInit();
			this.bottomRaftingContainer.ResumeLayout(false);
			this.bottomRaftingContainer.PerformLayout();
			this._SsQuery.ResumeLayout(false);
			this._ScMain.Panel1.ResumeLayout(false);
			this._ScMain.Panel1.PerformLayout();
			this._ScMain.Panel2.ResumeLayout(false);
			this._ScMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer _ScQuery;
		private System.Windows.Forms.TextBox _TxtQuery;
		private System.Windows.Forms.DataGridView _DgvResults;
		private System.Windows.Forms.RaftingContainer leftRaftingContainer;
		private System.Windows.Forms.RaftingContainer rightRaftingContainer;
		private System.Windows.Forms.RaftingContainer topRaftingContainer;
		private System.Windows.Forms.RaftingContainer bottomRaftingContainer;
		private System.Windows.Forms.SplitContainer _ScMain;
		private System.Windows.Forms.TextBox _TxtConnectionString;
		private System.Windows.Forms.Button _BtnConnect;
		private System.Windows.Forms.MenuStrip _MsTop;
		private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
		private System.Windows.Forms.StatusStrip _SsQuery;
		private System.Windows.Forms.StatusStripPanel _SspRecordsAffected;
		private System.Windows.Forms.StatusStripPanel _SspSuccessResult;
		private System.Windows.Forms.StatusStripPanel _SspExecutionTime;
		private System.Windows.Forms.ToolStripMenuItem _MnuFile;
		private System.Windows.Forms.ToolStripMenuItem _MnuFileClose;
		private System.Windows.Forms.ToolStripMenuItem _MnuFileExit;


	}
}
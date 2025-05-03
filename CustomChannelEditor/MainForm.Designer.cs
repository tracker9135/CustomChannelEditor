namespace CustomChannelEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXMLTVXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildChannelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrphanRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvChannelList = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelEpg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEpgList = new System.Windows.Forms.DataGridView();
            this.EpgIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpgReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFilterText = new System.Windows.Forms.ToolStripTextBox();
            this.tsFilter = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpgList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.importCustomToolStripMenuItem,
            this.buildChannelListToolStripMenuItem,
            this.clearOrphanRefToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1728, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openM3UToolStripMenuItem,
            this.openXMLTVXMLToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openM3UToolStripMenuItem
            // 
            this.openM3UToolStripMenuItem.Name = "openM3UToolStripMenuItem";
            this.openM3UToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openM3UToolStripMenuItem.Text = "Open M3U";
            this.openM3UToolStripMenuItem.Click += new System.EventHandler(this.openM3UToolStripMenuItem_Click);
            // 
            // openXMLTVXMLToolStripMenuItem
            // 
            this.openXMLTVXMLToolStripMenuItem.Name = "openXMLTVXMLToolStripMenuItem";
            this.openXMLTVXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openXMLTVXMLToolStripMenuItem.Text = "Open XMLTV.XML";
            this.openXMLTVXMLToolStripMenuItem.Click += new System.EventHandler(this.openXMLTVXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.nextToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.tsFilter_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // importCustomToolStripMenuItem
            // 
            this.importCustomToolStripMenuItem.Name = "importCustomToolStripMenuItem";
            this.importCustomToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.importCustomToolStripMenuItem.Text = "Import Custom";
            this.importCustomToolStripMenuItem.Click += new System.EventHandler(this.importCustomToolStripMenuItem_Click);
            // 
            // buildChannelListToolStripMenuItem
            // 
            this.buildChannelListToolStripMenuItem.Name = "buildChannelListToolStripMenuItem";
            this.buildChannelListToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.buildChannelListToolStripMenuItem.Text = "Build Channel List";
            this.buildChannelListToolStripMenuItem.Click += new System.EventHandler(this.buildChannelListToolStripMenuItem_Click);
            // 
            // clearOrphanRefToolStripMenuItem
            // 
            this.clearOrphanRefToolStripMenuItem.Name = "clearOrphanRefToolStripMenuItem";
            this.clearOrphanRefToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.clearOrphanRefToolStripMenuItem.Text = "Clear Orphan Ref";
            this.clearOrphanRefToolStripMenuItem.Click += new System.EventHandler(this.clearOrphanRefToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvChannelList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEpgList);
            this.splitContainer1.Size = new System.Drawing.Size(1728, 928);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvChannelList
            // 
            this.dgvChannelList.AllowUserToAddRows = false;
            this.dgvChannelList.AllowUserToDeleteRows = false;
            this.dgvChannelList.AllowUserToResizeRows = false;
            this.dgvChannelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChannelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.ChannelName,
            this.ChannelReference,
            this.ChannelEpg});
            this.dgvChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChannelList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvChannelList.Location = new System.Drawing.Point(0, 0);
            this.dgvChannelList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvChannelList.MultiSelect = false;
            this.dgvChannelList.Name = "dgvChannelList";
            this.dgvChannelList.RowHeadersWidth = 62;
            this.dgvChannelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChannelList.Size = new System.Drawing.Size(570, 928);
            this.dgvChannelList.TabIndex = 0;
            this.dgvChannelList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChannelList_CellContentClick);
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "Ch#";
            this.ItemNumber.MinimumWidth = 8;
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            this.ItemNumber.Width = 40;
            // 
            // ChannelName
            // 
            this.ChannelName.HeaderText = "Name";
            this.ChannelName.MinimumWidth = 8;
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.ReadOnly = true;
            this.ChannelName.Width = 200;
            // 
            // ChannelReference
            // 
            this.ChannelReference.HeaderText = "Reference";
            this.ChannelReference.MinimumWidth = 8;
            this.ChannelReference.Name = "ChannelReference";
            this.ChannelReference.ReadOnly = true;
            this.ChannelReference.Width = 200;
            // 
            // ChannelEpg
            // 
            this.ChannelEpg.HeaderText = "EPG";
            this.ChannelEpg.MinimumWidth = 8;
            this.ChannelEpg.Name = "ChannelEpg";
            this.ChannelEpg.ReadOnly = true;
            this.ChannelEpg.Width = 150;
            // 
            // dgvEpgList
            // 
            this.dgvEpgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EpgIndex,
            this.EpgName,
            this.EpgReference});
            this.dgvEpgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEpgList.Location = new System.Drawing.Point(0, 0);
            this.dgvEpgList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEpgList.MultiSelect = false;
            this.dgvEpgList.Name = "dgvEpgList";
            this.dgvEpgList.RowHeadersWidth = 62;
            this.dgvEpgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpgList.Size = new System.Drawing.Size(1152, 928);
            this.dgvEpgList.TabIndex = 0;
            this.dgvEpgList.DoubleClick += new System.EventHandler(this.dgvEpgList_DoubleClick);
            // 
            // EpgIndex
            // 
            this.EpgIndex.HeaderText = "Index";
            this.EpgIndex.MinimumWidth = 8;
            this.EpgIndex.Name = "EpgIndex";
            this.EpgIndex.Width = 50;
            // 
            // EpgName
            // 
            this.EpgName.HeaderText = "Name";
            this.EpgName.MinimumWidth = 8;
            this.EpgName.Name = "EpgName";
            this.EpgName.Width = 400;
            // 
            // EpgReference
            // 
            this.EpgReference.HeaderText = "Reference";
            this.EpgReference.MinimumWidth = 8;
            this.EpgReference.Name = "EpgReference";
            this.EpgReference.Width = 200;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFilterText,
            this.tsFilter,
            this.tsbNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1728, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFilterText
            // 
            this.tsFilterText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsFilterText.Name = "tsFilterText";
            this.tsFilterText.Size = new System.Drawing.Size(148, 33);
            this.tsFilterText.Enter += new System.EventHandler(this.tsFilterText_Enter);
            this.tsFilterText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsFilterText_KeyDown);
            // 
            // tsFilter
            // 
            this.tsFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsFilter.Image")));
            this.tsFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(34, 28);
            this.tsFilter.Text = "toolStripButton1";
            this.tsFilter.Click += new System.EventHandler(this.tsFilter_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(34, 28);
            this.tsbNext.Text = "toolStripButton1";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 994);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Custom Channel Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpgList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openM3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXMLTVXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvChannelList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelEpg;
        private System.Windows.Forms.ToolStripMenuItem buildChannelListToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFilter;
        private System.Windows.Forms.ToolStripTextBox tsFilterText;
        private System.Windows.Forms.DataGridView dgvEpgList;
        private System.Windows.Forms.ToolStripMenuItem importCustomToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpgIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpgReference;
        private System.Windows.Forms.ToolStripMenuItem clearOrphanRefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}


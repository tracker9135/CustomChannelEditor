using System;
using System.Windows.Forms;

namespace CustomChannelEditor
{
    public partial class PreferencesForm : Form
    {
        public string M3UPath { get; private set; }
        public string XMLTVPath { get; private set; }

        public PreferencesForm(string m3uPath, string xmltvPath)
        {
            InitializeComponent();
            
            M3UPath = m3uPath;
            XMLTVPath = xmltvPath;
            
            txtM3UPath.Text = M3UPath;
            txtXMLTVPath.Text = XMLTVPath;
        }
        
        private void btnBrowseM3U_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select default folder for M3U files";
                if (!string.IsNullOrEmpty(txtM3UPath.Text))
                    folderDialog.SelectedPath = txtM3UPath.Text;
                
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtM3UPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        
        private void btnBrowseXMLTV_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select default folder for XMLTV files";
                if (!string.IsNullOrEmpty(txtXMLTVPath.Text))
                    folderDialog.SelectedPath = txtXMLTVPath.Text;
                
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtXMLTVPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            M3UPath = txtM3UPath.Text;
            XMLTVPath = txtXMLTVPath.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Designer code will be auto-generated when you create the form
        private void InitializeComponent()
        {
            this.lblM3UPath = new System.Windows.Forms.Label();
            this.txtM3UPath = new System.Windows.Forms.TextBox();
            this.btnBrowseM3U = new System.Windows.Forms.Button();
            this.lblXMLTVPath = new System.Windows.Forms.Label();
            this.txtXMLTVPath = new System.Windows.Forms.TextBox();
            this.btnBrowseXMLTV = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblM3UPath
            // 
            this.lblM3UPath.AutoSize = true;
            this.lblM3UPath.Location = new System.Drawing.Point(12, 15);
            this.lblM3UPath.Name = "lblM3UPath";
            this.lblM3UPath.Size = new System.Drawing.Size(124, 13);
            this.lblM3UPath.TabIndex = 0;
            this.lblM3UPath.Text = "Default M3U Files Path:";
            // 
            // txtM3UPath
            // 
            this.txtM3UPath.Location = new System.Drawing.Point(12, 31);
            this.txtM3UPath.Name = "txtM3UPath";
            this.txtM3UPath.Size = new System.Drawing.Size(339, 20);
            this.txtM3UPath.TabIndex = 1;
            // 
            // btnBrowseM3U
            // 
            this.btnBrowseM3U.Location = new System.Drawing.Point(357, 29);
            this.btnBrowseM3U.Name = "btnBrowseM3U";
            this.btnBrowseM3U.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseM3U.TabIndex = 2;
            this.btnBrowseM3U.Text = "Browse...";
            this.btnBrowseM3U.UseVisualStyleBackColor = true;
            this.btnBrowseM3U.Click += new System.EventHandler(this.btnBrowseM3U_Click);
            // 
            // lblXMLTVPath
            // 
            this.lblXMLTVPath.AutoSize = true;
            this.lblXMLTVPath.Location = new System.Drawing.Point(12, 65);
            this.lblXMLTVPath.Name = "lblXMLTVPath";
            this.lblXMLTVPath.Size = new System.Drawing.Size(134, 13);
            this.lblXMLTVPath.TabIndex = 3;
            this.lblXMLTVPath.Text = "Default XMLTV Files Path:";
            // 
            // txtXMLTVPath
            // 
            this.txtXMLTVPath.Location = new System.Drawing.Point(12, 81);
            this.txtXMLTVPath.Name = "txtXMLTVPath";
            this.txtXMLTVPath.Size = new System.Drawing.Size(339, 20);
            this.txtXMLTVPath.TabIndex = 4;
            // 
            // btnBrowseXMLTV
            // 
            this.btnBrowseXMLTV.Location = new System.Drawing.Point(357, 79);
            this.btnBrowseXMLTV.Name = "btnBrowseXMLTV";
            this.btnBrowseXMLTV.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXMLTV.TabIndex = 5;
            this.btnBrowseXMLTV.Text = "Browse...";
            this.btnBrowseXMLTV.UseVisualStyleBackColor = true;
            this.btnBrowseXMLTV.Click += new System.EventHandler(this.btnBrowseXMLTV_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(276, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(357, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowseXMLTV);
            this.Controls.Add(this.txtXMLTVPath);
            this.Controls.Add(this.lblXMLTVPath);
            this.Controls.Add(this.btnBrowseM3U);
            this.Controls.Add(this.txtM3UPath);
            this.Controls.Add(this.lblM3UPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.Label lblM3UPath;
        private System.Windows.Forms.TextBox txtM3UPath;
        private System.Windows.Forms.Button btnBrowseM3U;
        private System.Windows.Forms.Label lblXMLTVPath;
        private System.Windows.Forms.TextBox txtXMLTVPath;
        private System.Windows.Forms.Button btnBrowseXMLTV;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

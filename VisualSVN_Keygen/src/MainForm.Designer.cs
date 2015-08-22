namespace FullO.Keygens.VisualSVN
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
			this.btnPatch = new System.Windows.Forms.Button();
			this.txtLicense = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.gpPatch = new System.Windows.Forms.GroupBox();
			this.chkMakeBackup = new System.Windows.Forms.CheckBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLbl = new System.Windows.Forms.LinkLabel();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.gpPatch.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPatch
			// 
			this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatch.Location = new System.Drawing.Point(358, 50);
			this.btnPatch.Name = "btnPatch";
			this.btnPatch.Size = new System.Drawing.Size(63, 23);
			this.btnPatch.TabIndex = 0;
			this.btnPatch.Text = "Patch";
			this.btnPatch.UseVisualStyleBackColor = true;
			this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
			// 
			// txtLicense
			// 
			this.txtLicense.BackColor = System.Drawing.SystemColors.Window;
			this.txtLicense.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLicense.Location = new System.Drawing.Point(6, 205);
			this.txtLicense.Multiline = true;
			this.txtLicense.Name = "txtLicense";
			this.txtLicense.ReadOnly = true;
			this.txtLicense.Size = new System.Drawing.Size(414, 135);
			this.txtLicense.TabIndex = 2;
			this.txtLicense.WordWrap = false;
			this.txtLicense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicense_KeyDown);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(345, 176);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// gpPatch
			// 
			this.gpPatch.Controls.Add(this.btnPatch);
			this.gpPatch.Controls.Add(this.chkMakeBackup);
			this.gpPatch.Controls.Add(this.btnBrowse);
			this.gpPatch.Controls.Add(this.txtPath);
			this.gpPatch.Controls.Add(this.lblPath);
			this.gpPatch.Dock = System.Windows.Forms.DockStyle.Top;
			this.gpPatch.Location = new System.Drawing.Point(5, 59);
			this.gpPatch.Name = "gpPatch";
			this.gpPatch.Size = new System.Drawing.Size(427, 81);
			this.gpPatch.TabIndex = 4;
			this.gpPatch.TabStop = false;
			this.gpPatch.Text = "1. Replace public key in VisualSVN.VS.Interface.dll file";
			// 
			// chkMakeBackup
			// 
			this.chkMakeBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.chkMakeBackup.Checked = true;
			this.chkMakeBackup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkMakeBackup.Location = new System.Drawing.Point(9, 54);
			this.chkMakeBackup.Name = "chkMakeBackup";
			this.chkMakeBackup.Size = new System.Drawing.Size(256, 17);
			this.chkMakeBackup.TabIndex = 4;
			this.chkMakeBackup.Text = "Make a backup (VisualSVN.VS.Interface.dll.bck)";
			this.chkMakeBackup.UseVisualStyleBackColor = true;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(395, 22);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(26, 23);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(80, 24);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(309, 20);
			this.txtPath.TabIndex = 2;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(6, 27);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(68, 13);
			this.lblPath.TabIndex = 1;
			this.lblPath.Text = "File to patch:";
			// 
			// lblDesc
			// 
			this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDesc.Location = new System.Drawing.Point(5, 5);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Padding = new System.Windows.Forms.Padding(5);
			this.lblDesc.Size = new System.Drawing.Size(427, 54);
			this.lblDesc.TabIndex = 5;
			this.lblDesc.Text = resources.GetString("lblDesc.Text");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLbl);
			this.groupBox1.Controls.Add(this.propertyGrid1);
			this.groupBox1.Controls.Add(this.btnGenerate);
			this.groupBox1.Controls.Add(this.txtLicense);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(5, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(427, 346);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "2. Generate license (Some options are mutually incompatible)";
			// 
			// linkLbl
			// 
			this.linkLbl.AutoSize = true;
			this.linkLbl.Location = new System.Drawing.Point(6, 181);
			this.linkLbl.Name = "linkLbl";
			this.linkLbl.Size = new System.Drawing.Size(237, 13);
			this.linkLbl.TabIndex = 9;
			this.linkLbl.TabStop = true;
			this.linkLbl.Text = "http://www.visualsvn.com/visualsvn/download/";
			this.linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.Location = new System.Drawing.Point(9, 19);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(411, 151);
			this.propertyGrid1.TabIndex = 4;
			this.propertyGrid1.ToolbarVisible = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.CheckFileExists = false;
			this.openFileDialog.CheckPathExists = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 491);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gpPatch);
			this.Controls.Add(this.lblDesc);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VisualSVN 1.x keygen - [FullO]ptionite";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gpPatch.ResumeLayout(false);
			this.gpPatch.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPatch;
		private System.Windows.Forms.TextBox txtLicense;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox gpPatch;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.CheckBox chkMakeBackup;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.LinkLabel linkLbl;
	}
}


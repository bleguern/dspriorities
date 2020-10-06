/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 06/04/2007
 * Time: 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DS_Priorities
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDsPrioritiesLaunch = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.gbxDir = new System.Windows.Forms.GroupBox();
			this.gbxDsPO = new System.Windows.Forms.GroupBox();
			this.txbDsPOFolder = new System.Windows.Forms.TextBox();
			this.btnDsPOFileExport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDsPOFolder = new System.Windows.Forms.Button();
			this.lblDsPOFolder = new System.Windows.Forms.Label();
			this.txbDsPOFileExport = new System.Windows.Forms.TextBox();
			this.gbxDsPriorities = new System.Windows.Forms.GroupBox();
			this.txbDsPrioritiesFolder = new System.Windows.Forms.TextBox();
			this.btnDsPrioritiesFileExport = new System.Windows.Forms.Button();
			this.lblFileExport = new System.Windows.Forms.Label();
			this.btnDsPrioritiesFolder = new System.Windows.Forms.Button();
			this.lblDsPrioritiesFolder = new System.Windows.Forms.Label();
			this.txbDsPrioritiesFileExport = new System.Windows.Forms.TextBox();
			this.lblCustomerDatabaseFolder = new System.Windows.Forms.Label();
			this.btnCustomerDatabaseFolder = new System.Windows.Forms.Button();
			this.txbCustomerDatabaseFolder = new System.Windows.Forms.TextBox();
			this.gbxInformation = new System.Windows.Forms.GroupBox();
			this.lblHorizon = new System.Windows.Forms.Label();
			this.fbdCustomerDatabaseFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.fbdDsPrioritiesFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.ofdDsPrioritiesExportFile = new System.Windows.Forms.OpenFileDialog();
			this.btnDsPOLaunch = new System.Windows.Forms.Button();
			this.fbdDsPOFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.ofdDsPOExportFile = new System.Windows.Forms.OpenFileDialog();
			this.labelVersion = new System.Windows.Forms.Label();
			this.gbxDir.SuspendLayout();
			this.gbxDsPO.SuspendLayout();
			this.gbxDsPriorities.SuspendLayout();
			this.gbxInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDsPrioritiesLaunch
			// 
			this.btnDsPrioritiesLaunch.Enabled = false;
			this.btnDsPrioritiesLaunch.Location = new System.Drawing.Point(12, 421);
			this.btnDsPrioritiesLaunch.Name = "btnDsPrioritiesLaunch";
			this.btnDsPrioritiesLaunch.Size = new System.Drawing.Size(131, 23);
			this.btnDsPrioritiesLaunch.TabIndex = 0;
			this.btnDsPrioritiesLaunch.Text = "Lancer les priorités";
			this.btnDsPrioritiesLaunch.UseVisualStyleBackColor = true;
			this.btnDsPrioritiesLaunch.Click += new System.EventHandler(this.BtnDsPrioritiesLaunchClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(362, 421);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 1;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// gbxDir
			// 
			this.gbxDir.Controls.Add(this.gbxDsPO);
			this.gbxDir.Controls.Add(this.gbxDsPriorities);
			this.gbxDir.Controls.Add(this.lblCustomerDatabaseFolder);
			this.gbxDir.Controls.Add(this.btnCustomerDatabaseFolder);
			this.gbxDir.Controls.Add(this.txbCustomerDatabaseFolder);
			this.gbxDir.Location = new System.Drawing.Point(12, 29);
			this.gbxDir.Name = "gbxDir";
			this.gbxDir.Size = new System.Drawing.Size(426, 293);
			this.gbxDir.TabIndex = 2;
			this.gbxDir.TabStop = false;
			this.gbxDir.Text = "Répertoires et fichiers";
			// 
			// gbxDsPO
			// 
			this.gbxDsPO.Controls.Add(this.txbDsPOFolder);
			this.gbxDsPO.Controls.Add(this.btnDsPOFileExport);
			this.gbxDsPO.Controls.Add(this.label1);
			this.gbxDsPO.Controls.Add(this.btnDsPOFolder);
			this.gbxDsPO.Controls.Add(this.lblDsPOFolder);
			this.gbxDsPO.Controls.Add(this.txbDsPOFileExport);
			this.gbxDsPO.Location = new System.Drawing.Point(6, 63);
			this.gbxDsPO.Name = "gbxDsPO";
			this.gbxDsPO.Size = new System.Drawing.Size(412, 105);
			this.gbxDsPO.TabIndex = 9;
			this.gbxDsPO.TabStop = false;
			this.gbxDsPO.Text = "Ordres de fabrication";
			// 
			// txbDsPOFolder
			// 
			this.txbDsPOFolder.Location = new System.Drawing.Point(6, 79);
			this.txbDsPOFolder.Name = "txbDsPOFolder";
			this.txbDsPOFolder.ReadOnly = true;
			this.txbDsPOFolder.Size = new System.Drawing.Size(319, 20);
			this.txbDsPOFolder.TabIndex = 1;
			// 
			// btnDsPOFileExport
			// 
			this.btnDsPOFileExport.Location = new System.Drawing.Point(331, 36);
			this.btnDsPOFileExport.Name = "btnDsPOFileExport";
			this.btnDsPOFileExport.Size = new System.Drawing.Size(75, 20);
			this.btnDsPOFileExport.TabIndex = 7;
			this.btnDsPOFileExport.Text = "...";
			this.btnDsPOFileExport.UseVisualStyleBackColor = true;
			this.btnDsPOFileExport.Click += new System.EventHandler(this.BtnDsPOFileExportClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Fichier export DSRP :";
			// 
			// btnDsPOFolder
			// 
			this.btnDsPOFolder.Location = new System.Drawing.Point(331, 78);
			this.btnDsPOFolder.Name = "btnDsPOFolder";
			this.btnDsPOFolder.Size = new System.Drawing.Size(75, 20);
			this.btnDsPOFolder.TabIndex = 3;
			this.btnDsPOFolder.Text = "...";
			this.btnDsPOFolder.UseVisualStyleBackColor = true;
			this.btnDsPOFolder.Click += new System.EventHandler(this.BtnDsPOFolderClick);
			// 
			// lblDsPOFolder
			// 
			this.lblDsPOFolder.Location = new System.Drawing.Point(6, 59);
			this.lblDsPOFolder.Name = "lblDsPOFolder";
			this.lblDsPOFolder.Size = new System.Drawing.Size(200, 16);
			this.lblDsPOFolder.TabIndex = 5;
			this.lblDsPOFolder.Text = "Répertoire d\'exportation des OF :";
			// 
			// txbDsPOFileExport
			// 
			this.txbDsPOFileExport.Location = new System.Drawing.Point(6, 36);
			this.txbDsPOFileExport.Name = "txbDsPOFileExport";
			this.txbDsPOFileExport.ReadOnly = true;
			this.txbDsPOFileExport.Size = new System.Drawing.Size(319, 20);
			this.txbDsPOFileExport.TabIndex = 6;
			// 
			// gbxDsPriorities
			// 
			this.gbxDsPriorities.Controls.Add(this.txbDsPrioritiesFolder);
			this.gbxDsPriorities.Controls.Add(this.btnDsPrioritiesFileExport);
			this.gbxDsPriorities.Controls.Add(this.lblFileExport);
			this.gbxDsPriorities.Controls.Add(this.btnDsPrioritiesFolder);
			this.gbxDsPriorities.Controls.Add(this.lblDsPrioritiesFolder);
			this.gbxDsPriorities.Controls.Add(this.txbDsPrioritiesFileExport);
			this.gbxDsPriorities.Location = new System.Drawing.Point(6, 174);
			this.gbxDsPriorities.Name = "gbxDsPriorities";
			this.gbxDsPriorities.Size = new System.Drawing.Size(412, 105);
			this.gbxDsPriorities.TabIndex = 4;
			this.gbxDsPriorities.TabStop = false;
			this.gbxDsPriorities.Text = "Priorités";
			// 
			// txbDsPrioritiesFolder
			// 
			this.txbDsPrioritiesFolder.Location = new System.Drawing.Point(6, 79);
			this.txbDsPrioritiesFolder.Name = "txbDsPrioritiesFolder";
			this.txbDsPrioritiesFolder.ReadOnly = true;
			this.txbDsPrioritiesFolder.Size = new System.Drawing.Size(319, 20);
			this.txbDsPrioritiesFolder.TabIndex = 1;
			// 
			// btnDsPrioritiesFileExport
			// 
			this.btnDsPrioritiesFileExport.Location = new System.Drawing.Point(331, 35);
			this.btnDsPrioritiesFileExport.Name = "btnDsPrioritiesFileExport";
			this.btnDsPrioritiesFileExport.Size = new System.Drawing.Size(75, 20);
			this.btnDsPrioritiesFileExport.TabIndex = 7;
			this.btnDsPrioritiesFileExport.Text = "...";
			this.btnDsPrioritiesFileExport.UseVisualStyleBackColor = true;
			this.btnDsPrioritiesFileExport.Click += new System.EventHandler(this.BtnDsPrioritiesFileExportClick);
			// 
			// lblFileExport
			// 
			this.lblFileExport.Location = new System.Drawing.Point(6, 16);
			this.lblFileExport.Name = "lblFileExport";
			this.lblFileExport.Size = new System.Drawing.Size(211, 19);
			this.lblFileExport.TabIndex = 8;
			this.lblFileExport.Text = "Fichier export DSRP :";
			// 
			// btnDsPrioritiesFolder
			// 
			this.btnDsPrioritiesFolder.Location = new System.Drawing.Point(331, 78);
			this.btnDsPrioritiesFolder.Name = "btnDsPrioritiesFolder";
			this.btnDsPrioritiesFolder.Size = new System.Drawing.Size(75, 20);
			this.btnDsPrioritiesFolder.TabIndex = 3;
			this.btnDsPrioritiesFolder.Text = "...";
			this.btnDsPrioritiesFolder.UseVisualStyleBackColor = true;
			this.btnDsPrioritiesFolder.Click += new System.EventHandler(this.BtnDsPrioritiesFolderClick);
			// 
			// lblDsPrioritiesFolder
			// 
			this.lblDsPrioritiesFolder.Location = new System.Drawing.Point(6, 59);
			this.lblDsPrioritiesFolder.Name = "lblDsPrioritiesFolder";
			this.lblDsPrioritiesFolder.Size = new System.Drawing.Size(212, 16);
			this.lblDsPrioritiesFolder.TabIndex = 5;
			this.lblDsPrioritiesFolder.Text = "Répertoire d\'exportation des priorités :";
			// 
			// txbDsPrioritiesFileExport
			// 
			this.txbDsPrioritiesFileExport.Location = new System.Drawing.Point(6, 36);
			this.txbDsPrioritiesFileExport.Name = "txbDsPrioritiesFileExport";
			this.txbDsPrioritiesFileExport.ReadOnly = true;
			this.txbDsPrioritiesFileExport.Size = new System.Drawing.Size(319, 20);
			this.txbDsPrioritiesFileExport.TabIndex = 6;
			// 
			// lblCustomerDatabaseFolder
			// 
			this.lblCustomerDatabaseFolder.Location = new System.Drawing.Point(6, 16);
			this.lblCustomerDatabaseFolder.Name = "lblCustomerDatabaseFolder";
			this.lblCustomerDatabaseFolder.Size = new System.Drawing.Size(212, 19);
			this.lblCustomerDatabaseFolder.TabIndex = 4;
			this.lblCustomerDatabaseFolder.Text = "Répertoire de la base DS :";
			// 
			// btnCustomerDatabaseFolder
			// 
			this.btnCustomerDatabaseFolder.Location = new System.Drawing.Point(343, 36);
			this.btnCustomerDatabaseFolder.Name = "btnCustomerDatabaseFolder";
			this.btnCustomerDatabaseFolder.Size = new System.Drawing.Size(75, 20);
			this.btnCustomerDatabaseFolder.TabIndex = 2;
			this.btnCustomerDatabaseFolder.Text = "...";
			this.btnCustomerDatabaseFolder.UseVisualStyleBackColor = true;
			this.btnCustomerDatabaseFolder.Click += new System.EventHandler(this.BtnCustomerDatabaseFolderClick);
			// 
			// txbCustomerDatabaseFolder
			// 
			this.txbCustomerDatabaseFolder.Location = new System.Drawing.Point(12, 37);
			this.txbCustomerDatabaseFolder.Name = "txbCustomerDatabaseFolder";
			this.txbCustomerDatabaseFolder.ReadOnly = true;
			this.txbCustomerDatabaseFolder.Size = new System.Drawing.Size(325, 20);
			this.txbCustomerDatabaseFolder.TabIndex = 0;
			// 
			// gbxInformation
			// 
			this.gbxInformation.Controls.Add(this.lblHorizon);
			this.gbxInformation.Location = new System.Drawing.Point(12, 328);
			this.gbxInformation.Name = "gbxInformation";
			this.gbxInformation.Size = new System.Drawing.Size(425, 87);
			this.gbxInformation.TabIndex = 3;
			this.gbxInformation.TabStop = false;
			this.gbxInformation.Text = "Informations";
			// 
			// lblHorizon
			// 
			this.lblHorizon.Location = new System.Drawing.Point(6, 16);
			this.lblHorizon.Name = "lblHorizon";
			this.lblHorizon.Size = new System.Drawing.Size(412, 68);
			this.lblHorizon.TabIndex = 0;
			// 
			// btnDsPOLaunch
			// 
			this.btnDsPOLaunch.Enabled = false;
			this.btnDsPOLaunch.Location = new System.Drawing.Point(149, 421);
			this.btnDsPOLaunch.Name = "btnDsPOLaunch";
			this.btnDsPOLaunch.Size = new System.Drawing.Size(90, 23);
			this.btnDsPOLaunch.TabIndex = 4;
			this.btnDsPOLaunch.Text = "Export des OFs";
			this.btnDsPOLaunch.UseVisualStyleBackColor = true;
			this.btnDsPOLaunch.Click += new System.EventHandler(this.BtnDsPOLaunchClick);
			// 
			// labelVersion
			// 
			this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.Location = new System.Drawing.Point(163, 9);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(275, 19);
			this.labelVersion.TabIndex = 10;
			this.labelVersion.Text = "Version de l\'application : ";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 452);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.btnDsPOLaunch);
			this.Controls.Add(this.gbxInformation);
			this.Controls.Add(this.gbxDir);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnDsPrioritiesLaunch);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Ordres de fabrication & priorités DS";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gbxDir.ResumeLayout(false);
			this.gbxDir.PerformLayout();
			this.gbxDsPO.ResumeLayout(false);
			this.gbxDsPO.PerformLayout();
			this.gbxDsPriorities.ResumeLayout(false);
			this.gbxDsPriorities.PerformLayout();
			this.gbxInformation.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.FolderBrowserDialog fbdDsPOFolder;
		private System.Windows.Forms.FolderBrowserDialog fbdCustomerDatabaseFolder;
		private System.Windows.Forms.Label lblDsPrioritiesFolder;
		private System.Windows.Forms.Label lblCustomerDatabaseFolder;
		private System.Windows.Forms.TextBox txbCustomerDatabaseFolder;
		private System.Windows.Forms.TextBox txbDsPrioritiesFolder;
		private System.Windows.Forms.Button btnDsPrioritiesFolder;
		private System.Windows.Forms.Button btnCustomerDatabaseFolder;
		private System.Windows.Forms.TextBox txbDsPOFolder;
		private System.Windows.Forms.Button btnDsPOFolder;
		private System.Windows.Forms.Label lblDsPOFolder;
		private System.Windows.Forms.OpenFileDialog ofdDsPOExportFile;
		private System.Windows.Forms.FolderBrowserDialog fbdDsPrioritiesFolder;
		private System.Windows.Forms.OpenFileDialog ofdDsPrioritiesExportFile;
		private System.Windows.Forms.Button btnDsPrioritiesLaunch;
		private System.Windows.Forms.Button btnDsPOLaunch;
		private System.Windows.Forms.GroupBox gbxDsPriorities;
		private System.Windows.Forms.TextBox txbDsPOFileExport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDsPOFileExport;
		private System.Windows.Forms.GroupBox gbxDsPO;
		private System.Windows.Forms.Button btnDsPrioritiesFileExport;
		private System.Windows.Forms.TextBox txbDsPrioritiesFileExport;
		
		private System.Windows.Forms.Label lblHorizon;
		private System.Windows.Forms.GroupBox gbxInformation;
		private System.Windows.Forms.Label lblFileExport;
		private System.Windows.Forms.GroupBox gbxDir;
		private System.Windows.Forms.Button btnQuit;
	}
}

/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 06/04/2007
 * Time: 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace DS_Priorities
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private const string FOREHIST_FILENAME = "FOREHIST.TXT";
		private const string CONFIG_FILENAME = "config.xml";
		
		private string dsPrioritiesFolder = null;
		private string dsPOFolder = null;
		private string customerDatabase = null;
		private string exportDsPrioritiesFileName = null;
		private string exportDsPOFileName = null;
		private string dsFormat = "ORIGINAL";
		
		private int horizon = 24;
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			LoadDefault();
			InitMainForm();
		}
		
		private void LoadDefault()
		{
			string ds_priorities = "";
			string ds_po = "";
			string database = "";
			string export_priorities = "";
			string export_po = "";
			
			if (File.Exists(Application.StartupPath + "\\" + CONFIG_FILENAME))
			{
				try
	            {
	                XmlDocument config = new XmlDocument();
	
	                config.Load(Application.StartupPath + "\\" + CONFIG_FILENAME);
	
	                ds_priorities = config.DocumentElement.SelectSingleNode("//config/directories/directory[@name='ds_priorities']/@value").Value;
	                ds_po = config.DocumentElement.SelectSingleNode("//config/directories/directory[@name='ds_po']/@value").Value;
	                database = config.DocumentElement.SelectSingleNode("//config/directories/directory[@name='customer_database']/@value").Value;
	                export_priorities = config.DocumentElement.SelectSingleNode("//config/files/file[@name='export_priorities']/@value").Value;
	                export_po = config.DocumentElement.SelectSingleNode("//config/files/file[@name='export_po']/@value").Value;
	                horizon = Convert.ToInt32(config.DocumentElement.SelectSingleNode("//config/horizon[@name='weeks']/@value").Value);
	                dsFormat = config.DocumentElement.SelectSingleNode("//config/ds[@name='version']/@value").Value;
	                
					if (File.Exists(database + "\\" + FOREHIST_FILENAME))
	            	{
						customerDatabase = database;
	            		txbCustomerDatabaseFolder.Text = database;
					}
					
					if ((ds_po != null) && (Directory.Exists(ds_po)))
		            {
		            	dsPOFolder = ds_po;
						txbDsPOFolder.Text = dsPOFolder;
		            }
					
					if (File.Exists(export_po))
		            {
		            	exportDsPOFileName = export_po;
						txbDsPOFileExport.Text = exportDsPOFileName;
		            }
					
					if ((ds_priorities != null) && (Directory.Exists(ds_priorities)))
		            {
		            	dsPrioritiesFolder = ds_priorities;
						txbDsPrioritiesFolder.Text = dsPrioritiesFolder;
		            }
					
					if (File.Exists(export_priorities))
		            {
		            	exportDsPrioritiesFileName = export_priorities;
						txbDsPrioritiesFileExport.Text = exportDsPrioritiesFileName;
		            }
					
					
					
					lblHorizon.Text = "Date du jour : " + DateTime.Now.ToShortDateString() + " / Semaine : " + ((DateTime.Now.DayOfYear / 7) + 1).ToString() + "\n\n" + 
									  "Horizon : " + horizon.ToString() + " semaines\n\n" + 
									  "Version de DS : " + dsFormat.ToString();
					
					
				}
	            catch (Exception)
	            {
	            	
	            }
			}
		}
		
		void InitMainForm()
		{
			btnDsPOLaunch.Enabled = false;
			btnDsPrioritiesLaunch.Enabled = false;
			
			if (!txbCustomerDatabaseFolder.Text.Equals(""))
			{
				if ((!txbDsPOFileExport.Text.Equals("")) && (!txbDsPOFolder.Text.Equals("")))
				{
					btnDsPOLaunch.Enabled = true;
				}
				
				if ((!txbDsPrioritiesFileExport.Text.Equals("")) && (!txbDsPrioritiesFolder.Text.Equals("")))
				{
					btnDsPrioritiesLaunch.Enabled = true;
				}
			}			
		}
		
		void BtnQuitClick(object sender, EventArgs e)
		{
			try
            {
                XmlDocument config = new XmlDocument();

                config.LoadXml("<?xml version=\"1.0\"?>" +
                               "<config>" +
                                "<directories>" +
                                    "<directory name=\"ds_priorities\" value=\"" + txbDsPrioritiesFolder.Text + "\" />" +
                                    "<directory name=\"ds_po\" value=\"" + txbDsPOFolder.Text + "\" />" +
                                    "<directory name=\"customer_database\" value=\"" + txbCustomerDatabaseFolder.Text + "\" />" +
                                "</directories>" + 
                                "<files>" +
                                	"<file name=\"export_priorities\" value=\"" + txbDsPrioritiesFileExport.Text + "\" />" +
                                	"<file name=\"export_po\" value=\"" + txbDsPOFileExport.Text + "\" />" +
                                "</files>" + 
                                "<horizon name=\"weeks\" value=\"" + horizon + "\" />" +
                                "<ds name=\"version\" value=\"" + dsFormat + "\" />" +
                               "</config>");

                config.Save(Application.StartupPath + "\\" + CONFIG_FILENAME);
            }
            catch (Exception)
            {
            	
            }
            
			this.Close();
			Application.Exit();
		}
		
		void BtnDsPrioritiesLaunchClick(object sender, EventArgs e)
		{
			ResultForm result = new ResultForm(dsPrioritiesFolder,
			                                   dsPOFolder,
			                                   customerDatabase, 
			                                   exportDsPrioritiesFileName, 
			                                   exportDsPOFileName,
			                                   horizon, 
			                                   dsFormat);
			
			result.LoadFrame();
			result.ShowDialog(this);
		}
		
		void BtnCustomerDatabaseFolderClick(object sender, EventArgs e)
		{
			fbdCustomerDatabaseFolder = new FolderBrowserDialog();
			fbdCustomerDatabaseFolder.SelectedPath = customerDatabase;
			
			if (fbdCustomerDatabaseFolder.ShowDialog() == DialogResult.OK) {
				
				string customerDatabaseFolder = fbdCustomerDatabaseFolder.SelectedPath;
	            
	            if (File.Exists(customerDatabaseFolder + "\\" + FOREHIST_FILENAME))
            	{
            		txbCustomerDatabaseFolder.Text = customerDatabaseFolder;
            		customerDatabase = customerDatabaseFolder;
            	}
            	else
            	{
            		MessageBox.Show(this, "Aucune base client trouvée dans \"" + customerDatabaseFolder + "\".", "Répertoire incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            	}
			}
			
			InitMainForm();
		}
		
		void BtnDsPrioritiesFolderClick(object sender, EventArgs e)
		{
			fbdDsPrioritiesFolder = new FolderBrowserDialog();
			fbdDsPrioritiesFolder.SelectedPath = dsPrioritiesFolder;
			
			if (fbdDsPrioritiesFolder.ShowDialog() == DialogResult.OK) {
				
				string prioritiesFolder = fbdDsPrioritiesFolder.SelectedPath;
	            
	            if ((prioritiesFolder == null) || (!Directory.Exists(prioritiesFolder)))
	            {
	            	MessageBox.Show(this, "Répertoire des priorités DS incorrect : " + prioritiesFolder, "Répertoire incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
	            else
	            {
	            	txbDsPrioritiesFolder.Text = prioritiesFolder;
	            	dsPrioritiesFolder = prioritiesFolder;
	            }
			}
			
			InitMainForm();
		}
		
		void BtnDsPrioritiesFileExportClick(object sender, EventArgs e)
		{
			ofdDsPrioritiesExportFile = new OpenFileDialog();
			ofdDsPrioritiesExportFile.FileName = exportDsPrioritiesFileName;
			
			if (ofdDsPrioritiesExportFile.ShowDialog() == DialogResult.OK) {
				
				string exportFile = ofdDsPrioritiesExportFile.FileName;
	            
	            if (!File.Exists(exportFile))
	            {
	            	MessageBox.Show(this, "Fichier incorrect : " + exportFile, "Fichier incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
	            else
	            {
	            	txbDsPrioritiesFileExport.Text = exportFile;
	            	exportDsPrioritiesFileName = exportFile;
	            }
			}
			
			InitMainForm();
		}
		
		void BtnDsPOFolderClick(object sender, EventArgs e)
		{
			fbdDsPOFolder = new FolderBrowserDialog();
			fbdDsPOFolder.SelectedPath = dsPOFolder;
			
			if (fbdDsPOFolder.ShowDialog() == DialogResult.OK) {
				
				string poFolder = fbdDsPOFolder.SelectedPath;
	            
	            if ((poFolder == null) || (!Directory.Exists(poFolder)))
	            {
	            	MessageBox.Show(this, "Répertoire des ordres de fabrication DS incorrect : " + poFolder, "Répertoire incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
	            else
	            {
	            	txbDsPOFolder.Text = poFolder;
	            	dsPOFolder = poFolder;
	            }
			}
			
			InitMainForm();
		}
		
		void BtnDsPOFileExportClick(object sender, EventArgs e)
		{
			ofdDsPOExportFile = new OpenFileDialog();
			ofdDsPOExportFile.FileName = exportDsPOFileName;
			
			if (ofdDsPOExportFile.ShowDialog() == DialogResult.OK) {
				
				string exportFile = ofdDsPOExportFile.FileName;
	            
	            if (!File.Exists(exportFile))
	            {
	            	MessageBox.Show(this, "Fichier incorrect : " + exportFile, "Fichier incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
	            else
	            {
	            	txbDsPOFileExport.Text = exportFile;
	            	exportDsPOFileName = exportFile;
	            }
			}
			
			InitMainForm();
		}
		
		void BtnDsPOLaunchClick(object sender, EventArgs e)
		{
			ResultForm result = new ResultForm(dsPrioritiesFolder,
			                                   dsPOFolder,
			                                   customerDatabase, 
			                                   exportDsPrioritiesFileName, 
			                                   exportDsPOFileName,
			                                   horizon, 
			                                   dsFormat);
			
			
			if (result.LoadDsPO())
			{
				result.SaveDsPO();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			labelVersion.Text = "Version de l'application : " + Application.ProductVersion;
		}
	}
}

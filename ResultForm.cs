/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 06/04/2007
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace DS_Priorities
{
	/// <summary>
	/// Description of ResultForm.
	/// </summary>
	public partial class ResultForm : Form
	{
		private const string DSJOUR_FILENAME = "DSJOUR.DAT";
		private const string RECEIPTS_FILENAME = "RECEIPTS.DAT";
		private const string PRIORITIES_RESULT_FILENAME = "FAWLPI1.TXT";
		private const string PO_RESULT_FILENAME = "TDSOF1.TXT";
		
		private string dsPrioritiesFolder = null;
		private string dsPOFolder = null;
		private string customerDatabase = null;
		private string exportDsPrioritiesFileName = null;
		private string exportDsPOFileName = null;
		
		private int horizon = 24;
		
		private string dsFormat = "ORIGINAL";
		
		private System.Data.DataTable receiptsTable = new System.Data.DataTable();
		private System.Data.DataTable dsjourTable = new System.Data.DataTable();
		private System.Data.DataTable exportTable = new System.Data.DataTable();
		private System.Data.DataTable dsPoTable = new System.Data.DataTable();
		
		private System.Data.DataTable resultTable = new System.Data.DataTable();
		
		public ResultForm(string dsPrioritiesFolder, 
			              string dsPOFolder, 
			              string customerDatabase, 
			              string exportDsPrioritiesFileName, 
			              string exportDsPOFileName,
			              int horizonValue, 
			              string dsFormatValue)
		{
			this.dsPrioritiesFolder = dsPrioritiesFolder;
			this.dsPOFolder = dsPOFolder;
			this.customerDatabase = customerDatabase;
			this.exportDsPrioritiesFileName = exportDsPrioritiesFileName;
			this.exportDsPOFileName = exportDsPOFileName;
			
			this.horizon = horizonValue;
			this.dsFormat = dsFormatValue;
		}
		
		public void LoadFrame() {
			InitializeComponent();
			LoadDefault();
		}
		
		private void LoadDefault()
		{
			lblDate.Text = "Date du jour : " + DateTime.Now.ToShortDateString() + " / Semaine : " + ((DateTime.Now.DayOfYear / 7) + 1).ToString();
			
			if (LoadData())
			{
				foreach (DataRow row in resultTable.Rows)
				{
					dgvReceipts.Rows.Add(row.ItemArray);
				}
			}
		}
		
		private bool LoadReceipts()
		{
			if (dsFormat.Equals("ORIGINAL"))
			{
				receiptsTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            receiptsTable.Columns[0].MaxLength = 20;
	            receiptsTable.Columns.Add("Quantity", System.Type.GetType("System.String"));
	            receiptsTable.Columns[1].MaxLength = 8;
	            receiptsTable.Columns[1].Caption = "Number";
	            receiptsTable.Columns.Add("Filler", System.Type.GetType("System.String"));
	            receiptsTable.Columns[2].MaxLength = 1;
	            receiptsTable.Columns.Add("PO_Number", System.Type.GetType("System.String"));
	            receiptsTable.Columns[3].MaxLength = 9;
	            receiptsTable.Columns.Add("Description", System.Type.GetType("System.String"));
	            receiptsTable.Columns[4].MaxLength = 51;
	            receiptsTable.Columns.Add("Date", System.Type.GetType("System.String"));
	            receiptsTable.Columns[5].MaxLength = 6;
			}
			else if (dsFormat.Equals("10"))
			{
				receiptsTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            receiptsTable.Columns[0].MaxLength = 78;
	            receiptsTable.Columns.Add("Quantity", System.Type.GetType("System.String"));
	            receiptsTable.Columns[1].MaxLength = 8;
	            receiptsTable.Columns[1].Caption = "Number";
	            receiptsTable.Columns.Add("Filler", System.Type.GetType("System.String"));
	            receiptsTable.Columns[2].MaxLength = 1;
	            receiptsTable.Columns.Add("PO_Number", System.Type.GetType("System.String"));
	            receiptsTable.Columns[3].MaxLength = 9;
	            receiptsTable.Columns.Add("Description", System.Type.GetType("System.String"));
	            receiptsTable.Columns[4].MaxLength = 51;
	            receiptsTable.Columns.Add("Date", System.Type.GetType("System.String"));
	            receiptsTable.Columns[5].MaxLength = 8;
			}
			else
			{
				return false;
			}
			
			return DSPrioritiesIO.LoadFile(customerDatabase + "\\" + RECEIPTS_FILENAME, ref receiptsTable);
		}
		
		private bool LoadDsjour()
		{
			if (dsFormat.Equals("ORIGINAL"))
			{
				dsjourTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            dsjourTable.Columns[0].MaxLength = 20;
	            dsjourTable.Columns.Add("Description", System.Type.GetType("System.String"));
	            dsjourTable.Columns[1].MaxLength = 24;
	            dsjourTable.Columns.Add("Filler", System.Type.GetType("System.String"));
	            dsjourTable.Columns[2].MaxLength = 1;
	            dsjourTable.Columns.Add("Cost", System.Type.GetType("System.String"));
	            dsjourTable.Columns[3].MaxLength = 10;
	            dsjourTable.Columns[3].Caption = "Decimal";
	            dsjourTable.Columns.Add("Price", System.Type.GetType("System.String"));
	            dsjourTable.Columns[4].MaxLength = 10;
	            dsjourTable.Columns[4].Caption = "Decimal";
	            dsjourTable.Columns.Add("Machine", System.Type.GetType("System.String"));
	            dsjourTable.Columns[5].MaxLength = 8;
	            dsjourTable.Columns.Add("Cell", System.Type.GetType("System.String"));
	            dsjourTable.Columns[6].MaxLength = 8;
	            dsjourTable.Columns.Add("Class", System.Type.GetType("System.String"));
	            dsjourTable.Columns[7].MaxLength = 8;
	            dsjourTable.Columns.Add("MTD", System.Type.GetType("System.String"));
	            dsjourTable.Columns[8].MaxLength = 8;
	            dsjourTable.Columns[8].Caption = "Number";
			}
			else if (dsFormat.Equals("10"))
			{
				dsjourTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            dsjourTable.Columns[0].MaxLength = 78;
	            dsjourTable.Columns.Add("Description", System.Type.GetType("System.String"));
	            dsjourTable.Columns[1].MaxLength = 24;
	            dsjourTable.Columns.Add("Filler", System.Type.GetType("System.String"));
	            dsjourTable.Columns[2].MaxLength = 1;
	            dsjourTable.Columns.Add("Cost", System.Type.GetType("System.String"));
	            dsjourTable.Columns[3].MaxLength = 10;
	            dsjourTable.Columns[3].Caption = "Decimal";
	            dsjourTable.Columns.Add("Price", System.Type.GetType("System.String"));
	            dsjourTable.Columns[4].MaxLength = 10;
	            dsjourTable.Columns[4].Caption = "Decimal";
	            dsjourTable.Columns.Add("Machine", System.Type.GetType("System.String"));
	            dsjourTable.Columns[5].MaxLength = 8;
	            dsjourTable.Columns.Add("Cell", System.Type.GetType("System.String"));
	            dsjourTable.Columns[6].MaxLength = 8;
	            dsjourTable.Columns.Add("Class", System.Type.GetType("System.String"));
	            dsjourTable.Columns[7].MaxLength = 8;
	            dsjourTable.Columns.Add("MTD", System.Type.GetType("System.String"));
	            dsjourTable.Columns[8].MaxLength = 8;
	            dsjourTable.Columns[8].Caption = "Number";
			}
			else
			{
				return false;
			}
            
   			return DSPrioritiesIO.LoadFile(customerDatabase + "\\" + DSJOUR_FILENAME, ref dsjourTable);
		}
		
		private bool LoadExport()
		{
			int columnCount = 0;
			
			if (dsFormat.Equals("ORIGINAL"))
			{
				exportTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            exportTable.Columns[0].MaxLength = 20;
	            columnCount++;
			}
			else if (dsFormat.Equals("10"))
			{
				exportTable.Columns.Add("Reference", System.Type.GetType("System.String"));
	            exportTable.Columns[0].MaxLength = 66;
	            columnCount++;
			}
			else
			{
				return false;
			}
			
			exportTable.Columns.Add("MINIMUM_STOCK", System.Type.GetType("System.String"));
        	exportTable.Columns[columnCount].MaxLength = 8;
        	exportTable.Columns[columnCount].Caption = "Number";
        	columnCount++;
            
            for (int i = 0; i < horizon + 1; i++)
            {
            	exportTable.Columns.Add("GRRQMTS_"  + i.ToString(), System.Type.GetType("System.String"));
            	exportTable.Columns[columnCount].MaxLength = 8;
            	exportTable.Columns[columnCount].Caption = "Number";
            	columnCount++;
            }
            
            for (int i = 0; i < horizon + 1; i++)
            {
            	exportTable.Columns.Add("ENDINV_"  + i.ToString(), System.Type.GetType("System.String"));
            	exportTable.Columns[columnCount].MaxLength = 8;
            	exportTable.Columns[columnCount].Caption = "Number";
            	columnCount++;
            }
            
            exportTable.Columns.Add("SCHREC_0", System.Type.GetType("System.String"));
        	exportTable.Columns[columnCount].MaxLength = 8;
        	exportTable.Columns[columnCount].Caption = "Number";
        	columnCount++;
			
			return DSPrioritiesIO.LoadFile(exportDsPrioritiesFileName, ref exportTable);
		}
		
		private bool ProcessData()
		{
			resultTable.Columns.Add("Check", System.Type.GetType("System.Boolean"));
			resultTable.Columns.Add("OF", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Priorité", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Référence", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Description", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Machine", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Quantité", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Semaine", System.Type.GetType("System.String"));
			resultTable.Columns.Add("Date", System.Type.GetType("System.String"));
			
			try
			{
				foreach (DataRow row in receiptsTable.Rows)
				{
					DataRow newRow = resultTable.NewRow();
					DateTime date = DateTime.Now;
					
					if (dsFormat.Equals("ORIGINAL"))
					{
						date = DateTime.ParseExact(row[5].ToString(), "yyMMdd", null);
					}
					else
					{
						date = DateTime.ParseExact(row[5].ToString(), "yyyyMMdd", null);
					}
					
					newRow[0] = true;
					newRow[1] = row[3].ToString();
					newRow[2] = GetPriority(row[0].ToString(), date, Convert.ToInt32(row[1].ToString()));
					newRow[3] = row[0].ToString();
					newRow[4] = GetDescription(row[0].ToString());
					newRow[5] = GetMachine(row[0].ToString());
					newRow[6] = row[1].ToString();
					newRow[7] = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday);
					newRow[8] = date.ToShortDateString();
					
					resultTable.Rows.Add(newRow);
				}
			}
			catch (Exception) {
				
			}
			
			
			return true;
		}
		
		private bool LoadData()
		{
			if (LoadReceipts() && 
			    LoadDsjour() &&
			    LoadExport())
			{
				return ProcessData();
			}
			
			return false;
		}
		
		public bool LoadDsPO()
		{
			int columnCount = 0;
			
			dsPoTable.Columns.Add("Reference", System.Type.GetType("System.String"));
            columnCount++;
            dsPoTable.Columns.Add("ABC", System.Type.GetType("System.String"));
            columnCount++;
	            
            for (int i = 0; i < horizon + 1; i++)
            {
            	dsPoTable.Columns.Add("PO_"  + i.ToString(), System.Type.GetType("System.String"));
            	dsPoTable.Columns[columnCount].Caption = "Number";
            	columnCount++;
            }
        	
			return DSPrioritiesIO.LoadTabFile(exportDsPOFileName, ref dsPoTable);
		}
		
		private string GetDescription(string reference)
		{
			string returnValue = "?";
			
			foreach (DataRow row in dsjourTable.Rows)
			{
				if (row[0].ToString().Equals(reference))
				{
					returnValue = row[1].ToString();
					break;
				}
			}
			
			return returnValue;
		}
		
		private string GetMachine(string reference)
		{
			string returnValue = "?";
			
			foreach (DataRow row in dsjourTable.Rows)
			{
				if (row[0].ToString().Equals(reference))
				{
					returnValue = row[5].ToString();
					break;
				}
			}
			
			return returnValue;
		}
		
		private int GetPriority(string reference, DateTime date, int ofQuantity)
		{
			bool inPast = false;
			
			if (DateTime.Now > date)
			{
				inPast = true;
			}
			
			if (date < DateTime.Now)
			{
				date = DateTime.Now;
			}
			
			if (date.Month == 3 && date.Year == 2009)
			{
				inPast = false;
				
			}
			
			int returnValue = 99;
			bool isFound = false;
			
			int currentWeek = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday);
			int weekNumber = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday) - currentWeek + 1;
			
			//int currentWeek = ((DateTime.Now.DayOfYear / 7) + 2);
			//int weekNumber = ((date.DayOfYear / 7) + 2) - currentWeek + 1;
			
			if (!inPast)
			{
				TimeSpan test = (date - DateTime.Now);
				weekNumber = (test.Days / 7) + 2;
			}
			
			int weekCovered = -1;
			int grRqmts = 0;
			int j = 0;
			int endInvInit = 0;
			int endInv = 0;
			int scheduleReceipt = 0;
			
			foreach (DataRow row in exportTable.Rows)
			{
				if (row[0].ToString().Equals(reference))
				{
					if (reference.Equals("120519-03"))
					{
						grRqmts = 0;
					}
					
					scheduleReceipt = Convert.ToInt32(row[2 + ((horizon + 1) * 2)]);
					
					if ((weekNumber >= 0) && (weekNumber <= horizon))
					{
						endInvInit = Convert.ToInt32(row[2 + weekNumber + horizon]);
						endInvInit -= Convert.ToInt32(row[1]);
						endInv = endInvInit;
						
						if (inPast)
						{
							endInv -= ofQuantity;
							
							if (endInv < 0)
							{
								endInv = 0;
							}
							
							grRqmts += Convert.ToInt32(row[2]);
						}
						else
						{
							grRqmts += Convert.ToInt32(row[2 + weekNumber]);
						}
						
						while ((endInv >= grRqmts) && ((weekNumber + 1 + j) <= horizon))
						{
							grRqmts += Convert.ToInt32(row[2 + weekNumber + 1 + j]);
							weekCovered++;
							j++;
						}
						
						if (weekCovered == -1)
						{
							j = horizon;
							
							while ((endInv < 0) && (j >= 0))
							{
								endInv = Convert.ToInt32(row[2 + weekNumber - 1 + j]);
								endInv -= Convert.ToInt32(row[1]);
								weekCovered--;
								j--;
							}
						}
						
						if (weekCovered > 1)
						{
							weekCovered--;
						}
					}
					
					if ((grRqmts == 0) && (j != 0))
					{
						for(int i = 0; i < horizon; i++)
						{
							grRqmts += Convert.ToInt32(row[2 + i]);
						}
					}
					
					isFound = true;
					break;
				}
			}
			
			if (isFound)
			{
				if (((grRqmts == 0) && (j != 0)) || ((weekCovered + weekNumber + 1) == horizon))
				{
					returnValue = 98;
				}
				else
				{
					if (weekCovered < 0)
					{
						returnValue = currentWeek + weekNumber + weekCovered;
					}
					else if ((weekCovered > -1) && (weekCovered <= horizon))
					{
						returnValue = currentWeek + weekNumber + weekCovered;
					}
					
					if (returnValue < currentWeek)
					{
						returnValue = currentWeek - 1;
					}
					
					if (inPast && (endInvInit < scheduleReceipt))
					{
						returnValue = currentWeek - 1;
					}
					
					returnValue = returnValue - 1;
					
					returnValue = (returnValue % 52);
					
					if (returnValue == 0)
					{
						returnValue = 52;
					}
				}
			}
			
			return returnValue;
		}
		
		void BtnValidateClick(object sender, EventArgs e)
		{
			if (SaveDsPriorities())
			{
				this.Close();
			}
		}
		
		private bool SaveDsPriorities()
		{
			System.Data.DataTable dataTable = new System.Data.DataTable();
			
			dataTable.Columns.Add("OF", System.Type.GetType("System.String"));
			dataTable.Columns[0].MaxLength = 7;
			dataTable.Columns.Add("Priorité", System.Type.GetType("System.String"));
			dataTable.Columns[1].MaxLength = 2;
			
			foreach(DataGridViewRow row in dgvReceipts.Rows)
	        {
				if (Convert.ToBoolean(row.Cells[0].Value))
				{
		        	DataRow newRow = dataTable.NewRow();
		        	
		        	newRow[0] = row.Cells[1].Value.ToString().PadLeft(7, '0');
		        	newRow[1] = row.Cells[2].Value.ToString().PadLeft(2, '0');
					
		        	dataTable.Rows.Add(newRow);
				}
			}
			
			return DSPrioritiesIO.WriteFile(dsPrioritiesFolder + "\\" + PRIORITIES_RESULT_FILENAME, dataTable);
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnSelectClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvReceipts.Rows)
			{
				if (row.Selected)
				{
					row.Cells[0].Value = !((bool)row.Cells[0].Value);
				}
			}
		}
		
		void BtnSelectAllClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvReceipts.Rows)
			{
				row.Cells[0].Value = !((bool)row.Cells[0].Value);
			}
		}
		
		void BtnExportClick(object sender, EventArgs e)
		{
			System.Data.DataTable dataTable = new System.Data.DataTable();
			
			dataTable.Columns.Add("OF", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Priorité", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Référence", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Description", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Machine", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Quantité", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Semaine", System.Type.GetType("System.String"));
			dataTable.Columns.Add("Date", System.Type.GetType("System.String"));
			
			foreach(DataGridViewRow row in dgvReceipts.Rows)
	        {
				if (Convert.ToBoolean(row.Cells[0].Value))
				{
		        	DataRow newRow = dataTable.NewRow();
		        	
		        	for (int i = 0; i < 8; i++)
		        	{
		        		newRow[i] = row.Cells[i + 1].Value;
		        	}
					
		        	dataTable.Rows.Add(newRow);
				}
			}
			
			ExportToExcel(dataTable);
		}
		
		private void ExportToExcel(System.Data.DataTable dataTable)
		{
	        Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = (Workbook)application.Workbooks.Add(Missing.Value);
            Worksheet worksheet = (Worksheet)application.ActiveSheet;
           	worksheet.Cells.NumberFormat = "@";
		    
            
            if (dataTable != null)
	        {
		        for (int i = 0; i < dataTable.Columns.Count; i++)
		        {
		        	worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
		        }
		        
		        for (int i = 0; i < dataTable.Rows.Count; i++)
		        {
		        	for (int j = 0; j < dataTable.Columns.Count; j++)
		        	{
		        		worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
		        	}
		        }
	        }
	        
	        application.Visible = true;
		}
		
		
		public bool SaveDsPO() {
			
			System.Data.DataTable dataTable = new System.Data.DataTable();
			
			dataTable.Columns.Add("Article", System.Type.GetType("System.String"));
			dataTable.Columns[0].MaxLength = 17;
			dataTable.Columns.Add("Quantite", System.Type.GetType("System.String"));
			dataTable.Columns[1].MaxLength = 8;
			dataTable.Columns.Add("Date", System.Type.GetType("System.String"));
			dataTable.Columns[2].MaxLength = 8;
			dataTable.Columns.Add("Code_ABC", System.Type.GetType("System.String"));
			dataTable.Columns[3].MaxLength = 1;
			
			
			foreach(DataRow row in dsPoTable.Rows)
	        {
				int dayCount = 0;
				
				if (DateTime.Now.DayOfWeek == 0)
				{
					dayCount = 6;
				}
				else
				{
					dayCount = ((int)DateTime.Now.DayOfWeek) - 1;
				}
				
				dayCount = -dayCount;
				
				
				DateTime date = DateTime.Now.AddDays(dayCount);
				
				for (int i = 0; i < horizon + 1; i++)
            	{
					if ((Convert.ToInt32(row[2 + i])) > 0)
					{
						DataRow newRow = dataTable.NewRow();
						
						newRow[0] = row[0].ToString();
						newRow[1] = row[2 + i].ToString().PadLeft(8, '0');
						newRow[2] = date.AddDays(-7).ToString("ddMMyyyy");
						newRow[3] = row[1].ToString();
						
						dataTable.Rows.Add(newRow);
					}
					
					date = date.AddDays(7);
				}
			}
			
			return DSPrioritiesIO.WriteFile(dsPOFolder + "\\" + PO_RESULT_FILENAME, dataTable);
		}
	}
}

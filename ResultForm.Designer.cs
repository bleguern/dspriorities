/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 06/04/2007
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DS_Priorities
{
	partial class ResultForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbxReceipts = new System.Windows.Forms.GroupBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.dgvReceipts = new System.Windows.Forms.DataGridView();
			this.btnValidate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.dcbValidate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dtbReceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbxReceipts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxReceipts
			// 
			this.gbxReceipts.Controls.Add(this.btnExport);
			this.gbxReceipts.Controls.Add(this.btnSelect);
			this.gbxReceipts.Controls.Add(this.lblMessage);
			this.gbxReceipts.Controls.Add(this.btnSelectAll);
			this.gbxReceipts.Controls.Add(this.dgvReceipts);
			this.gbxReceipts.Location = new System.Drawing.Point(12, 39);
			this.gbxReceipts.Name = "gbxReceipts";
			this.gbxReceipts.Size = new System.Drawing.Size(870, 403);
			this.gbxReceipts.TabIndex = 0;
			this.gbxReceipts.TabStop = false;
			this.gbxReceipts.Text = "Liste des OFs";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(761, 374);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(103, 23);
			this.btnExport.TabIndex = 4;
			this.btnExport.Text = "Exporter";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(6, 374);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(102, 23);
			this.btnSelect.TabIndex = 3;
			this.btnSelect.Text = "Sélectionner";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
			// 
			// lblMessage
			// 
			this.lblMessage.Location = new System.Drawing.Point(223, 374);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(476, 19);
			this.lblMessage.TabIndex = 2;
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Location = new System.Drawing.Point(114, 374);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(103, 23);
			this.btnSelectAll.TabIndex = 1;
			this.btnSelectAll.Text = "Sélectionner tout";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAllClick);
			// 
			// dgvReceipts
			// 
			this.dgvReceipts.AllowUserToAddRows = false;
			this.dgvReceipts.AllowUserToDeleteRows = false;
			this.dgvReceipts.AllowUserToResizeRows = false;
			this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dcbValidate,
									this.dtbReceipt,
									this.dtbPriority,
									this.dtbReference,
									this.dtbDescription,
									this.dtbMachine,
									this.dtbQuantity,
									this.dtbWeek,
									this.dtbDate});
			this.dgvReceipts.Location = new System.Drawing.Point(6, 19);
			this.dgvReceipts.Name = "dgvReceipts";
			this.dgvReceipts.RowHeadersVisible = false;
			this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReceipts.Size = new System.Drawing.Size(858, 349);
			this.dgvReceipts.TabIndex = 0;
			// 
			// btnValidate
			// 
			this.btnValidate.Location = new System.Drawing.Point(726, 452);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(75, 23);
			this.btnValidate.TabIndex = 1;
			this.btnValidate.Text = "Valider";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.BtnValidateClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(807, 452);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(12, 13);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(339, 23);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "Date du jour :";
			// 
			// dcbValidate
			// 
			this.dcbValidate.HeaderText = "";
			this.dcbValidate.Name = "dcbValidate";
			this.dcbValidate.Width = 25;
			// 
			// dtbReceipt
			// 
			this.dtbReceipt.HeaderText = "OF";
			this.dtbReceipt.Name = "dtbReceipt";
			this.dtbReceipt.ReadOnly = true;
			// 
			// dtbPriority
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtbPriority.DefaultCellStyle = dataGridViewCellStyle1;
			this.dtbPriority.HeaderText = "Priorité";
			this.dtbPriority.Name = "dtbPriority";
			// 
			// dtbReference
			// 
			this.dtbReference.HeaderText = "Référence";
			this.dtbReference.Name = "dtbReference";
			this.dtbReference.ReadOnly = true;
			this.dtbReference.Width = 120;
			// 
			// dtbDescription
			// 
			this.dtbDescription.HeaderText = "Description";
			this.dtbDescription.Name = "dtbDescription";
			this.dtbDescription.ReadOnly = true;
			this.dtbDescription.Width = 150;
			// 
			// dtbMachine
			// 
			this.dtbMachine.HeaderText = "Machine";
			this.dtbMachine.Name = "dtbMachine";
			this.dtbMachine.ReadOnly = true;
			// 
			// dtbQuantity
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dtbQuantity.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtbQuantity.HeaderText = "Quantité";
			this.dtbQuantity.Name = "dtbQuantity";
			this.dtbQuantity.ReadOnly = true;
			this.dtbQuantity.Width = 80;
			// 
			// dtbWeek
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dtbWeek.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtbWeek.HeaderText = "Semaine";
			this.dtbWeek.Name = "dtbWeek";
			this.dtbWeek.ReadOnly = true;
			// 
			// dtbDate
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dtbDate.DefaultCellStyle = dataGridViewCellStyle4;
			this.dtbDate.HeaderText = "Date";
			this.dtbDate.Name = "dtbDate";
			this.dtbDate.ReadOnly = true;
			this.dtbDate.Width = 80;
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 487);
			this.ControlBox = false;
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.gbxReceipts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResultForm";
			this.Text = "Liste des ordres de fabrication";
			this.gbxReceipts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbWeek;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbMachine;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnValidate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbReference;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbReceipt;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dcbValidate;
		private System.Windows.Forms.DataGridView dgvReceipts;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.GroupBox gbxReceipts;
	}
}

namespace HowToEditAndSavePivotCellValues
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule2 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings2 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNeedVerification = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSales,
            this.fieldOrderDate,
            this.fieldYear,
            this.fieldMonth,
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldNeedVerification});
            pivotGridFormatRule2.Name = "Format0";
            pivotGridFormatRule2.Rule = null;
            pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings2;
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2);
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCalcEdit1});
            this.pivotGridControl1.Size = new System.Drawing.Size(798, 418);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldSales
            // 
            this.fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSales.AreaIndex = 0;
            this.fieldSales.Caption = "Product Sales";
            this.fieldSales.FieldName = "ExtendedPrice";
            this.fieldSales.Name = "fieldSales";
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "OrderDate";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 1;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "OrderDate";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldNeedVerification
            // 
            this.fieldNeedVerification.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNeedVerification.AreaIndex = 1;
            this.fieldNeedVerification.Caption = "Need Verification";
            this.fieldNeedVerification.FieldEdit = this.repositoryItemCheckEdit1;
            this.fieldNeedVerification.FieldName = "NeedVerification";
            this.fieldNeedVerification.Name = "fieldNeedVerification";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 418);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Cell Edit Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNeedVerification;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}


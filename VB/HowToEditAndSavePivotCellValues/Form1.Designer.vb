Namespace HowToEditAndSavePivotCellValues
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim pivotGridFormatRule2 As New DevExpress.XtraPivotGrid.PivotGridFormatRule()
			Dim formatRuleTotalTypeSettings2 As New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldNeedVerification = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldSales, Me.fieldOrderDate, Me.fieldYear, Me.fieldMonth, Me.fieldCategoryName, Me.fieldProductName, Me.fieldNeedVerification})
			pivotGridFormatRule2.Name = "Format0"
			pivotGridFormatRule2.Rule = Nothing
			pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings2
			Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2)
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1, Me.repositoryItemCalcEdit1})
			Me.pivotGridControl1.Size = New System.Drawing.Size(798, 418)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldSales
			' 
			Me.fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldSales.AreaIndex = 0
			Me.fieldSales.Caption = "Product Sales"
			Me.fieldSales.FieldName = "ExtendedPrice"
			Me.fieldSales.Name = "fieldSales"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "OrderDate"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' fieldMonth
			' 
			Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldMonth.AreaIndex = 1
			Me.fieldMonth.Caption = "Month"
			Me.fieldMonth.FieldName = "OrderDate"
			Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldMonth.Name = "fieldMonth"
			Me.fieldMonth.UnboundFieldName = "fieldMonth"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldNeedVerification
			' 
			Me.fieldNeedVerification.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldNeedVerification.AreaIndex = 1
			Me.fieldNeedVerification.Caption = "Need Verification"
			Me.fieldNeedVerification.FieldEdit = Me.repositoryItemCheckEdit1
			Me.fieldNeedVerification.FieldName = "NeedVerification"
			Me.fieldNeedVerification.Name = "fieldNeedVerification"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(798, 418)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Cell Edit Example"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldSales As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldNeedVerification As DevExpress.XtraPivotGrid.PivotGridField
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
	End Class
End Namespace


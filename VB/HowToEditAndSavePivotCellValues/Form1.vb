Imports System.Collections.ObjectModel
Imports DevExpress.XtraPivotGrid

Namespace HowToEditAndSavePivotCellValues
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Property OrderSourceList() As Collection(Of MyOrderRow)
		Public Sub New()
			InitializeComponent()

			AddHandler pivotGridControl1.CustomCellValue, AddressOf PivotGridControl1_CustomCellValue
			AddHandler pivotGridControl1.EditValueChanged, AddressOf PivotGridControl1_EditValueChanged
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			OrderSourceList = DatabaseHelper.CreateData()
			pivotGridControl1.DataSource = OrderSourceList
			pivotGridControl1.BestFit()
		End Sub

		Private Sub PivotGridControl1_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.EditValueChangedEventArgs)
			ChangeCellValue(e, Convert.ToBoolean(e.Value), Convert.ToBoolean(e.Editor.EditValue))
		End Sub

		Private Sub ChangeCellValue(ByVal e As EditValueChangedEventArgs, ByVal oldValue As Boolean, ByVal newValue As Boolean)
			Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
			For i As Integer = 0 To ds.RowCount - 1
				ds.SetValue(i, e.DataField, newValue)
			Next i
		End Sub

		Private Sub PivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs)
			If e.DataField.Name = "fieldNeedVerification" AndAlso e.Value IsNot Nothing Then
				e.Value = If(Convert.ToInt32(e.Value) > 0, True, False)
			End If
		End Sub

	End Class
End Namespace

# How to Edit and Save Cell Values

This example demonstrates how to edit cells with the [in-line cell editor](https://docs.devexpress.com/WindowsForms/9388) and save the changes to the [underlying data](https://docs.devexpress.com/WindowsForms/1882).

The _Need Verification_ field is displayed with a [CheckEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CheckEdit) repository editor. The editor gets a value for display from the [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event handler. When editing finishes, the [PivotGridControl.EditValueChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.EditValueChanged) event handler calls the [e.CreateDrillDownDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.CreateDrillDownDataSource.overloads) method to retrieve the underlying records and updates them.



![screenshot](/images/screenshot.png)
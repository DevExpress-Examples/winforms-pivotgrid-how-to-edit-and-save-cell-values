<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828658)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Pivot Grid for WinForms - Edit Pivot Grid Cells in the UI and Store Cell Values in the Underlying Data Source 

This example demonstrates how to edit cells with the [in-line cell editor](https://docs.devexpress.com/WindowsForms/9388) and save the changes to the [underlying data](https://docs.devexpress.com/WindowsForms/1882).

![screenshot](/images/screenshot.png)

The _Need Verification_ field is displayed with a [CheckEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.CheckEdit) repository editor. The editor gets a value for display from the [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event handler. When editing finishes, the [PivotGridControl.EditValueChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.EditValueChanged) event handler calls the [e.CreateDrillDownDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.CreateDrillDownDataSource.overloads) method to retrieve the underlying records and updates them.

## Files to Review

* [Form1.cs](./CS/HowToEditAndSavePivotCellValues/Form1.cs) (VB: [Form1.vb](./VB/HowToEditAndSavePivotCellValues/Form1.vb))

## Documentation

[Assigning Editors for In-place Editing](https://docs.devexpress.com/WindowsForms/5896/controls-and-libraries/pivot-grid/data-shaping/editing/assigning-editors-for-in-place-editing)

## More Examples

- [Pivot Grid for WinForms - Override the Cell Editor](https://github.com/DevExpress-Examples/how-to-override-the-cell-editor-used-for-the-in-place-editing-t515806)
- [Pivot Grid for WinForms - Assign In-Place Editors to Different Types of Cells](https://github.com/DevExpress-Examples/winforms-pivotgrid-assign-in-place-editors-to-different-types-of-cells)


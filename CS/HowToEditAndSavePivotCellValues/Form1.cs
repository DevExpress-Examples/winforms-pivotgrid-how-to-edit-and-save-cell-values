using DevExpress.XtraPivotGrid;
using System;
using System.Collections.ObjectModel;

namespace HowToEditAndSavePivotCellValues
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Collection<MyOrderRow> OrderSourceList { get; set; }
        public Form1()
        {
            InitializeComponent();

            pivotGridControl1.CustomCellValue += PivotGridControl1_CustomCellValue;
            pivotGridControl1.EditValueChanged += PivotGridControl1_EditValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderSourceList = DatabaseHelper.CreateData();
            pivotGridControl1.DataSource = OrderSourceList;
            pivotGridControl1.BestFit();
        }

        private void PivotGridControl1_EditValueChanged(object sender, DevExpress.XtraPivotGrid.EditValueChangedEventArgs e)
        {
            ChangeCellValue(e, Convert.ToBoolean(e.Value), Convert.ToBoolean(e.Editor.EditValue));
        }

        private void ChangeCellValue(EditValueChangedEventArgs e, bool oldValue, bool newValue)
        {
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            for (int i = 0; i < ds.RowCount; i++)
            {
                ds.SetValue(i, e.DataField, newValue);
            }
        }

        private void PivotGridControl1_CustomCellValue(object sender, DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            if (e.DataField.Name == "fieldNeedVerification" && e.Value != null) {
                e.Value = (Convert.ToInt32(e.Value) > 0) ? true : false;
            }
        }

    }
}

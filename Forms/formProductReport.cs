using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

using App.Database;

namespace InventorySystem.Forms
{
    public partial class formProductReport : Form
    {
        public formProductReport()
        {
            InitializeComponent();

            reportProduct.SetDisplayMode(DisplayMode.PrintLayout);
            reportProduct.ZoomPercent = 100;
            reportProduct.ZoomMode = ZoomMode.Percent;
        }

        private void formProductReport_Load(object sender, EventArgs e)
        {
            reportProduct.LocalReport.DataSources.Clear();
            reportProduct.LocalReport.DataSources.Add(new ReportDataSource("Product", DatabaseManager.GetDataSet($"SELECT * FROM tbl_products", "product").Tables[0]));
            reportProduct.LocalReport.ReportPath = $"{Application.StartupPath}/Forms/Report/SalesReport.rdlc";
            reportProduct.RefreshReport();
        }
    }
}

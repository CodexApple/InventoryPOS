using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;
using App.Objects;

namespace InventorySystem.Forms
{
    public partial class ReportsDash : UserControl
    {

        string config = default;
        string gridConfig = default;
        int id = default;

        public ReportsDash()
        {
            InitializeComponent();
        }

        private void addAP_Click(object sender, EventArgs e)
        {

            config = "AddAP";
            formARAP form = new formARAP(config);
            form.ShowDialog();
            LoadGrid("AP");
            form.Dispose();

        }

        private void addAR_Click(object sender, EventArgs e)
        {
            config = "AddAR";
            formARAP form = new formARAP(config);
            form.ShowDialog();
            LoadGrid("AR");
            form.Dispose();
        }

        private void editAP_Click(object sender, EventArgs e)
        {
            config = "EditAP";
            formARAP form = new formARAP(config, this.id);
            form.ShowDialog();
            LoadGrid("AP");
            form.Dispose();
        }

        private void editAR_Click(object sender, EventArgs e)
        {
            config = "EditAR";
            formARAP form = new formARAP(config, this.id);
            form.ShowDialog();
            LoadGrid("AR");
            form.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addAR.Enabled = false;
            editAR.Enabled = false;
            addAP.Enabled = true;
            editAP.Enabled = true;

            gridConfig = "AP";

            LoadGrid(gridConfig);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addAR.Enabled = true;
            editAR.Enabled = true;
            addAP.Enabled = false;
            editAP.Enabled = false;

            gridConfig = "AR";

            LoadGrid(gridConfig);
        }

        public void LoadGrid(string gridConfig)
        {

            dataGridView1.DataSource = null;

            if (gridConfig == "AP") {

                var something = PayableModel.GetAllRecords();
                var bindingList = new BindingList<Payables>(something);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

            }
            else {

                var something = ReceivableModel.GetAllRecords();
                var bindingList = new BindingList<Receivables>(something);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

            }
                
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             this.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Controllers;
using App.Models;
using App.Objects;

namespace InventorySystem.Forms
{
    public partial class formARAP : Form
    {
        string config = default;
        int id = default;

        DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        public formARAP(string config, int id = default)
        {
            InitializeComponent();
            this.config = config.Trim();
            this.id = id;

            if (config.Equals("AddAP")) 
            {
                long StartDate = now.ToUnixTimeSeconds();
                long EndDate = StartDate + (86400 * 30);

                nameLabel.Text = "Vendor Name:";

                arapTransNumberTextBox.Text = Convert.ToString(PayableModel.GetMaxID());

                dateTextbox.Text = DateTimeController.UnixSecondsToDateTime(StartDate);
                dueDateTextBox.Text = DateTimeController.UnixSecondsToDateTime(EndDate);

            }
            else if (config.Equals("EditAP"))
            {
                nameLabel.Text = "Vendor Name:";

                Payables account = PayableModel.GetById(this.id);

                arapTransNumberTextBox.Text = Convert.ToString(account.transaction_number);
                nameTextBox.Text = account.vendor_name;
                amountTextBox.Text = Convert.ToString(account.amount);
                dateTextbox.Text = DateTimeController.UnixSecondsToDateTime(account.date);
                dueDateTextBox.Text = DateTimeController.UnixSecondsToDateTime(account.due_date);

            }
            else if (config.Equals("AddAR"))
            {
                long StartDate = now.ToUnixTimeSeconds();
                long EndDate = StartDate + (86400 * 30);

                nameLabel.Text = "Customer Name:";

                arapTransNumberTextBox.Text = Convert.ToString(ReceivableModel.GetMaxID());

                dateTextbox.Text = DateTimeController.UnixSecondsToDateTime(StartDate);
                dueDateTextBox.Text = DateTimeController.UnixSecondsToDateTime(EndDate);
            }
            else if (config.Equals("EditAR"))
            {
                nameLabel.Text = "Customer Name:";

                Receivables account = ReceivableModel.GetById(this.id);

                arapTransNumberTextBox.Text = Convert.ToString(account.transaction_number);
                nameTextBox.Text = account.customer_name;
                amountTextBox.Text = Convert.ToString(account.amount);
                dateTextbox.Text = DateTimeController.UnixSecondsToDateTime(account.date);
                dueDateTextBox.Text = DateTimeController.UnixSecondsToDateTime(account.due_date);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payables payable = new Payables();
            Receivables receive = new Receivables();

            if (config.Equals("AddAP"))
            {
                //Do insert to tbl_ap

                long StartDate = now.ToUnixTimeSeconds();
                long EndDate = StartDate + (86400 * 30);

                payable.vendor_name = nameTextBox.Text;
                payable.amount = Convert.ToDecimal(amountTextBox.Text);
                payable.date = DateTimeController.DateTimeToUnixSeconds(DateTimeController.ToDateTimeUnix(StartDate));
                payable.due_date = DateTimeController.DateTimeToUnixSeconds(DateTimeController.ToDateTimeUnix(EndDate));

                PayableModel.SaveData(payable);

                MessageBox.Show("Accounts Payable saved successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (config.Equals("EditAP"))
            {
                //Do update to tbl_ap
                payable.vendor_name = nameTextBox.Text;
                payable.amount = Convert.ToDecimal(amountTextBox.Text);
                payable.date = DateTimeController.FromDateToUnix(dateTextbox.Text);
                payable.due_date = DateTimeController.FromDateToUnix(dueDateTextBox.Text);

                PayableModel.UpdateData(this.id, payable);

                MessageBox.Show("Accounts Payable updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (config.Equals("AddAR"))
            {
                //Do insert to tbl_ar

                long StartDate = now.ToUnixTimeSeconds();
                long EndDate = StartDate + (86400 * 30);

                receive.customer_name = nameTextBox.Text;
                receive.amount = Convert.ToDecimal(amountTextBox.Text);
                receive.date = DateTimeController.DateTimeToUnixSeconds(DateTimeController.ToDateTimeUnix(StartDate));
                receive.due_date = DateTimeController.DateTimeToUnixSeconds(DateTimeController.ToDateTimeUnix(EndDate));

                ReceivableModel.SaveData(receive);

                MessageBox.Show("Accounts Receivable saved successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (config.Equals("EditAR")) 
            {
                //Do update to tbl_ar
                receive.customer_name = nameTextBox.Text;
                receive.amount = Convert.ToDecimal(amountTextBox.Text);
                receive.date = DateTimeController.FromDateToUnix(dateTextbox.Text);
                receive.due_date = DateTimeController.FromDateToUnix(dueDateTextBox.Text);

                ReceivableModel.UpdateData(this.id, receive);

                MessageBox.Show("Account Receivable updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

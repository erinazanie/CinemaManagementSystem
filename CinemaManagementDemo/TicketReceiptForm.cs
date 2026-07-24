using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
    public partial class TicketReceiptForm : Form
    {
        public TicketReceiptForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Receipt saved successfully!",
                "Print Receipt"
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

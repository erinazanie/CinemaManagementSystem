using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
	partial class SnackSelectionForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			panelHeader = new Panel();
			btnBack = new Button();
			lblTitleHeader = new Label();
			flpSnackList = new FlowLayoutPanel();
			pnlSummary = new Panel();
			lblGrandTotal = new Label();
			btnCheckout = new Button();
			lstSummary = new ListBox();
			lblSeatsVal = new Label();
			lblTimeVal = new Label();
			lblMovieVal = new Label();
			lblOrderSummaryHeader = new Label();
			pnlCustomer = new Panel();
			txtEmail = new TextBox();
			txtName = new TextBox();
			lblEmail = new Label();
			lblName = new Label();
			lblCustomerHeader = new Label();
			panelHeader.SuspendLayout();
			pnlSummary.SuspendLayout();
			pnlCustomer.SuspendLayout();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.FromArgb(45, 40, 62);
			panelHeader.Controls.Add(btnBack);
			panelHeader.Controls.Add(lblTitleHeader);
			panelHeader.Dock = DockStyle.Top;
			panelHeader.Location = new Point(0, 0);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(882, 50);
			panelHeader.TabIndex = 0;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.FromArgb(60, 54, 80);
			btnBack.FlatStyle = FlatStyle.Flat;
			btnBack.ForeColor = Color.White;
			btnBack.Location = new Point(12, 9);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 1;
			btnBack.Text = "← Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// lblTitleHeader
			// 
			lblTitleHeader.AutoSize = true;
			lblTitleHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitleHeader.ForeColor = Color.FromArgb(162, 89, 255);
			lblTitleHeader.Location = new Point(300, 13);
			lblTitleHeader.Name = "lblTitleHeader";
			lblTitleHeader.Size = new Size(300, 25);
			lblTitleHeader.TabIndex = 0;
			lblTitleHeader.Text = "🍿 SNACK & BEVERAGE SELECTION";
			// 
			// flpSnackList
			// 
			flpSnackList.AutoScroll = true;
			flpSnackList.BackColor = Color.FromArgb(24, 21, 36);
			flpSnackList.BorderStyle = BorderStyle.FixedSingle;
			flpSnackList.FlowDirection = FlowDirection.TopDown;
			flpSnackList.Location = new Point(30, 70);
			flpSnackList.Name = "flpSnackList";
			flpSnackList.Padding = new Padding(10);
			flpSnackList.Size = new Size(465, 330);
			flpSnackList.TabIndex = 1;
			flpSnackList.WrapContents = false;
			// 
			// pnlSummary
			// 
			pnlSummary.BackColor = Color.FromArgb(38, 33, 54);
			pnlSummary.BorderStyle = BorderStyle.FixedSingle;
			pnlSummary.Controls.Add(lblGrandTotal);
			pnlSummary.Controls.Add(btnCheckout);
			pnlSummary.Controls.Add(lstSummary);
			pnlSummary.Controls.Add(lblSeatsVal);
			pnlSummary.Controls.Add(lblTimeVal);
			pnlSummary.Controls.Add(lblMovieVal);
			pnlSummary.Controls.Add(lblOrderSummaryHeader);
			pnlSummary.Location = new Point(515, 70);
			pnlSummary.Name = "pnlSummary";
			pnlSummary.Size = new Size(335, 455);
			pnlSummary.TabIndex = 2;
			// 
			// lblGrandTotal
			// 
			lblGrandTotal.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGrandTotal.ForeColor = Color.FromArgb(162, 89, 255);
			lblGrandTotal.Location = new Point(15, 345);
			lblGrandTotal.Name = "lblGrandTotal";
			lblGrandTotal.Size = new Size(305, 35);
			lblGrandTotal.TabIndex = 6;
			lblGrandTotal.Text = "Total: RM 0.00";
			lblGrandTotal.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnCheckout
			// 
			btnCheckout.BackColor = Color.FromArgb(162, 89, 255);
			btnCheckout.FlatAppearance.BorderSize = 0;
			btnCheckout.FlatStyle = FlatStyle.Flat;
			btnCheckout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCheckout.ForeColor = Color.White;
			btnCheckout.Location = new Point(15, 390);
			btnCheckout.Name = "btnCheckout";
			btnCheckout.Size = new Size(305, 48);
			btnCheckout.TabIndex = 5;
			btnCheckout.Text = "Checkout ➔";
			btnCheckout.UseVisualStyleBackColor = false;
			btnCheckout.Click += btnCheckout_Click;
			// 
			// lstSummary
			// 
			lstSummary.BackColor = Color.FromArgb(28, 24, 42);
			lstSummary.BorderStyle = BorderStyle.FixedSingle;
			lstSummary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstSummary.ForeColor = Color.LightGray;
			lstSummary.FormattingEnabled = true;
			lstSummary.HorizontalScrollbar = true;
			lstSummary.ItemHeight = 20;
			lstSummary.Location = new Point(15, 125);
			lstSummary.Name = "lstSummary";
			lstSummary.Size = new Size(305, 202);
			lstSummary.TabIndex = 4;
			// 
			// lblSeatsVal
			// 
			lblSeatsVal.AutoSize = true;
			lblSeatsVal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSeatsVal.ForeColor = Color.LightGray;
			lblSeatsVal.Location = new Point(15, 95);
			lblSeatsVal.Name = "lblSeatsVal";
			lblSeatsVal.Size = new Size(72, 20);
			lblSeatsVal.TabIndex = 3;
			lblSeatsVal.Text = "Seats: C2";
			// 
			// lblTimeVal
			// 
			lblTimeVal.AutoSize = true;
			lblTimeVal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTimeVal.ForeColor = Color.LightGray;
			lblTimeVal.Location = new Point(15, 72);
			lblTimeVal.Name = "lblTimeVal";
			lblTimeVal.Size = new Size(111, 20);
			lblTimeVal.TabIndex = 2;
			lblTimeVal.Text = "Time: 12:30 PM";
			// 
			// lblMovieVal
			// 
			lblMovieVal.AutoSize = true;
			lblMovieVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMovieVal.ForeColor = Color.White;
			lblMovieVal.Location = new Point(15, 45);
			lblMovieVal.Name = "lblMovieVal";
			lblMovieVal.Size = new Size(177, 23);
			lblMovieVal.TabIndex = 1;
			lblMovieVal.Text = "Papa Zola The Movie";
			// 
			// lblOrderSummaryHeader
			// 
			lblOrderSummaryHeader.AutoSize = true;
			lblOrderSummaryHeader.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblOrderSummaryHeader.ForeColor = Color.White;
			lblOrderSummaryHeader.Location = new Point(15, 12);
			lblOrderSummaryHeader.Name = "lblOrderSummaryHeader";
			lblOrderSummaryHeader.Size = new Size(160, 28);
			lblOrderSummaryHeader.TabIndex = 0;
			lblOrderSummaryHeader.Text = "Order Summary";
			// 
			// pnlCustomer
			// 
			pnlCustomer.BackColor = Color.FromArgb(38, 33, 54);
			pnlCustomer.BorderStyle = BorderStyle.FixedSingle;
			pnlCustomer.Controls.Add(txtEmail);
			pnlCustomer.Controls.Add(txtName);
			pnlCustomer.Controls.Add(lblEmail);
			pnlCustomer.Controls.Add(lblName);
			pnlCustomer.Controls.Add(lblCustomerHeader);
			pnlCustomer.Location = new Point(30, 415);
			pnlCustomer.Name = "pnlCustomer";
			pnlCustomer.Size = new Size(465, 110);
			pnlCustomer.TabIndex = 3;
			// 
			// txtEmail
			// 
			txtEmail.BackColor = Color.FromArgb(28, 24, 42);
			txtEmail.BorderStyle = BorderStyle.FixedSingle;
			txtEmail.ForeColor = Color.White;
			txtEmail.Location = new Point(80, 70);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(365, 27);
			txtEmail.TabIndex = 4;
			// 
			// txtName
			// 
			txtName.BackColor = Color.FromArgb(28, 24, 42);
			txtName.BorderStyle = BorderStyle.FixedSingle;
			txtName.ForeColor = Color.White;
			txtName.Location = new Point(80, 37);
			txtName.Name = "txtName";
			txtName.Size = new Size(365, 27);
			txtName.TabIndex = 3;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblEmail.ForeColor = Color.LightGray;
			lblEmail.Location = new Point(15, 73);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(51, 20);
			lblEmail.TabIndex = 2;
			lblEmail.Text = "Email:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblName.ForeColor = Color.LightGray;
			lblName.Location = new Point(15, 40);
			lblName.Name = "lblName";
			lblName.Size = new Size(55, 20);
			lblName.TabIndex = 1;
			lblName.Text = "Name:";
			// 
			// lblCustomerHeader
			// 
			lblCustomerHeader.AutoSize = true;
			lblCustomerHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCustomerHeader.ForeColor = Color.White;
			lblCustomerHeader.Location = new Point(12, 10);
			lblCustomerHeader.Name = "lblCustomerHeader";
			lblCustomerHeader.Size = new Size(144, 23);
			lblCustomerHeader.TabIndex = 0;
			lblCustomerHeader.Text = "Customer Details";
			// 
			// SnackSelectionForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(30, 27, 46);
			ClientSize = new Size(882, 553);
			Controls.Add(pnlCustomer);
			Controls.Add(pnlSummary);
			Controls.Add(flpSnackList);
			Controls.Add(panelHeader);
			Name = "SnackSelectionForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Snack & Beverage Selection";
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			pnlSummary.ResumeLayout(false);
			pnlSummary.PerformLayout();
			pnlCustomer.ResumeLayout(false);
			pnlCustomer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelHeader;
		private Button btnBack;
		private Label lblTitleHeader;
		private FlowLayoutPanel flpSnackList;
		private Panel pnlSummary;
		private Label lblOrderSummaryHeader;
		private Label lblMovieVal;
		private Label lblTimeVal;
		private Label lblSeatsVal;
		private ListBox lstSummary;
		private Label lblGrandTotal;
		private Button btnCheckout;
		private Panel pnlCustomer;
		private Label lblCustomerHeader;
		private Label lblName;
		private Label lblEmail;
		private TextBox txtName;
		private TextBox txtEmail;
	}
}
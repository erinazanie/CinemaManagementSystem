using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
	partial class TicketReceiptForm
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
			lblMovie = new Label();
			lblDate = new Label();
			lblTime = new Label();
			lblHall = new Label();
			lblSeats = new Label();
			lblSnackHeader = new Label();
			pnlSnacksContainer = new FlowLayoutPanel();
			lblTotalHeader = new Label();
			lblTotal = new Label();
			btnPrint = new Button();
			panelHeader.SuspendLayout();
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
			lblTitleHeader.Location = new Point(325, 13);
			lblTitleHeader.Name = "lblTitleHeader";
			lblTitleHeader.Size = new Size(227, 25);
			lblTitleHeader.TabIndex = 0;
			lblTitleHeader.Text = "🎬 STARLIGHT CINEMAS";
			// 
			// lblMovie
			// 
			lblMovie.AutoSize = true;
			lblMovie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblMovie.ForeColor = Color.White;
			lblMovie.Location = new Point(50, 110);
			lblMovie.Name = "lblMovie";
			lblMovie.Size = new Size(198, 28);
			lblMovie.TabIndex = 1;
			lblMovie.Text = "Papa Zola The Movie";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDate.ForeColor = Color.LightGray;
			lblDate.Location = new Point(50, 160);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(149, 23);
			lblDate.TabIndex = 2;
			lblDate.Text = "Date: 28 July 2026";
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTime.ForeColor = Color.LightGray;
			lblTime.Location = new Point(50, 205);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(80, 23);
			lblTime.TabIndex = 3;
			lblTime.Text = "12:30 PM";
			// 
			// lblHall
			// 
			lblHall.AutoSize = true;
			lblHall.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblHall.ForeColor = Color.LightGray;
			lblHall.Location = new Point(50, 250);
			lblHall.Name = "lblHall";
			lblHall.Size = new Size(57, 23);
			lblHall.TabIndex = 4;
			lblHall.Text = "Hall: H";
			// 
			// lblSeats
			// 
			lblSeats.AutoSize = true;
			lblSeats.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSeats.ForeColor = Color.LightGray;
			lblSeats.Location = new Point(50, 295);
			lblSeats.Name = "lblSeats";
			lblSeats.Size = new Size(57, 23);
			lblSeats.TabIndex = 5;
			lblSeats.Text = "B5, B4";
			// 
			// lblSnackHeader
			// 
			lblSnackHeader.AutoSize = true;
			lblSnackHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSnackHeader.ForeColor = Color.White;
			lblSnackHeader.Location = new Point(410, 110);
			lblSnackHeader.Name = "lblSnackHeader";
			lblSnackHeader.Size = new Size(133, 28);
			lblSnackHeader.TabIndex = 6;
			lblSnackHeader.Text = "Snack Orders";
			// 
			// pnlSnacksContainer
			// 
			pnlSnacksContainer.AutoScroll = true;
			pnlSnacksContainer.BackColor = Color.FromArgb(24, 21, 36);
			pnlSnacksContainer.BorderStyle = BorderStyle.FixedSingle;
			pnlSnacksContainer.FlowDirection = FlowDirection.TopDown;
			pnlSnacksContainer.Location = new Point(410, 150);
			pnlSnacksContainer.Name = "pnlSnacksContainer";
			pnlSnacksContainer.Padding = new Padding(8);
			pnlSnacksContainer.Size = new Size(420, 230);
			pnlSnacksContainer.TabIndex = 7;
			pnlSnacksContainer.WrapContents = false;
			// 
			// lblTotalHeader
			// 
			lblTotalHeader.AutoSize = true;
			lblTotalHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalHeader.ForeColor = Color.Gray;
			lblTotalHeader.Location = new Point(600, 415);
			lblTotalHeader.Name = "lblTotalHeader";
			lblTotalHeader.Size = new Size(106, 23);
			lblTotalHeader.TabIndex = 8;
			lblTotalHeader.Text = "TOTAL PAID";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotal.ForeColor = Color.FromArgb(0, 230, 153);
			lblTotal.Location = new Point(600, 440);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(168, 46);
			lblTotal.TabIndex = 9;
			lblTotal.Text = "RM 76.00";
			// 
			// btnPrint
			// 
			btnPrint.BackColor = Color.FromArgb(162, 89, 255);
			btnPrint.FlatAppearance.BorderSize = 0;
			btnPrint.FlatStyle = FlatStyle.Flat;
			btnPrint.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnPrint.ForeColor = Color.White;
			btnPrint.Location = new Point(50, 440);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(170, 45);
			btnPrint.TabIndex = 10;
			btnPrint.Text = "🖨 Print Receipt";
			btnPrint.UseVisualStyleBackColor = false;
			btnPrint.Click += btnPrint_Click;
			// 
			// TicketReceiptForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(30, 27, 46);
			ClientSize = new Size(882, 553);
			Controls.Add(btnPrint);
			Controls.Add(lblTotal);
			Controls.Add(lblTotalHeader);
			Controls.Add(pnlSnacksContainer);
			Controls.Add(lblSnackHeader);
			Controls.Add(lblSeats);
			Controls.Add(lblHall);
			Controls.Add(lblTime);
			Controls.Add(lblDate);
			Controls.Add(lblMovie);
			Controls.Add(panelHeader);
			Name = "TicketReceiptForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Digital Ticket";
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
		private Button btnBack;
		private Label lblTitleHeader;
		private Label lblMovie;
		private Label lblDate;
		private Label lblTime;
		private Label lblHall;
		private Label lblSeats;
		private Label lblSnackHeader;
		private FlowLayoutPanel pnlSnacksContainer;
		private Label lblTotalHeader;
		private Label lblTotal;
		private Button btnPrint;
	}
}
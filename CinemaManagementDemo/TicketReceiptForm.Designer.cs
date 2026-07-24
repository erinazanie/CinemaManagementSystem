namespace CinemaManagementDemo
{
    partial class TicketReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnBack = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnPrint = new Button();
            lblTotal = new Label();
            label8 = new Label();
            lstSnacks = new ListBox();
            label7 = new Label();
            lblSeats = new Label();
            lblHall = new Label();
            lblTime = new Label();
            lblDate = new Label();
            lblMovie = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(45, 40, 62);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(60, 54, 80);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 89, 255);
            label1.Location = new Point(325, 13);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 0;
            label1.Text = "🎬 STARLIGHT CINEMAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 40, 62);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lstSnacks);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblSeats);
            panel1.Controls.Add(lblHall);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblMovie);
            panel1.Location = new Point(30, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 541);
            panel1.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(162, 89, 255);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(38, 453);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 45);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "🖨 Print Receipt\n";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(162, 89, 255);
            lblTotal.Location = new Point(600, 457);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(151, 41);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "RM 68.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(600, 412);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 7;
            label8.Text = "TOTAL PAID";
            // 
            // lstSnacks
            // 
            lstSnacks.BackColor = Color.FromArgb(30, 27, 46);
            lstSnacks.ForeColor = Color.White;
            lstSnacks.FormattingEnabled = true;
            lstSnacks.Location = new Point(470, 112);
            lstSnacks.Name = "lstSnacks";
            lstSnacks.Size = new Size(300, 64);
            lstSnacks.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(470, 69);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 5;
            label7.Text = "Snack";
            label7.Click += label7_Click;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.ForeColor = Color.White;
            lblSeats.Location = new Point(38, 272);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(94, 20);
            lblSeats.TabIndex = 4;
            lblSeats.Text = "Seats: A1, A2";
            // 
            // lblHall
            // 
            lblHall.AutoSize = true;
            lblHall.ForeColor = Color.White;
            lblHall.Location = new Point(38, 232);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(54, 20);
            lblHall.TabIndex = 3;
            lblHall.Text = "Hall: H";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(38, 192);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(109, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time: 12:30 PM";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(38, 152);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(128, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date: 28 July 2026";
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.ForeColor = Color.White;
            lblMovie.Location = new Point(38, 112);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(196, 20);
            lblMovie.TabIndex = 0;
            lblMovie.Text = "Movie: Papa Zola The Movie";
            // 
            // TicketReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 46);
            ClientSize = new Size(882, 653);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Name = "TicketReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Digital Ticket";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Button btnBack;
        private Panel panel1;
        private Label lblHall;
        private Label lblTime;
        private Label lblDate;
        private Label lblMovie;
        private Label lblSeats;
        private Label label8;
        private ListBox lstSnacks;
        private Label label7;
        private Label lblTotal;
        private Button btnPrint;
    }
}
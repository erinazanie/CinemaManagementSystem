namespace CinemaManagementDemo
{
    partial class SnackSelectionForm
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
            panel1 = new Panel();
            btnBack = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnCheckout = new Button();
            lblGrandTotal = new Label();
            lstOrderItems = new ListBox();
            panel4 = new Panel();
            lblBookingDetails = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pnlSnackGrid = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 40, 62);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 50);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(60, 54, 80);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 89, 255);
            label1.Location = new Point(325, 13);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "🎬 STARLIGHT CINEMAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 40, 62);
            panel2.Controls.Add(btnCheckout);
            panel2.Controls.Add(lblGrandTotal);
            panel2.Controls.Add(lstOrderItems);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblBookingDetails);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(590, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 470);
            panel2.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(162, 89, 255);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(15, 400);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(240, 45);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout ➔";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click_1;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(162, 89, 255);
            lblGrandTotal.Location = new Point(15, 350);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(161, 28);
            lblGrandTotal.TabIndex = 4;
            lblGrandTotal.Text = "Total: RM 36.00";
            // 
            // lstOrderItems
            // 
            lstOrderItems.BackColor = Color.FromArgb(30, 27, 46);
            lstOrderItems.BorderStyle = BorderStyle.FixedSingle;
            lstOrderItems.ForeColor = Color.White;
            lstOrderItems.FormattingEnabled = true;
            lstOrderItems.Location = new Point(15, 130);
            lstOrderItems.Name = "lstOrderItems";
            lstOrderItems.Size = new Size(240, 182);
            lstOrderItems.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(60, 54, 80);
            panel4.Location = new Point(15, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 2);
            panel4.TabIndex = 2;
            // 
            // lblBookingDetails
            // 
            lblBookingDetails.ForeColor = Color.LightGray;
            lblBookingDetails.Location = new Point(15, 45);
            lblBookingDetails.Name = "lblBookingDetails";
            lblBookingDetails.Size = new Size(240, 60);
            lblBookingDetails.TabIndex = 1;
            lblBookingDetails.Text = "Movie: Papa Zola\r\nSeats: A1, A2\r\nTime: 12:30 PM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 0;
            label2.Text = "Order Summary";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 40, 62);
            panel3.Controls.Add(pnlSnackGrid);
            panel3.Location = new Point(20, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 470);
            panel3.TabIndex = 2;
            // 
            // pnlSnackGrid
            // 
            pnlSnackGrid.AutoScroll = true;
            pnlSnackGrid.BackColor = Color.FromArgb(30, 27, 46);
            pnlSnackGrid.Location = new Point(15, 15);
            pnlSnackGrid.Name = "pnlSnackGrid";
            pnlSnackGrid.Size = new Size(520, 440);
            pnlSnackGrid.TabIndex = 0;
            // 
            // SnackSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 46);
            ClientSize = new Size(882, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SnackSelectionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Snack & Beverage Selection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label label1;
        private Panel panel2;
        private Label lblBookingDetails;
        private Label label2;
        private Panel panel3;
        private FlowLayoutPanel pnlSnackGrid;
        private ListBox lstOrderItems;
        private Panel panel4;
        private Label lblGrandTotal;
        private Button btnCheckout;
    }
}
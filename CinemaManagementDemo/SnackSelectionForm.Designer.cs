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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCheckout = new Button();
            lblGrandTotal = new Label();
            lstOrderItems = new ListBox();
            panel4 = new Panel();
            lblBookingDetails = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pnlSnackGrid = new FlowLayoutPanel();
            panel5 = new Panel();
            email = new TextBox();
            name = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
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
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCheckout);
            panel2.Controls.Add(lblGrandTotal);
            panel2.Controls.Add(lstOrderItems);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblBookingDetails);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(590, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 562);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(15, 105);
            label5.Name = "label5";
            label5.Size = new Size(240, 20);
            label5.TabIndex = 8;
            label5.Text = "Time: 12:30 PM";
            // 
            // label4
            // 
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(15, 85);
            label4.Name = "label4";
            label4.Size = new Size(240, 20);
            label4.TabIndex = 7;
            label4.Text = "Hall: H";
            // 
            // label3
            // 
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(15, 65);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 6;
            label3.Text = "Seats: A1, A2\r\n";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(162, 89, 255);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(15, 500);
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
            lblGrandTotal.Location = new Point(16, 452);
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
            lstOrderItems.Location = new Point(15, 169);
            lstOrderItems.Name = "lstOrderItems";
            lstOrderItems.Size = new Size(240, 242);
            lstOrderItems.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(60, 54, 80);
            panel4.Location = new Point(15, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 3);
            panel4.TabIndex = 2;
            // 
            // lblBookingDetails
            // 
            lblBookingDetails.ForeColor = Color.LightGray;
            lblBookingDetails.Location = new Point(15, 45);
            lblBookingDetails.Name = "lblBookingDetails";
            lblBookingDetails.Size = new Size(240, 20);
            lblBookingDetails.TabIndex = 1;
            lblBookingDetails.Text = "Movie: Papa Zola\r\n";
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
            panel3.Size = new Size(550, 391);
            panel3.TabIndex = 2;
            // 
            // pnlSnackGrid
            // 
            pnlSnackGrid.AutoScroll = true;
            pnlSnackGrid.BackColor = Color.FromArgb(30, 27, 46);
            pnlSnackGrid.Location = new Point(15, 15);
            pnlSnackGrid.Name = "pnlSnackGrid";
            pnlSnackGrid.Size = new Size(520, 358);
            pnlSnackGrid.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 40, 62);
            panel5.Controls.Add(email);
            panel5.Controls.Add(name);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(20, 479);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 153);
            panel5.TabIndex = 3;
            // 
            // email
            // 
            email.BackColor = Color.FromArgb(60, 54, 80);
            email.BorderStyle = BorderStyle.FixedSingle;
            email.ForeColor = Color.White;
            email.Location = new Point(100, 103);
            email.Name = "email";
            email.Size = new Size(435, 27);
            email.TabIndex = 4;
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(60, 54, 80);
            name.BorderStyle = BorderStyle.FixedSingle;
            name.ForeColor = Color.White;
            name.Location = new Point(100, 54);
            name.Name = "name";
            name.Size = new Size(435, 27);
            name.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 9);
            label8.Name = "label8";
            label8.Size = new Size(174, 28);
            label8.TabIndex = 2;
            label8.Text = "Customer Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(35, 106);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 1;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(35, 58);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 0;
            label6.Text = "Name: ";
            // 
            // SnackSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 46);
            ClientSize = new Size(882, 653);
            Controls.Add(panel5);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel5;
        private TextBox email;
        private TextBox name;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
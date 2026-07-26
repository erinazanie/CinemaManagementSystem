namespace CinemaManagementDemo
{
    partial class MovieDetailsForm
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
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            lblProducer = new Label();
            lblReleaseDate = new Label();
            ageLimit = new Label();
            picPoster = new PictureBox();
            lblMovieDetails = new Label();
            lblGenre = new Label();
            lblMovieTitle = new Label();
            panel3 = new Panel();
            btnNextSnacks = new Button();
            lblSelectedSeats = new Label();
            pnlSeats = new FlowLayoutPanel();
            label3 = new Label();
            rbTime4 = new RadioButton();
            rbTime3 = new RadioButton();
            rbTime2 = new RadioButton();
            rbTime1 = new RadioButton();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 40, 62);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 89, 255);
            label1.Location = new Point(325, 13);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 1;
            label1.Text = "🎬 STARLIGHT CINEMAS";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 54, 80);
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 40, 62);
            panel2.Controls.Add(lblProducer);
            panel2.Controls.Add(lblReleaseDate);
            panel2.Controls.Add(ageLimit);
            panel2.Controls.Add(picPoster);
            panel2.Controls.Add(lblMovieDetails);
            panel2.Controls.Add(lblGenre);
            panel2.Controls.Add(lblMovieTitle);
            panel2.Location = new Point(20, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 560);
            panel2.TabIndex = 1;
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducer.ForeColor = Color.Gray;
            lblProducer.Location = new Point(15, 368);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(170, 17);
            lblProducer.TabIndex = 6;
            lblProducer.Text = "Producer: Animonsta Studio";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReleaseDate.ForeColor = Color.Gray;
            lblReleaseDate.Location = new Point(15, 348);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(117, 17);
            lblReleaseDate.TabIndex = 5;
            lblReleaseDate.Text = "Release Year: 2024";
            // 
            // ageLimit
            // 
            ageLimit.AutoSize = true;
            ageLimit.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLimit.ForeColor = Color.Gray;
            ageLimit.Location = new Point(15, 328);
            ageLimit.Name = "ageLimit";
            ageLimit.Size = new Size(90, 17);
            ageLimit.TabIndex = 4;
            ageLimit.Text = "Age Limit: P13";
            // 
            // picPoster
            // 
            picPoster.Location = new Point(15, 15);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(230, 250);
            picPoster.SizeMode = PictureBoxSizeMode.Zoom;
            picPoster.TabIndex = 3;
            picPoster.TabStop = false;
            // 
            // lblMovieDetails
            // 
            lblMovieDetails.ForeColor = Color.LightGray;
            lblMovieDetails.Location = new Point(15, 392);
            lblMovieDetails.Name = "lblMovieDetails";
            lblMovieDetails.Size = new Size(230, 100);
            lblMovieDetails.TabIndex = 2;
            lblMovieDetails.Text = "Follow Papa Zola on an epic comedy-packed adventure as he saves the galaxy!";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenre.ForeColor = Color.Gray;
            lblGenre.Location = new Point(15, 308);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(122, 17);
            lblGenre.TabIndex = 1;
            lblGenre.Text = "Animation • 1h 52m";
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.ForeColor = Color.White;
            lblMovieTitle.Location = new Point(15, 278);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(211, 28);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "Papa Zola The Movie";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 40, 62);
            panel3.Controls.Add(btnNextSnacks);
            panel3.Controls.Add(lblSelectedSeats);
            panel3.Controls.Add(pnlSeats);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(rbTime4);
            panel3.Controls.Add(rbTime3);
            panel3.Controls.Add(rbTime2);
            panel3.Controls.Add(rbTime1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(300, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 560);
            panel3.TabIndex = 2;
            // 
            // btnNextSnacks
            // 
            btnNextSnacks.BackColor = Color.FromArgb(162, 89, 255);
            btnNextSnacks.FlatStyle = FlatStyle.Flat;
            btnNextSnacks.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextSnacks.ForeColor = Color.White;
            btnNextSnacks.Location = new Point(360, 503);
            btnNextSnacks.Name = "btnNextSnacks";
            btnNextSnacks.Size = new Size(185, 40);
            btnNextSnacks.TabIndex = 8;
            btnNextSnacks.Text = "Choose Snacks ➔";
            btnNextSnacks.UseVisualStyleBackColor = false;
            btnNextSnacks.Click += btnNextSnacks_Click;
            // 
            // lblSelectedSeats
            // 
            lblSelectedSeats.AutoSize = true;
            lblSelectedSeats.ForeColor = Color.FromArgb(162, 89, 255);
            lblSelectedSeats.Location = new Point(15, 415);
            lblSelectedSeats.Name = "lblSelectedSeats";
            lblSelectedSeats.Size = new Size(215, 20);
            lblSelectedSeats.TabIndex = 7;
            lblSelectedSeats.Text = "Selected Seats: None (RM 0.00)";
            // 
            // pnlSeats
            // 
            pnlSeats.BackColor = Color.FromArgb(30, 27, 46);
            pnlSeats.Location = new Point(65, 150);
            pnlSeats.Name = "pnlSeats";
            pnlSeats.Padding = new Padding(10);
            pnlSeats.Size = new Size(430, 230);
            pnlSeats.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(60, 54, 80);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(15, 110);
            label3.Name = "label3";
            label3.Size = new Size(530, 20);
            label3.TabIndex = 5;
            label3.Text = "🍿 SCREEN THIS WAY 🍿";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbTime4
            // 
            rbTime4.AutoSize = true;
            rbTime4.ForeColor = Color.White;
            rbTime4.Location = new Point(455, 55);
            rbTime4.Name = "rbTime4";
            rbTime4.Size = new Size(90, 24);
            rbTime4.TabIndex = 4;
            rbTime4.Text = "10:00 PM";
            rbTime4.UseVisualStyleBackColor = true;
            // 
            // rbTime3
            // 
            rbTime3.AutoSize = true;
            rbTime3.ForeColor = Color.White;
            rbTime3.Location = new Point(319, 55);
            rbTime3.Name = "rbTime3";
            rbTime3.Size = new Size(90, 24);
            rbTime3.TabIndex = 3;
            rbTime3.Text = "07:15 PM";
            rbTime3.UseVisualStyleBackColor = true;
            // 
            // rbTime2
            // 
            rbTime2.AutoSize = true;
            rbTime2.ForeColor = Color.White;
            rbTime2.Location = new Point(176, 55);
            rbTime2.Name = "rbTime2";
            rbTime2.Size = new Size(90, 24);
            rbTime2.TabIndex = 2;
            rbTime2.Text = "03:45 PM";
            rbTime2.UseVisualStyleBackColor = true;
            // 
            // rbTime1
            // 
            rbTime1.AutoSize = true;
            rbTime1.Checked = true;
            rbTime1.ForeColor = Color.White;
            rbTime1.Location = new Point(40, 55);
            rbTime1.Name = "rbTime1";
            rbTime1.Size = new Size(90, 24);
            rbTime1.TabIndex = 1;
            rbTime1.TabStop = true;
            rbTime1.Text = "12:30 PM";
            rbTime1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 0;
            label2.Text = "1. Select Showtime";
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 46);
            ClientSize = new Size(882, 653);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MovieDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Movie Details & Seat Selection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label lblMovieTitle;
        private Label lblMovieDetails;
        private Label lblGenre;
        private PictureBox picPoster;
        private Panel panel3;
        private RadioButton rbTime4;
        private RadioButton rbTime3;
        private RadioButton rbTime2;
        private RadioButton rbTime1;
        private Label label2;
        private Label label3;
        private Button btnNextSnacks;
        private Label lblSelectedSeats;
        private FlowLayoutPanel pnlSeats;
        private Label ageLimit;
        private Label lblProducer;
        private Label lblReleaseDate;
    }
}
namespace CinemaManagementDemo
{
    partial class Movies
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            pnlComingSoonContainer = new FlowLayoutPanel();
            label2 = new Label();
            pnlNowShowingContainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 40, 62);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 89, 255);
            label1.Location = new Point(320, 15);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 0;
            label1.Text = "🎬 STARLIGHT CINEMAS";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(pnlComingSoonContainer);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pnlNowShowingContainer);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 593);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 0;
            label2.Text = "NOW SHOWING";
            // 
            // pnlNowShowingContainer
            // 
            pnlNowShowingContainer.AutoScroll = true;
            pnlNowShowingContainer.Location = new Point(20, 55);
            pnlNowShowingContainer.Name = "pnlNowShowingContainer";
            pnlNowShowingContainer.Size = new Size(840, 230);
            pnlNowShowingContainer.TabIndex = 1;
            pnlNowShowingContainer.WrapContents = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 300);
            label11.Name = "label11";
            label11.Size = new Size(157, 28);
            label11.TabIndex = 2;
            label11.Text = "COMING SOON";
            // 
            // pnlComingSoonContainer
            // 
            pnlComingSoonContainer.AutoScroll = true;
            pnlComingSoonContainer.Location = new Point(20, 340);
            pnlComingSoonContainer.Name = "pnlComingSoonContainer";
            pnlComingSoonContainer.Size = new Size(840, 230);
            pnlComingSoonContainer.TabIndex = 3;
            pnlComingSoonContainer.WrapContents = false;
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 46);
            ClientSize = new Size(882, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Movies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Starlight Cinemas";
            Load += Movies_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private FlowLayoutPanel pnlNowShowingContainer;
        private Label label11;
        private FlowLayoutPanel pnlComingSoonContainer;
    }
}
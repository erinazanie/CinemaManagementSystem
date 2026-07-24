using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass the movie name and details to Page 2
            MovieDetailsForm detailsPage = new MovieDetailsForm("Papa Zola The Movie", "Animation • 1h 52m");

            this.Hide(); // Hide main menu
            detailsPage.ShowDialog(); // Display Details Form
            this.Show(); // Re-show main menu when user returns back
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Reuse existing handler that passes movie data to the details form
            button1_Click(sender, e);
        }
    }
}
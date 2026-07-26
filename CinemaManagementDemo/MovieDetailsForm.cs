using System;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
    public partial class MovieDetailsForm : Form
    {
        private Movie selectedMovie;

        // Overload constructor to accept a Movie instance from your class library
        public MovieDetailsForm(Movie movie)
        {
            InitializeComponent();
            this.selectedMovie = movie;

            // Populate form controls using the Movie methods/properties
            DisplayMovieDetails();
        }

        // Designer event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            // Back button - close this details form
            this.Close();
        }

        private void btnNextSnacks_Click(object sender, EventArgs e)
        {
            // Open snack selection page. SnackSelectionForm currently has a parameterless ctor
            using (var snackPage = new SnackSelectionForm())
            {
                this.Hide();
                snackPage.ShowDialog();
                this.Show();
            }
        }

        private void DisplayMovieDetails()
        {
            if (selectedMovie != null)
            {
                // Format runtime (e.g., 112 mins -> 1h 52m)
                int hrs = selectedMovie.duration / 60;
                int mins = selectedMovie.duration % 60;
                string durationFormatted = $"{hrs}h {mins:D2}m";

                // Update UI Labels
                lblMovieTitle.Text = selectedMovie.title;
                lblMovieDetails.Text = $"{selectedMovie.genre} • {durationFormatted} • {selectedMovie.releaseYear}";
                lblProducer.Text = $"Producer: {selectedMovie.producer}";

                // Polymorphism check: handles extra fields if it's a Coming Soon movie
                if (selectedMovie is ComingSoonMovie comingSoon)
                {
                    lblReleaseDate.Text = $"Expected Release: {comingSoon.expectedRelease:dd MMM yyyy}";
                    lblReleaseDate.Visible = true;
                }
                else
                {
                    lblReleaseDate.Visible = false;
                }
            }
        }
    }
}
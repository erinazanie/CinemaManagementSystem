using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
    public partial class MovieDetailsForm : Form
    {
        private List<string> selectedSeats = new List<string>();
        private const decimal TICKET_PRICE = 18.00m; // Price per ticket in RM

        public MovieDetailsForm(string movieTitle, string movieDetails)
        {
            InitializeComponent();

            // Set passed movie data
            lblMovieTitle.Text = movieTitle;
            lblGenre.Text = movieDetails;

            GenerateInteractiveSeats();
        }

        private void GenerateInteractiveSeats()
        {
            pnlSeats.Controls.Clear();

            string[] rows = { "A", "B", "C", "D" };
            int seatsPerRow = 6;

            foreach (string row in rows)
            {
                for (int i = 1; i <= seatsPerRow; i++)
                {
                    string seatNumber = $"{row}{i}";

                    Button btnSeat = new Button
                    {
                        Text = seatNumber,
                        Size = new Size(55, 40),
                        Margin = new Padding(6),
                        BackColor = Color.FromArgb(60, 54, 80), // Default Available Color (Dark Slate)
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                        Tag = seatNumber,
                        Cursor = Cursors.Hand
                    };
                    btnSeat.FlatAppearance.BorderSize = 0;

                    // Make a couple of seats look "Occupied" as a realistic dummy effect
                    if (seatNumber == "B3" || seatNumber == "B4")
                    {
                        btnSeat.BackColor = Color.FromArgb(180, 50, 50); // Red = Booked
                        btnSeat.Enabled = false;
                    }
                    else
                    {
                        // Attach Click Event handler for user interaction
                        btnSeat.Click += Seat_Click;
                    }

                    pnlSeats.Controls.Add(btnSeat);
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btnSeat = (Button)sender;
            string seatNumber = btnSeat.Tag.ToString();

            if (selectedSeats.Contains(seatNumber))
            {
                // Unselect seat
                selectedSeats.Remove(seatNumber);
                btnSeat.BackColor = Color.FromArgb(60, 54, 80); // Return to standard purple-gray
            }
            else
            {
                // Select seat
                selectedSeats.Add(seatNumber);
                btnSeat.BackColor = Color.FromArgb(162, 89, 255); // Highlight Active Purple
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            if (selectedSeats.Count == 0)
            {
                lblSelectedSeats.Text = "Selected Seats: None (RM 0.00)";
            }
            else
            {
                decimal total = selectedSeats.Count * TICKET_PRICE;
                string seatList = string.Join(", ", selectedSeats);
                lblSelectedSeats.Text = $"Seats: {seatList} | Total: RM {total:F2}";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Form1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextSnacks_Click(object sender, EventArgs e)
        {
            // Check if seats have been selected (e.g., check if your selected seats list/variable is empty)
            // Replace 'selectedSeats' with whatever variable or list you use to track seats
            if (selectedSeats == null || selectedSeats.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one seat before proceeding!",
                    "Seat Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop execution so the form doesn't open
            }

            // If seats are selected, open the Snack Selection Form
            SnackSelectionForm snackPage = new SnackSelectionForm();
            this.Hide();
            snackPage.ShowDialog();
            this.Show();
        }
    }
}
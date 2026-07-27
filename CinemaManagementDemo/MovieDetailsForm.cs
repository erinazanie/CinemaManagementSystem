using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
	public partial class MovieDetailsForm : Form
	{
		private Movie selectedMovie;
		private Hall currentHall;
		private Dictionary<Seat, TicketType> selectedSeatMap = new Dictionary<Seat, TicketType>();
		private Dictionary<string, Hall> showtimeHallMap = new Dictionary<string, Hall>();

		public MovieDetailsForm()
		{
			InitializeComponent();
		}

		public MovieDetailsForm(Movie movie, Hall hall = null) : this()
		{
			this.selectedMovie = movie;
			this.currentHall = hall;
		}

		private void InitializeShowtimeHalls()
		{
			showtimeHallMap.Clear();

			// Generate dynamic halls based on movie ID/Title so each movie gets its own distinct Hall
			Hall primaryHall;
			Hall secondaryHall;

			if (selectedMovie != null)
			{
				switch (selectedMovie.movieID)
				{
					case "M001":
						primaryHall = new Hall("H01", "Hall 1 - Family Deluxe", 24);
						secondaryHall = new Hall("H05", "Hall 5 - Kids Screen", 20);
						break;
					case "M002":
						primaryHall = new Hall("H02", "Hall 2 - Dolby Atmos", 24);
						secondaryHall = new Hall("H06", "Hall 6 - Standard", 18);
						break;
					case "M003":
						primaryHall = new Hall("H03", "Hall 3 - Standard", 24);
						secondaryHall = new Hall("H07", "Hall 7 - Club Cinema", 18);
						break;
					case "M004":
						primaryHall = new Hall("H04", "Hall 4 - IMAX 3D", 24);
						secondaryHall = new Hall("H08", "Hall 8 - VIP Suite", 18);
						break;
					default:
						primaryHall = new Hall("H01", $"Hall 1 - {selectedMovie.title}", 24);
						secondaryHall = new Hall("H02", $"Hall 2 - {selectedMovie.title}", 18);
						break;
				}
			}
			else
			{
				primaryHall = new Hall("H01", "Hall 1 - Standard", 24);
				secondaryHall = new Hall("H02", "Hall 2 - IMAX", 18);
			}

			PopulateHallSeats(primaryHall, 4, 6);
			PopulateHallSeats(secondaryHall, 3, 6);

			showtimeHallMap["12:30 PM"] = primaryHall;
			showtimeHallMap["03:45 PM"] = primaryHall;
			showtimeHallMap["07:15 PM"] = secondaryHall;
			showtimeHallMap["10:00 PM"] = secondaryHall;
		}

		private void PopulateHallSeats(Hall hall, int rowsCount, int seatsPerRow)
		{
			char[] rows = { 'A', 'B', 'C', 'D', 'E' };
			for (int r = 0; r < rowsCount; r++)
			{
				for (int i = 1; i <= seatsPerRow; i++)
				{
					hall.addSeat(new Seat($"{rows[r]}{i}"));
				}
			}
		}

		private void MovieDetailsForm_Load(object sender, EventArgs e)
		{
			DisplayMovieDetails();
			InitializeShowtimeHalls();

			rbTime1.CheckedChanged += ShowtimeRadioButton_CheckedChanged;
			rbTime2.CheckedChanged += ShowtimeRadioButton_CheckedChanged;
			rbTime3.CheckedChanged += ShowtimeRadioButton_CheckedChanged;
			rbTime4.CheckedChanged += ShowtimeRadioButton_CheckedChanged;

			SyncCurrentHallWithSelectedShowtime();
			GenerateSeatingGridFromHall();
			UpdateSeatSelectionUI();
		}

		private void SyncCurrentHallWithSelectedShowtime()
		{
			string selectedTime = GetSelectedShowtime();
			if (showtimeHallMap.TryGetValue(selectedTime, out Hall matchedHall))
			{
				this.currentHall = matchedHall;
			}
		}

		private void ShowtimeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (rb != null && rb.Checked)
			{
				SyncCurrentHallWithSelectedShowtime();

				selectedSeatMap.Clear();
				RenderTicketTypeSelectors();

				GenerateSeatingGridFromHall();
				UpdateSeatSelectionUI();
			}
		}

		private void DisplayMovieDetails()
		{
			if (selectedMovie == null) return;

			int hrs = selectedMovie.duration / 60;
			int mins = selectedMovie.duration % 60;

			lblMovieTitle.Text = selectedMovie.title;
			lblGenre.Text = $"{selectedMovie.genre} • {hrs}h {mins:D2}m";
			ageLimit.Text = $"Age Limit: P{selectedMovie.ageLimit}";
			lblReleaseDate.Text = $"Release Year: {selectedMovie.releaseYear}";
			lblProducer.Text = $"Producer: {selectedMovie.producer}";
			lblMovieDetails.Text = selectedMovie.description;

			if (selectedMovie is ComingSoonMovie comingSoon)
			{
				lblReleaseDate.Text = $"Release Date: {comingSoon.expectedRelease:dd MMM yyyy}";
			}
		}

		private void GenerateSeatingGridFromHall()
		{
			pnlSeats.Controls.Clear();

			if (currentHall == null || currentHall.seats == null) return;

			foreach (Seat seatObj in currentHall.seats)
			{
				bool available = seatObj.isAvailable();

				Button btnSeat = new Button
				{
					Text = seatObj.seatNumber,
					Size = new Size(50, 40),
					Margin = new Padding(6),
					FlatStyle = FlatStyle.Flat,
					BackColor = available ? Color.FromArgb(60, 54, 80) : Color.DarkRed,
					ForeColor = available ? Color.White : Color.Gray,
					Enabled = available,
					Tag = seatObj,
					Cursor = available ? Cursors.Hand : Cursors.Default
				};
				btnSeat.FlatAppearance.BorderColor = Color.FromArgb(162, 89, 255);

				btnSeat.Click += (s, e) => ToggleSeatSelection(btnSeat, seatObj);

				pnlSeats.Controls.Add(btnSeat);
			}
		}

		private void ToggleSeatSelection(Button btn, Seat seat)
		{
			var existingKey = selectedSeatMap.Keys.FirstOrDefault(s => s.seatNumber == seat.seatNumber);

			if (existingKey != null)
			{
				selectedSeatMap.Remove(existingKey);
				btn.BackColor = Color.FromArgb(60, 54, 80);
			}
			else
			{
				selectedSeatMap.Add(seat, TicketType.adult);
				btn.BackColor = Color.FromArgb(162, 89, 255);
			}

			RenderTicketTypeSelectors();
			UpdateSeatSelectionUI();
		}

		private void RenderTicketTypeSelectors()
		{
			pnlTicketTypes.Controls.Clear();

			foreach (var kvp in selectedSeatMap.ToList())
			{
				Seat seat = kvp.Key;

				Panel itemPanel = new Panel
				{
					Size = new Size(300, 32),
					Margin = new Padding(0, 2, 0, 2)
				};

				Label lblSeat = new Label
				{
					Text = $"Seat {seat.seatNumber}:",
					ForeColor = Color.White,
					Font = new Font("Segoe UI", 9f, FontStyle.Bold),
					Location = new Point(5, 6),
					AutoSize = true
				};

				ComboBox cmbType = new ComboBox
				{
					DataSource = Enum.GetValues(typeof(TicketType)),
					SelectedItem = kvp.Value,
					Location = new Point(85, 3),
					Size = new Size(200, 25),
					DropDownStyle = ComboBoxStyle.DropDownList,
					BackColor = Color.FromArgb(60, 54, 80),
					ForeColor = Color.White
				};

				cmbType.SelectedIndexChanged += (s, e) =>
				{
					if (Enum.TryParse<TicketType>(cmbType.SelectedItem?.ToString(), out var newType))
					{
						selectedSeatMap[seat] = newType;
						UpdateSeatSelectionUI();
					}
				};

				itemPanel.Controls.Add(lblSeat);
				itemPanel.Controls.Add(cmbType);
				pnlTicketTypes.Controls.Add(itemPanel);
			}
		}

		private void UpdateSeatSelectionUI()
		{
			if (selectedSeatMap.Count == 0)
			{
				lblSelectedSeats.Text = "Selected Seats: None (RM 0.00)";
				return;
			}

			double total = selectedSeatMap.Sum(kvp =>
				new Ticket($"T-{kvp.Key.seatNumber}", kvp.Key, kvp.Value).calculatePrice()
			);

			string seatListStr = string.Join(", ", selectedSeatMap.Select(kvp => $"{kvp.Key.seatNumber} ({kvp.Value})"));
			lblSelectedSeats.Text = $"Selected Seats: {seatListStr} (RM {total:F2})";
		}

		private string GetSelectedShowtime()
		{
			if (rbTime1.Checked) return rbTime1.Text;
			if (rbTime2.Checked) return rbTime2.Text;
			if (rbTime3.Checked) return rbTime3.Text;
			if (rbTime4.Checked) return rbTime4.Text;
			return "12:30 PM";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNextSnacks_Click(object sender, EventArgs e)
		{
			if (selectedSeatMap.Count == 0)
			{
				MessageBox.Show("Please select at least one seat before proceeding.", "No Seats Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string chosenTime = GetSelectedShowtime();

			List<Ticket> tickets = selectedSeatMap
				.Select((kvp, index) => new Ticket($"TKN-{index + 1}", kvp.Key, kvp.Value))
				.ToList();

			using (var snackPage = new SnackSelectionForm(selectedMovie, chosenTime, currentHall, tickets))
			{
				this.Hide();
				snackPage.ShowDialog();
				this.Show();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}
	}
}
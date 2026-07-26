using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
	public partial class Movies : Form
	{
		private List<Movie> nowShowingList;
		private List<ComingSoonMovie> comingSoonList;

		// Generic repositories for type-safe JSON handling
		private MovieRepository<Movie> nowShowingRepo = new MovieRepository<Movie>("now_showing.json");
		private MovieRepository<ComingSoonMovie> comingSoonRepo = new MovieRepository<ComingSoonMovie>("coming_soon.json");

		public Movies()
		{
			InitializeComponent();
			InitializeMovieData();
		}

		private void Movies_Load(object sender, EventArgs e)
		{
			PopulateDashboard();
		}

		private void InitializeMovieData()
		{
			// 1. Load or Seed Now Showing List
			nowShowingList = nowShowingRepo.LoadMovies();
			if (nowShowingList.Count == 0)
			{
				nowShowingList = new List<Movie>
				{
					new Movie("M001", "Papa Zola The Movie", Genre.Animation, 112, 0, 2026, "Monsta", "Save the galaxy with Papa Zola!"),
					new Movie("M002", "Munafik 2", Genre.Horror, 175, 13, 2018, "Skope Productions", "Battle against evil forces tormenting a priestess."),
					new Movie("M003", "Mojoku Hilang", Genre.Comedy, 139, 13, 2026, "Studio A", "A hilarious romance dynamic."),
					new Movie("M004", "Mat Kilau", Genre.Action, 120, 13, 2022, "Studio B", "Epic historical action saga.")
				};

				// Automatically creates and populates now_showing.json
				nowShowingRepo.SaveMovies(nowShowingList);
			}

			// 2. Load or Seed Coming Soon List
			comingSoonList = comingSoonRepo.LoadMovies();
			if (comingSoonList.Count == 0)
			{
				comingSoonList = new List<ComingSoonMovie>
				{
					new ComingSoonMovie("CS01", "Jana Nayagan", Genre.Action, 150, 13, 2026, "Studio C", "Action-packed political drama.", new DateTime(2026, 8, 15)),
					new ComingSoonMovie("CS02", "Avatar 3", Genre.Sci_Fi, 190, 13, 2026, "20th Century", "New epic adventures across Pandora.", new DateTime(2026, 12, 18))
				};

				// Automatically creates and populates coming_soon.json
				comingSoonRepo.SaveMovies(comingSoonList);
			}
		}

		private void PopulateDashboard()
		{
			pnlNowShowingContainer.Controls.Clear();
			pnlComingSoonContainer.Controls.Clear();

			foreach (var movie in nowShowingList)
			{
				pnlNowShowingContainer.Controls.Add(CreateMovieCard(movie));
			}

			foreach (var comingMovie in comingSoonList)
			{
				pnlComingSoonContainer.Controls.Add(CreateComingSoonCard(comingMovie));
			}
		}

		private Panel CreateMovieCard(Movie movie)
		{
			Panel card = CreateBaseCard();

			Label lblTitle = CreateTitleLabel(movie.title);

			int hrs = movie.duration / 60;
			int mins = movie.duration % 60;
			Label lblSub = CreateSubLabel($"{movie.genre} • {hrs}h {mins:D2}m");

			Button btnView = new Button
			{
				Text = "VIEW",
				Font = new Font("Segoe UI", 9f, FontStyle.Bold),
				ForeColor = Color.White,
				BackColor = Color.FromArgb(162, 89, 255),
				FlatStyle = FlatStyle.Flat,
				Size = new Size(165, 28),
				Location = new Point(10, 165),
				Tag = movie
			};
			btnView.FlatAppearance.BorderSize = 0;
			btnView.Click += (s, e) => OpenMovieDetails(movie);

			card.Controls.Add(lblTitle);
			card.Controls.Add(lblSub);
			card.Controls.Add(btnView);

			return card;
		}

		private Panel CreateComingSoonCard(ComingSoonMovie movie)
		{
			Panel card = CreateBaseCard();

			Label lblTitle = CreateTitleLabel(movie.title);
			Label lblRelease = CreateSubLabel($"Release: {movie.expectedRelease:dd MMM yyyy}");

			Button btnNotify = new Button
			{
				Text = "NOTIFY ME",
				Font = new Font("Segoe UI", 9f, FontStyle.Bold),
				ForeColor = Color.White,
				BackColor = Color.FromArgb(60, 54, 80),
				FlatStyle = FlatStyle.Flat,
				Size = new Size(165, 28),
				Location = new Point(10, 165)
			};
			btnNotify.FlatAppearance.BorderColor = Color.FromArgb(162, 89, 255);
			btnNotify.Click += (s, e) =>
			{
				movie.notifyCustomer();
				MessageBox.Show($"You will be notified when '{movie.title}' is released!", "Notification Set");
			};

			card.Controls.Add(lblTitle);
			card.Controls.Add(lblRelease);
			card.Controls.Add(btnNotify);

			return card;
		}

		private void OpenMovieDetails(Movie movie)
		{
			MovieDetailsForm detailsPage = new MovieDetailsForm(movie);
			this.Hide();
			detailsPage.ShowDialog();
			this.Show();
		}

		private Panel CreateBaseCard()
		{
			Panel card = new Panel
			{
				Size = new Size(185, 210),
				BackColor = Color.FromArgb(45, 40, 62),
				Margin = new Padding(12, 10, 12, 10),
				Padding = new Padding(10)
			};
			PictureBox poster = new PictureBox
			{
				Size = new Size(165, 100),
				Location = new Point(10, 10),
				BackColor = Color.FromArgb(60, 54, 80)
			};
			card.Controls.Add(poster);
			return card;
		}

		private Label CreateTitleLabel(string text)
		{
			return new Label
			{
				Text = text,
				Font = new Font("Segoe UI", 9f, FontStyle.Bold),
				ForeColor = Color.White,
				Location = new Point(8, 115),
				Size = new Size(165, 20)
			};
		}

		private Label CreateSubLabel(string text)
		{
			return new Label
			{
				Text = text,
				Font = new Font("Segoe UI", 7.8f),
				ForeColor = Color.Gray,
				Location = new Point(8, 137),
				Size = new Size(165, 17)
			};
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
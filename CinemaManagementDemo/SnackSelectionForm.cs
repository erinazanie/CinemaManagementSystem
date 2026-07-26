using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
	public partial class SnackSelectionForm : Form
	{
		private decimal ticketTotal = 36.00m;

		private Dictionary<string, (decimal Price, int Qty)> snackCart =
			new Dictionary<string, (decimal, int)>();

		// Store booking information
		private Movie selectedMovie;
		private string selectedShowtime;
		private List<Ticket> selectedTickets;

		public SnackSelectionForm()
		{
			InitializeComponent();
			LoadSnackItems();
			UpdateOrderSummary();
		}

		// Receive movie, time and tickets from MovieDetailsForm
		public SnackSelectionForm(Movie movie, string showtime, List<Ticket> tickets) : this()
		{
			selectedMovie = movie;
			selectedShowtime = showtime;
			selectedTickets = tickets;

			if (tickets != null && tickets.Count > 0)
			{
				double dblSum = tickets.Sum(t => t.calculatePrice());
				ticketTotal = (decimal)dblSum;

				var seatList = string.Join(", ",
					tickets.Select(t => t.seat?.seatNumber ?? ""));

				label3.Text = $"Seats: {seatList}";
			}

			if (!string.IsNullOrEmpty(showtime))
				label5.Text = $"Time: {showtime}";

			if (movie != null)
				lblBookingDetails.Text = movie.title;

			UpdateOrderSummary();
		}

		private void LoadSnackItems()
		{
			pnlSnackGrid.Controls.Clear();

			var snacks = new[]
			{
				new { Name = "🍿 Combo A \n(Popcorn + Drink)", Price = 18.00m },
				new { Name = "🍿 Caramel Popcorn (L)", Price = 14.00m },
				new { Name = "🥤 Soft Drink (L)", Price = 7.00m },
				new { Name = "💧 Mineral Water", Price = 4.00m }
			};

			foreach (var snack in snacks)
			{
				Panel card = CreateSnackCard(snack.Name, snack.Price);
				pnlSnackGrid.Controls.Add(card);
			}
		}

		private Panel CreateSnackCard(string name, decimal price)
		{
			Panel card = new Panel
			{
				Size = new Size(235, 120),
				Margin = new Padding(10),
				BackColor = Color.FromArgb(45, 40, 62)
			};

			Label lblName = new Label
			{
				Text = name,
				Font = new Font("Segoe UI", 9f, FontStyle.Bold),
				ForeColor = Color.White,
				Location = new Point(10, 12),
				Size = new Size(215, 35)
			};

			Label lblPrice = new Label
			{
				Text = $"RM {price:F2}",
				Font = new Font("Segoe UI", 9f),
				ForeColor = Color.FromArgb(162, 89, 255),
				Location = new Point(10, 50),
				AutoSize = true
			};

			Button btnMinus = new Button
			{
				Text = "-",
				Size = new Size(30, 30),
				Location = new Point(10, 80),
				BackColor = Color.FromArgb(60, 54, 80),
				ForeColor = Color.White,
				FlatStyle = FlatStyle.Flat
			};
			btnMinus.FlatAppearance.BorderSize = 0;

			Label lblQty = new Label
			{
				Text = "0",
				Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
				ForeColor = Color.White,
				Location = new Point(45, 85),
				Size = new Size(30, 20),
				TextAlign = ContentAlignment.MiddleCenter
			};

			Button btnPlus = new Button
			{
				Text = "+",
				Size = new Size(30, 30),
				Location = new Point(80, 80),
				BackColor = Color.FromArgb(162, 89, 255),
				ForeColor = Color.White,
				FlatStyle = FlatStyle.Flat
			};
			btnPlus.FlatAppearance.BorderSize = 0;

			btnPlus.Click += (s, e) =>
			{
				int qty = int.Parse(lblQty.Text) + 1;
				lblQty.Text = qty.ToString();
				snackCart[name] = (price, qty);
				UpdateOrderSummary();
			};

			btnMinus.Click += (s, e) =>
			{
				int qty = int.Parse(lblQty.Text);

				if (qty > 0)
				{
					qty--;
					lblQty.Text = qty.ToString();

					if (qty == 0)
						snackCart.Remove(name);
					else
						snackCart[name] = (price, qty);

					UpdateOrderSummary();
				}
			};

			card.Controls.Add(lblName);
			card.Controls.Add(lblPrice);
			card.Controls.Add(btnMinus);
			card.Controls.Add(lblQty);
			card.Controls.Add(btnPlus);

			return card;
		}

		private void UpdateOrderSummary()
		{
			lstOrderItems.Items.Clear();
			decimal snackTotal = 0;

			lstOrderItems.Items.Add($"Tickets Subtotal: RM {ticketTotal:F2}");
			lstOrderItems.Items.Add("-----------------------------");

			foreach (var item in snackCart)
			{
				decimal itemTotal = item.Value.Price * item.Value.Qty;
				snackTotal += itemTotal;

				lstOrderItems.Items.Add($"{item.Key} x{item.Value.Qty} (RM {itemTotal:F2})");
			}

			decimal grandTotal = ticketTotal + snackTotal;
			lblGrandTotal.Text = $"Total: RM {grandTotal:F2}";
		}

		private void btnCheckout_Click_1(object sender, EventArgs e)
		{
			if (snackCart.Count == 0)
			{
				DialogResult result = MessageBox.Show(
					"You haven't selected any snacks or beverages.\n\nProceed without snacks?",
					"No Snacks Selected",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (result == DialogResult.No)
					return;
			}

			if (!ValidateContactInfo())
				return;

			decimal snackTotal = 0;

			foreach (var snack in snackCart)
			{
				snackTotal += snack.Value.Price * snack.Value.Qty;
			}

			decimal finalTotal = ticketTotal + snackTotal;

			TicketReceiptForm ticketForm = new TicketReceiptForm(
				selectedMovie,
				selectedShowtime,
				selectedTickets,
				snackCart,
				finalTotal
			);

			this.Hide();
			ticketForm.ShowDialog();
			this.Close();
		}

		private bool ValidateContactInfo()
		{
			string customerName = name.Text?.Trim() ?? "";
			string customerEmail = email.Text?.Trim() ?? "";

			if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerEmail))
			{
				MessageBox.Show(
					"Please enter your name and email before proceeding to checkout.",
					"Missing Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				if (string.IsNullOrEmpty(customerName))
					name.Focus();
				else
					email.Focus();

				return false;
			}

			return true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Movies moviesForm = new Movies();
			moviesForm.Show();
			this.Close();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
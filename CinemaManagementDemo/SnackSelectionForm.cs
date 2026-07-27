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
		private Movie movie;
		private string showtime;
		private Hall hall;
		private List<Ticket> tickets;
		private decimal ticketSubtotal;

		private Dictionary<string, (decimal Price, int Qty)> selectedSnacks = new Dictionary<string, (decimal Price, int Qty)>();

		private List<(string Name, decimal Price)> snackCatalog = new List<(string, decimal)>
		{
			("🍿 Combo A (Popcorn + Drink)", 18.00m),
			("🍿 Caramel Popcorn (L)", 14.00m),
			("🥤 Soft Drink (L)", 8.00m),
			("🍫 Chocolate Bar", 6.00m),
			("🌭 Hot Dog Combo", 16.00m)
		};

		public SnackSelectionForm(Movie movie, string showtime, Hall hall, List<Ticket> tickets)
		{
			InitializeComponent();

			this.movie = movie;
			this.showtime = showtime;
			this.hall = hall;
			this.tickets = tickets;

			CalculateTicketSubtotal();
			InitializeOrderSummary();
			RenderSnackCards();
			UpdateSummaryDisplay();
		}

		private void CalculateTicketSubtotal()
		{
			ticketSubtotal = 0;
			if (tickets != null)
			{
				foreach (var ticket in tickets)
				{
					ticketSubtotal += (decimal)ticket.calculatePrice();
				}
			}
		}

		private void InitializeOrderSummary()
		{
			if (movie != null) lblMovieVal.Text = movie.title;
			lblTimeVal.Text = string.IsNullOrEmpty(showtime) ? "N/A" : showtime;

			string seats = "";
			if (tickets != null)
			{
				foreach (var t in tickets)
				{
					if (t.seat != null) seats += t.seat.seatNumber + ", ";
				}
			}
			if (seats.EndsWith(", ")) seats = seats.Substring(0, seats.Length - 2);
			lblSeatsVal.Text = string.IsNullOrEmpty(seats) ? "N/A" : seats;
		}

		private void RenderSnackCards()
		{
			flpSnackList.Controls.Clear();
			flpSnackList.AutoScroll = true;
			flpSnackList.WrapContents = false;

			foreach (var item in snackCatalog)
			{
				Panel card = new Panel
				{
					Width = 410,
					Height = 90,
					BackColor = Color.FromArgb(40, 36, 60),
					Margin = new Padding(0, 0, 0, 10)
				};

				Label lblName = new Label
				{
					Text = item.Name,
					Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
					ForeColor = Color.White,
					Location = new Point(10, 8),
					Size = new Size(250, 45),
					AutoSize = false,
					AutoEllipsis = true
				};

				Label lblPrice = new Label
				{
					Text = $"RM {item.Price:F2}",
					Font = new Font("Segoe UI", 9F, FontStyle.Bold),
					ForeColor = Color.FromArgb(162, 89, 255),
					Location = new Point(10, 58),
					Size = new Size(120, 22),
					AutoSize = false
				};

				Button btnMinus = new Button
				{
					Text = "-",
					Font = new Font("Segoe UI", 10F, FontStyle.Bold),
					ForeColor = Color.White,
					BackColor = Color.FromArgb(60, 54, 80),
					FlatStyle = FlatStyle.Flat,
					Location = new Point(275, 48),
					Size = new Size(32, 32)
				};
				btnMinus.FlatAppearance.BorderSize = 0;

				Label lblQty = new Label
				{
					Text = "0",
					Font = new Font("Segoe UI", 10F, FontStyle.Bold),
					ForeColor = Color.White,
					Location = new Point(310, 48),
					Size = new Size(35, 32),
					AutoSize = false,
					TextAlign = ContentAlignment.MiddleCenter
				};

				Button btnPlus = new Button
				{
					Text = "+",
					Font = new Font("Segoe UI", 10F, FontStyle.Bold),
					ForeColor = Color.White,
					BackColor = Color.FromArgb(162, 89, 255),
					FlatStyle = FlatStyle.Flat,
					Location = new Point(348, 48),
					Size = new Size(32, 32)
				};
				btnPlus.FlatAppearance.BorderSize = 0;

				btnPlus.Click += (s, e) =>
				{
					int currentQty = int.Parse(lblQty.Text) + 1;
					lblQty.Text = currentQty.ToString();
					selectedSnacks[item.Name] = (item.Price, currentQty);
					UpdateSummaryDisplay();
				};

				btnMinus.Click += (s, e) =>
				{
					int currentQty = int.Parse(lblQty.Text);
					if (currentQty > 0)
					{
						currentQty--;
						lblQty.Text = currentQty.ToString();

						if (currentQty == 0)
							selectedSnacks.Remove(item.Name);
						else
							selectedSnacks[item.Name] = (item.Price, currentQty);

						UpdateSummaryDisplay();
					}
				};

				card.Controls.Add(lblName);
				card.Controls.Add(lblPrice);
				card.Controls.Add(btnMinus);
				card.Controls.Add(lblQty);
				card.Controls.Add(btnPlus);

				flpSnackList.Controls.Add(card);
			}
		}

		private void UpdateSummaryDisplay()
		{
			lstSummary.Items.Clear();
			lstSummary.Items.Add($"Tickets Subtotal: RM {ticketSubtotal:F2}");
			lstSummary.Items.Add("-----------------------------------------");

			decimal snackSubtotal = 0;

			foreach (var kvp in selectedSnacks)
			{
				decimal lineTotal = kvp.Value.Price * kvp.Value.Qty;
				snackSubtotal += lineTotal;
				lstSummary.Items.Add($"{kvp.Key} x{kvp.Value.Qty}");
				lstSummary.Items.Add($"   └─ RM {lineTotal:F2}");
			}

			decimal grandTotal = ticketSubtotal + snackSubtotal;
			lblGrandTotal.Text = $"Total: RM {grandTotal:F2}";
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please enter your Name and Email to proceed.", "Customer Info Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			decimal snackSubtotal = selectedSnacks.Sum(kvp => kvp.Value.Price * kvp.Value.Qty);
			decimal grandTotal = ticketSubtotal + snackSubtotal;

			// Calls 6-argument constructor
			using (TicketReceiptForm receiptForm = new TicketReceiptForm(movie, showtime, hall, tickets, selectedSnacks, grandTotal))
			{
				this.Hide();
				receiptForm.ShowDialog();
				this.Close();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
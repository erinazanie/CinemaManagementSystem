using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
	public partial class TicketReceiptForm : Form
	{
		private Movie movie;
		private string showtime;
		private List<Ticket> tickets;
		private Dictionary<string, (decimal Price, int Qty)> snacks;
		private decimal total;


		public TicketReceiptForm(
			Movie movie,
			string showtime,
			List<Ticket> tickets,
			Dictionary<string, (decimal Price, int Qty)> snacks,
			decimal total)
		{
			InitializeComponent();

			this.movie = movie;
			this.showtime = showtime;
			this.tickets = tickets;
			this.snacks = snacks;
			this.total = total;

			LoadReceipt();
		}



		private void LoadReceipt()
		{

			// Movie
			if (movie != null)
			{
				lblMovie.Text = movie.title;
			}


			// Showtime
			lblTime.Text = showtime;



			// Seats
			string seatText = "";

			if (tickets != null)
			{
				foreach (Ticket ticket in tickets)
				{
					if (ticket.seat != null)
					{
						seatText += ticket.seat.seatNumber + ", ";
					}
				}
			}


			if (seatText.EndsWith(", "))
			{
				seatText = seatText.Substring(0, seatText.Length - 2);
			}


			lblSeats.Text = seatText;



			// Snacks
			lstSnacks.Items.Clear();


			if (snacks != null)
			{
				foreach (var snack in snacks)
				{
					decimal itemTotal =
						snack.Value.Price * snack.Value.Qty;


					lstSnacks.Items.Add(
						$"{snack.Key} x{snack.Value.Qty}  RM {itemTotal:F2}"
					);
				}
			}



			// Total
			lblTotal.Text = $"Total: RM {total:F2}";
		}




		private void btnPrint_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Receipt saved successfully!",
				"Print Receipt",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}



		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void label7_Click(object sender, EventArgs e)
		{

		}



		private void lstSnacks_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lblTotal_Click(object sender, EventArgs e)
		{

		}
	}
}
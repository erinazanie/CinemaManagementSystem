using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using CinemaManagementLibrary;

namespace CinemaManagementDemo
{
	public partial class TicketReceiptForm : Form
	{
		private Movie movie;
		private string showtime;
		private Hall hall;
		private List<Ticket> tickets;
		private Dictionary<string, (decimal Price, int Qty)> snacks;
		private decimal total;

		public TicketReceiptForm(
			Movie movie,
			string showtime,
			Hall hall,
			List<Ticket> tickets,
			Dictionary<string, (decimal Price, int Qty)> snacks,
			decimal total)
		{
			InitializeComponent();

			this.movie = movie;
			this.showtime = showtime;
			this.hall = hall;
			this.tickets = tickets;
			this.snacks = snacks;
			this.total = total;

			LoadReceipt();
		}

		private void LoadReceipt()
		{
			// Movie Title
			if (movie != null)
			{
				lblMovie.Text = movie.title;
			}

			// Showtime
			if (!string.IsNullOrEmpty(showtime))
			{
				lblTime.Text = showtime;
			}

			// Hall - Direct reference to hall.name
			if (hall != null && !string.IsNullOrEmpty(hall.name))
			{
				lblHall.Text = $"Hall: {hall.name}";
			}
			else
			{
				lblHall.Text = "Hall: N/A";
			}

			// Seats
			string seatText = "";
			if (tickets != null)
			{
				foreach (Ticket ticket in tickets)
				{
					if (ticket.seat != null)
					{
						seatText += $"{ticket.seat.seatNumber}, ";
					}
				}
			}

			if (seatText.EndsWith(", "))
			{
				seatText = seatText.Substring(0, seatText.Length - 2);
			}

			lblSeats.Text = string.IsNullOrEmpty(seatText) ? "N/A" : seatText;

			// Load Snacks into Cards
			pnlSnacksContainer.Controls.Clear();

			if (snacks != null && snacks.Count > 0)
			{
				foreach (var snack in snacks)
				{
					decimal itemTotal = snack.Value.Price * snack.Value.Qty;
					pnlSnacksContainer.Controls.Add(
						CreateSnackCard(snack.Key, snack.Value.Qty, itemTotal)
					);
				}
			}
			else
			{
				Label emptyLabel = new Label
				{
					Text = "🍿 No snacks selected for this booking.",
					ForeColor = Color.Gray,
					Font = new Font("Segoe UI", 10F, FontStyle.Italic),
					AutoSize = false,
					Size = new Size(390, 50),
					TextAlign = ContentAlignment.MiddleCenter
				};
				pnlSnacksContainer.Controls.Add(emptyLabel);
			}

			// Total Amount
			lblTotal.Text = $"RM {total:F2}";
		}

		private Panel CreateSnackCard(string name, int qty, decimal itemTotal)
		{
			Panel card = new Panel
			{
				Size = new Size(390, 54),
				BackColor = Color.FromArgb(40, 36, 60),
				Margin = new Padding(0, 0, 0, 8)
			};

			Label lblName = new Label
			{
				Text = name,
				Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
				ForeColor = Color.White,
				Location = new Point(10, 6),
				Size = new Size(220, 42),
				TextAlign = ContentAlignment.MiddleLeft,
				AutoEllipsis = true
			};

			Label lblQty = new Label
			{
				Text = $"x{qty}",
				Font = new Font("Segoe UI", 9F, FontStyle.Bold),
				ForeColor = Color.FromArgb(162, 89, 255),
				BackColor = Color.FromArgb(55, 48, 80),
				Location = new Point(238, 14),
				Size = new Size(38, 26),
				TextAlign = ContentAlignment.MiddleCenter
			};

			Label lblPrice = new Label
			{
				Text = $"RM {itemTotal:F2}",
				Font = new Font("Segoe UI", 10F, FontStyle.Bold),
				ForeColor = Color.FromArgb(0, 230, 153),
				Location = new Point(280, 14),
				Size = new Size(100, 26),
				TextAlign = ContentAlignment.MiddleRight
			};

			card.Controls.Add(lblName);
			card.Controls.Add(lblQty);
			card.Controls.Add(lblPrice);

			return card;
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrintPage += PrintDoc_PrintPage;

			PrintPreviewDialog previewDialog = new PrintPreviewDialog
			{
				Document = printDoc,
				Width = 600,
				Height = 800
			};

			previewDialog.ShowDialog();
		}

		private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			Font fontTitle = new Font("Courier New", 12, FontStyle.Bold);
			Font fontBody = new Font("Courier New", 10, FontStyle.Regular);
			float startX = 20;
			float startY = 20;
			float offset = 0;

			string hallDisplayName = (hall != null && !string.IsNullOrEmpty(hall.name)) ? hall.name : "N/A";

			e.Graphics.DrawString("=========================================", fontTitle, Brushes.Black, startX, startY + offset);
			offset += 20;
			e.Graphics.DrawString("           CINEMA OFFICIAL RECEIPT       ", fontTitle, Brushes.Black, startX, startY + offset);
			offset += 20;
			e.Graphics.DrawString("=========================================", fontTitle, Brushes.Black, startX, startY + offset);
			offset += 30;

			e.Graphics.DrawString($"Movie:    {(movie != null ? movie.title : "N/A")}", fontBody, Brushes.Black, startX, startY + offset);
			offset += 20;
			e.Graphics.DrawString($"Showtime: {showtime}", fontBody, Brushes.Black, startX, startY + offset);
			offset += 20;
			e.Graphics.DrawString($"Hall:     {hallDisplayName}", fontBody, Brushes.Black, startX, startY + offset);
			offset += 20;
			e.Graphics.DrawString($"Seats:    {lblSeats.Text}", fontBody, Brushes.Black, startX, startY + offset);
			offset += 25;

			e.Graphics.DrawString("-----------------------------------------", fontBody, Brushes.Black, startX, startY + offset);
			offset += 20;

			if (snacks != null && snacks.Count > 0)
			{
				e.Graphics.DrawString("Snacks & Beverages:", fontBody, Brushes.Black, startX, startY + offset);
				offset += 20;

				foreach (var item in snacks)
				{
					decimal lineTotal = item.Value.Price * item.Value.Qty;
					e.Graphics.DrawString($"  • {item.Key} x{item.Value.Qty} (RM {lineTotal:F2})", fontBody, Brushes.Black, startX, startY + offset);
					offset += 20;
				}
				e.Graphics.DrawString("-----------------------------------------", fontBody, Brushes.Black, startX, startY + offset);
				offset += 20;
			}

			e.Graphics.DrawString($"TOTAL PAID: RM {total:F2}", fontTitle, Brushes.Black, startX, startY + offset);
			offset += 30;
			e.Graphics.DrawString("Thank you for your visit!", fontBody, Brushes.Black, startX, startY + offset);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
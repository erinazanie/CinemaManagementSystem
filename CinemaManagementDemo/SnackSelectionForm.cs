using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaManagementDemo
{
    public partial class SnackSelectionForm : Form
    {
        private decimal ticketTotal = 36.00m; // Example carried over from previous page
        private Dictionary<string, (decimal Price, int Qty)> snackCart = new Dictionary<string, (decimal, int)>();

        public SnackSelectionForm()
        {
            InitializeComponent();
            LoadSnackItems();
            UpdateOrderSummary();
        }

        private void LoadSnackItems()
        {
            pnlSnackGrid.Controls.Clear();

            // Sample snack list
            var snacks = new[]
            {
                new { Name = "🍿 Combo A \n(Popcorn + Drink)", Price = 18.00m },
                new { Name = "🍿 Caramel Popcorn (L)", Price = 14.00m },
                new { Name = "🥤 Soft Drink (L)", Price = 7.00m },
                new { Name = "🧀 Hot Nachos & Cheese", Price = 12.00m },
                new { Name = "🍫 Chocolate Bar", Price = 6.00m },
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

            // Quantity Controls
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

            // Button Event Handlers
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
                    if (qty == 0) snackCart.Remove(name);
                    else snackCart[name] = (price, qty);
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
            decimal snackTotal = 0m;

            lstOrderItems.Items.Add($"Tickets Subtotal: RM {ticketTotal:F2}");
            lstOrderItems.Items.Add("--------------------------------");

            foreach (var item in snackCart)
            {
                decimal itemTotal = item.Value.Price * item.Value.Qty;
                snackTotal += itemTotal;
                lstOrderItems.Items.Add($"{item.Key} x{item.Value.Qty} (RM {itemTotal:F2})");
            }

            decimal grandTotal = ticketTotal + snackTotal;
            lblGrandTotal.Text = $"Total: RM {grandTotal:F2}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Movie Details
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Successful! Enjoy your movie 🍿🎬", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            // Check if the user hasn't selected any snacks
            if (snackCart.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "You haven't selected any snacks or beverages. Are you sure you want to proceed to checkout without snacks?",
                    "No Snacks Selected",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // If user clicks "No", cancel checkout so they can pick snacks
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Proceed to successful checkout
            MessageBox.Show(
                "Booking Successful! Enjoy your movie 🍿🎬",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
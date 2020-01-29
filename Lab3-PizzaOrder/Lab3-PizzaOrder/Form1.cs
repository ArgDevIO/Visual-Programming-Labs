using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_PizzaOrder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void calculateTotal()
		{
			float num = 0f;
			float result = 0f;

			// Size radio buttons
			if (rbSmall.Checked && float.TryParse(tbSizeSmall.Text, out result))
				num += result;
			if (rbMedium.Checked && float.TryParse(tbSizeMedium.Text, out result))
				num += result;
			if (rbLarge.Checked && float.TryParse(tbSizeLarge.Text, out result))
				num += result;

			// Extras check boxes
			if (cbPeppers.Checked && float.TryParse(tbExtrasPeppers.Text, out result))
				num += result;
			if (cbExtraCheese.Checked && float.TryParse(tbExtrasCheese.Text, out result))
				num += result;
			if (cbKetchup.Checked && float.TryParse(tbExtrasKetchup.Text, out result))
				num += result;

			// Drinks
			float.TryParse(tbDrinksSodaTotal.Text, out result);
			num += result;
			float.TryParse(tbDrinksSoftTotal.Text, out result);
			num += result;
			float.TryParse(tbDrinksBeerTotal.Text, out result);
			num += result;

			// Dessert
			float.TryParse(tbDessertPrice.Text, out result);
			num += result;

			tbTotalPayment.Text = num.ToString();
		}

		private void stateChanged(object sender, EventArgs e)
		{
			calculateTotal();
		}

		private void calculateDrinkPrice(TextBox tbQty, TextBox tbPrice, TextBox tbTotal)
		{
			float price = 0f;
			float.TryParse(tbPrice.Text, out price);

			int qty = 0;
			int.TryParse(tbQty.Text, out qty);

			float total = (float)qty * price;
			tbTotal.Text = total.ToString();
		}

		private void drinkTotal_textChanged(object sender, EventArgs e)
		{
			TextBox tbDrinkTotal = sender as TextBox;
			if (tbDrinkTotal.Name.ToLower().Contains("soda"))
				calculateDrinkPrice(tbDrinksSodaQuantity, tbDrinksSodaPrice, tbDrinksSodaTotal);
			else if (tbDrinkTotal.Name.ToLower().Contains("soft"))
				calculateDrinkPrice(tbDrinksSoftQuantity, tbDrinksSoftPrice, tbDrinksSoftTotal);
			else if (tbDrinkTotal.Name.ToLower().Contains("beer"))
				calculateDrinkPrice(tbDrinksBeerQuantity, tbDrinksBeerPrice, tbDrinksBeerTotal);

			calculateTotal();
		}

		private void lbDessert_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (lbDessert.SelectedIndex)
			{
				case 0:
					tbDessertPrice.Text = "80";
					break;
				case 1:
					tbDessertPrice.Text = "120";
					break;
				case 2:
					tbDessertPrice.Text = "160";
					break;
			}
			calculateTotal();
		}

		private void tbDessertPrice_TextChanged(object sender, EventArgs e)
		{
			calculateTotal();
		}

		private void tbTotalPayment_TextChanged(object sender, EventArgs e)
		{
			calculateChange();
		}

		private void calculateChange()
		{
			float totalForPayment = 0f;
			float.TryParse(tbTotalPayment.Text, out totalForPayment);

			float paid = 0f;
			float.TryParse(tbPaid.Text, out paid);

			float change = paid - totalForPayment;
			tbChange.Text = change.ToString();
		}

		private void tbPaid_TextChanged(object sender, EventArgs e)
		{
			calculateChange();
		}

		private void tbChange_TextChanged(object sender, EventArgs e)
		{
			btnOrder.Enabled = !tbChange.Text.Contains("-");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to cancel your order?", "Cancel order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				Application.Exit();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			// Pizza Size
			var selectedPizzaRadioButton = gbSize.Controls.OfType<RadioButton>().First(r => r.Checked);
			sb.Append(selectedPizzaRadioButton.Text.ToUpper()).Append(" PIZZA\n");

			// Extras
			List<CheckBox> selectedExtrasCheckBoxes = gbExtras.Controls.OfType<CheckBox>().Where(cb => cb.Checked).ToList();
			if (selectedExtrasCheckBoxes.Count != 0) 
				sb.Append("--Extras:\n");
			foreach (CheckBox cb in selectedExtrasCheckBoxes)
				sb.Append(cb.Text).Append("\n");

			// Drinks
			List<TextBox> drinksQtyTBs = gbDrinks.Controls.OfType<TextBox>().Where(tb => !tb.Text.Equals("0") && tb.Name.ToLower().Contains("quantity")).ToList();
			if (drinksQtyTBs.Count != 0)
				sb.Append("--Drink:\n");
			foreach (TextBox tb in drinksQtyTBs)
			{
				sb.Append(tb.Text);
				if (tb.Name.Contains("Soda")) sb.Append(" Coca Cola / Fanta / Sprite\n");
				else if (tb.Name.Contains("Soft")) sb.Append(" Apple / Orange juice\n");
				else if (tb.Name.Contains("Beer")) sb.Append(" Beer\n");
			}

			// Dessert
			string selectedDessert = lbDessert.SelectedItem.ToString();
			if (!string.IsNullOrEmpty(selectedDessert))
				sb.Append("--Dessert:\n").Append(selectedDessert);

			MessageBox.Show(sb.ToString(), "Your order", MessageBoxButtons.OK);
		}
	}
}

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
			if (rdSmall.Checked && float.TryParse(tbSizeSmall.Text, out result))
				num += result;
			if (rdMedium.Checked && float.TryParse(tbSizeMedium.Text, out result))
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
	}
}

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

		
	}
}

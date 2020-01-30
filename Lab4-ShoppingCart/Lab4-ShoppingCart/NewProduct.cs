using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ShoppingCart
{
	public partial class NewProduct : Form
	{
		public Product Product { get; set; }
		public NewProduct()
		{
			InitializeComponent();
		}

		private void btnNewAdd_Click(object sender, EventArgs e)
		{
			Product = new Product(tbNewName.Text.Trim(), tbNewCategory.Text.Trim(), int.Parse(tbNewPrice.Text));
			DialogResult = DialogResult.OK;
		}

		private void btnNewCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void tbNewName_Validating(object sender, CancelEventArgs e)
		{
			if (tbNewName.Text.Trim().Length == 0)
			{
				e.Cancel = true;
				errorProviderNewProduct.SetError(tbNewName, "Name required!");
			}
			else
			{
				errorProviderNewProduct.SetError(tbNewName, null);
				e.Cancel = false;
			}
		}
	}
}

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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Product testProduct = new Product("Viva", "Soft Drinks", 65);
			lbProducts.Items.Add(testProduct);

			btnAddtoCart.Enabled = lbProducts.SelectedIndex != -1;
			btnDeleteProduct.Enabled = lbProducts.SelectedIndex != -1;
			btnDeleteFromCart.Enabled = lbCart.SelectedIndex != -1;
			btnClearCart.Enabled = lbCart.Items.Count != 0;
			btnClearProducts.Enabled = lbProducts.Items.Count != 0;

		}

		private void btnAddNewProduct_Click(object sender, EventArgs e)
		{
			NewProduct newProductForm = new NewProduct();
			if (newProductForm.ShowDialog() == DialogResult.OK)
			{
				lbProducts.Items.Add(newProductForm.Product);
				if (btnClearProducts.Enabled == false) btnClearProducts.Enabled = true;
			}
		}

		private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddtoCart.Enabled = lbProducts.SelectedIndex != -1;
			btnDeleteProduct.Enabled = lbProducts.SelectedIndex != -1;
			loadProductDetails();
		}

		private void loadProductDetails()
		{
			tbProductName.Clear();
			tbProductCategory.Clear();
			tbProductPrice.Clear();
			Product product = lbProducts.SelectedItem as Product;
			
			if (product != null)
			{
				tbProductName.Text = product.Name;
				tbProductCategory.Text = product.Category;
				tbProductPrice.Text = string.Format("{0:#.00}", product.Price);
			}
		}

		private void btnAddtoCart_Click(object sender, EventArgs e)
		{
			Product selectedProduct = lbProducts.SelectedItem as Product;
			lbCart.Items.Add(selectedProduct);
			if (btnClearCart.Enabled == false) btnClearCart.Enabled = true;

			tbTotal.Text = (int.Parse(tbTotal.Text) + selectedProduct.Price).ToString();
		}

		private void btnDeleteFromCart_Click(object sender, EventArgs e)
		{
			Product selectedProduct = lbCart.SelectedItem as Product;
			lbCart.Items.RemoveAt(lbCart.SelectedIndex);
			btnClearCart.Enabled = lbCart.Items.Count != 0;

			tbTotal.Text = (int.Parse(tbTotal.Text) - selectedProduct.Price).ToString();
		}

		private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDeleteFromCart.Enabled = lbCart.SelectedIndex != -1;
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
			btnClearProducts.Enabled = lbProducts.Items.Count != 0;
		}

		private void btnClearProducts_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Clear all products from the list?", "Clear Products List", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (lbProducts.SelectedIndex != -1) lbProducts.SetSelected(lbProducts.SelectedIndex, false);
				lbProducts.Items.Clear();
				btnClearProducts.Enabled = false;
				loadProductDetails();
			}
		}

		private void btnClearCart_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Clear all products from the cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (lbCart.SelectedIndex != -1) lbCart.SetSelected(lbCart.SelectedIndex, false);
				lbCart.Items.Clear();
				btnClearCart.Enabled = false;
				tbTotal.Text = "0";
			}
		}
	}
}

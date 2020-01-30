using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ShoppingCart
{
	public class ProductItem
	{
		public Product Product { get; set; }
		public int Qty { get; set; }
		public int TotalPrice { get; set; }

		public ProductItem(Product product, int qty)
		{
			Product = product;
			Qty = qty;
			TotalPrice = qty * product.Price;
		}

		public override string ToString()
		{
			return string.Format("{0} {1:#.0} x  {2:#.0} = {3:#.00}", Product.Name, Qty, Product.Price, TotalPrice);
		}
	}
}

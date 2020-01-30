namespace Lab4_ShoppingCart
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lbProducts = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.tbProductCategory = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClearProducts = new System.Windows.Forms.Button();
			this.btnAddtoCart = new System.Windows.Forms.Button();
			this.btnDeleteFromCart = new System.Windows.Forms.Button();
			this.btnAddNewProduct = new System.Windows.Forms.Button();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.btnClearCart = new System.Windows.Forms.Button();
			this.lbCart = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Products list:";
			// 
			// lbProducts
			// 
			this.lbProducts.FormattingEnabled = true;
			this.lbProducts.Location = new System.Drawing.Point(16, 32);
			this.lbProducts.Name = "lbProducts";
			this.lbProducts.Size = new System.Drawing.Size(250, 329);
			this.lbProducts.TabIndex = 1;
			this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbProductPrice);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbProductCategory);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbProductName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(272, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 180);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Product details:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name:";
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(10, 37);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(234, 20);
			this.tbProductName.TabIndex = 1;
			// 
			// tbProductCategory
			// 
			this.tbProductCategory.Location = new System.Drawing.Point(10, 89);
			this.tbProductCategory.Name = "tbProductCategory";
			this.tbProductCategory.Size = new System.Drawing.Size(234, 20);
			this.tbProductCategory.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Category:";
			// 
			// tbProductPrice
			// 
			this.tbProductPrice.Location = new System.Drawing.Point(10, 140);
			this.tbProductPrice.Name = "tbProductPrice";
			this.tbProductPrice.Size = new System.Drawing.Size(113, 20);
			this.tbProductPrice.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Price:";
			// 
			// btnClearProducts
			// 
			this.btnClearProducts.Location = new System.Drawing.Point(16, 367);
			this.btnClearProducts.Name = "btnClearProducts";
			this.btnClearProducts.Size = new System.Drawing.Size(250, 23);
			this.btnClearProducts.TabIndex = 3;
			this.btnClearProducts.Text = "Clear list of products?";
			this.btnClearProducts.UseVisualStyleBackColor = true;
			this.btnClearProducts.Click += new System.EventHandler(this.btnClearProducts_Click);
			// 
			// btnAddtoCart
			// 
			this.btnAddtoCart.Location = new System.Drawing.Point(272, 218);
			this.btnAddtoCart.Name = "btnAddtoCart";
			this.btnAddtoCart.Size = new System.Drawing.Size(250, 23);
			this.btnAddtoCart.TabIndex = 4;
			this.btnAddtoCart.Text = "Add to Cart >>";
			this.btnAddtoCart.UseVisualStyleBackColor = true;
			this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
			// 
			// btnDeleteFromCart
			// 
			this.btnDeleteFromCart.Location = new System.Drawing.Point(272, 257);
			this.btnDeleteFromCart.Name = "btnDeleteFromCart";
			this.btnDeleteFromCart.Size = new System.Drawing.Size(250, 23);
			this.btnDeleteFromCart.TabIndex = 5;
			this.btnDeleteFromCart.Text = "Delete from Cart";
			this.btnDeleteFromCart.UseVisualStyleBackColor = true;
			this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
			// 
			// btnAddNewProduct
			// 
			this.btnAddNewProduct.Location = new System.Drawing.Point(272, 296);
			this.btnAddNewProduct.Name = "btnAddNewProduct";
			this.btnAddNewProduct.Size = new System.Drawing.Size(250, 23);
			this.btnAddNewProduct.TabIndex = 6;
			this.btnAddNewProduct.Text = "Add new product";
			this.btnAddNewProduct.UseVisualStyleBackColor = true;
			this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Location = new System.Drawing.Point(272, 335);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(250, 23);
			this.btnDeleteProduct.TabIndex = 7;
			this.btnDeleteProduct.Text = "Delete product";
			this.btnDeleteProduct.UseVisualStyleBackColor = true;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// btnClearCart
			// 
			this.btnClearCart.Location = new System.Drawing.Point(528, 367);
			this.btnClearCart.Name = "btnClearCart";
			this.btnClearCart.Size = new System.Drawing.Size(250, 23);
			this.btnClearCart.TabIndex = 10;
			this.btnClearCart.Text = "Clear Cart?";
			this.btnClearCart.UseVisualStyleBackColor = true;
			this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
			// 
			// lbCart
			// 
			this.lbCart.FormattingEnabled = true;
			this.lbCart.Location = new System.Drawing.Point(528, 32);
			this.lbCart.Name = "lbCart";
			this.lbCart.Size = new System.Drawing.Size(250, 290);
			this.lbCart.TabIndex = 9;
			this.lbCart.SelectedIndexChanged += new System.EventHandler(this.lbCart_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(525, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Cart:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(528, 340);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Total:";
			// 
			// tbTotal
			// 
			this.tbTotal.Enabled = false;
			this.tbTotal.Location = new System.Drawing.Point(568, 337);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(210, 20);
			this.tbTotal.TabIndex = 6;
			this.tbTotal.Text = "0";
			this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 406);
			this.Controls.Add(this.tbTotal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnClearCart);
			this.Controls.Add(this.lbCart);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnDeleteProduct);
			this.Controls.Add(this.btnAddNewProduct);
			this.Controls.Add(this.btnDeleteFromCart);
			this.Controls.Add(this.btnAddtoCart);
			this.Controls.Add(this.btnClearProducts);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbProducts);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(816, 445);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(816, 445);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shopping Cart";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbProducts;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbProductCategory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClearProducts;
		private System.Windows.Forms.Button btnAddtoCart;
		private System.Windows.Forms.Button btnDeleteFromCart;
		private System.Windows.Forms.Button btnAddNewProduct;
		private System.Windows.Forms.Button btnDeleteProduct;
		private System.Windows.Forms.Button btnClearCart;
		private System.Windows.Forms.ListBox lbCart;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbTotal;
	}
}


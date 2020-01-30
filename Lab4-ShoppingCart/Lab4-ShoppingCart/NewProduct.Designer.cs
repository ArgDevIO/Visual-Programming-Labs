namespace Lab4_ShoppingCart
{
	partial class NewProduct
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNewName = new System.Windows.Forms.TextBox();
			this.tbNewCategory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNewPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNewAdd = new System.Windows.Forms.Button();
			this.btnNewCancel = new System.Windows.Forms.Button();
			this.errorProviderNewProduct = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderNewProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// tbNewName
			// 
			this.tbNewName.Location = new System.Drawing.Point(16, 30);
			this.tbNewName.Name = "tbNewName";
			this.tbNewName.Size = new System.Drawing.Size(240, 20);
			this.tbNewName.TabIndex = 1;
			this.tbNewName.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewName_Validating);
			// 
			// tbNewCategory
			// 
			this.tbNewCategory.Location = new System.Drawing.Point(16, 84);
			this.tbNewCategory.Name = "tbNewCategory";
			this.tbNewCategory.Size = new System.Drawing.Size(240, 20);
			this.tbNewCategory.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Category:";
			// 
			// tbNewPrice
			// 
			this.tbNewPrice.Location = new System.Drawing.Point(16, 142);
			this.tbNewPrice.Name = "tbNewPrice";
			this.tbNewPrice.Size = new System.Drawing.Size(95, 20);
			this.tbNewPrice.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price";
			// 
			// btnNewAdd
			// 
			this.btnNewAdd.Location = new System.Drawing.Point(16, 181);
			this.btnNewAdd.Name = "btnNewAdd";
			this.btnNewAdd.Size = new System.Drawing.Size(95, 23);
			this.btnNewAdd.TabIndex = 4;
			this.btnNewAdd.Text = "Add";
			this.btnNewAdd.UseVisualStyleBackColor = true;
			this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
			// 
			// btnNewCancel
			// 
			this.btnNewCancel.Location = new System.Drawing.Point(161, 181);
			this.btnNewCancel.Name = "btnNewCancel";
			this.btnNewCancel.Size = new System.Drawing.Size(95, 23);
			this.btnNewCancel.TabIndex = 5;
			this.btnNewCancel.Text = "Cancel";
			this.btnNewCancel.UseVisualStyleBackColor = true;
			this.btnNewCancel.Click += new System.EventHandler(this.btnNewCancel_Click);
			// 
			// errorProviderNewProduct
			// 
			this.errorProviderNewProduct.ContainerControl = this;
			// 
			// NewProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 222);
			this.Controls.Add(this.btnNewCancel);
			this.Controls.Add(this.btnNewAdd);
			this.Controls.Add(this.tbNewPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbNewCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNewName);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(310, 261);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(310, 261);
			this.Name = "NewProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New product";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderNewProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNewName;
		private System.Windows.Forms.TextBox tbNewCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNewPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNewAdd;
		private System.Windows.Forms.Button btnNewCancel;
		private System.Windows.Forms.ErrorProvider errorProviderNewProduct;
	}
}
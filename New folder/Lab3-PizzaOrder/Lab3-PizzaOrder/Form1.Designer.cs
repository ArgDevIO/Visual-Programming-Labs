namespace Lab3_PizzaOrder
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
			this.gbSize = new System.Windows.Forms.GroupBox();
			this.tbSizeLarge = new System.Windows.Forms.TextBox();
			this.tbSizeMedium = new System.Windows.Forms.TextBox();
			this.tbSizeSmall = new System.Windows.Forms.TextBox();
			this.rbLarge = new System.Windows.Forms.RadioButton();
			this.rbMedium = new System.Windows.Forms.RadioButton();
			this.rbSmall = new System.Windows.Forms.RadioButton();
			this.gbExtras = new System.Windows.Forms.GroupBox();
			this.cbKetchup = new System.Windows.Forms.CheckBox();
			this.cbExtraCheese = new System.Windows.Forms.CheckBox();
			this.cbPeppers = new System.Windows.Forms.CheckBox();
			this.tbExtrasKetchup = new System.Windows.Forms.TextBox();
			this.tbExtrasCheese = new System.Windows.Forms.TextBox();
			this.tbExtrasPeppers = new System.Windows.Forms.TextBox();
			this.gbDrinks = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbDrinksBeerPrice = new System.Windows.Forms.TextBox();
			this.tbDrinksSoftPrice = new System.Windows.Forms.TextBox();
			this.tbDrinksSodaPrice = new System.Windows.Forms.TextBox();
			this.tbDrinksBeerTotal = new System.Windows.Forms.TextBox();
			this.tbDrinksSoftTotal = new System.Windows.Forms.TextBox();
			this.tbDrinksSodaTotal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDrinksBeerQuantity = new System.Windows.Forms.TextBox();
			this.tbDrinksSoftQuantity = new System.Windows.Forms.TextBox();
			this.tbDrinksSodaQuantity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbDessertPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lbDessert = new System.Windows.Forms.ListBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tbChange = new System.Windows.Forms.TextBox();
			this.tbPaid = new System.Windows.Forms.TextBox();
			this.tbTotalPayment = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.gbSize.SuspendLayout();
			this.gbExtras.SuspendLayout();
			this.gbDrinks.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbSize
			// 
			this.gbSize.Controls.Add(this.tbSizeLarge);
			this.gbSize.Controls.Add(this.tbSizeMedium);
			this.gbSize.Controls.Add(this.tbSizeSmall);
			this.gbSize.Controls.Add(this.rbLarge);
			this.gbSize.Controls.Add(this.rbMedium);
			this.gbSize.Controls.Add(this.rbSmall);
			this.gbSize.Location = new System.Drawing.Point(13, 13);
			this.gbSize.Name = "gbSize";
			this.gbSize.Size = new System.Drawing.Size(302, 131);
			this.gbSize.TabIndex = 0;
			this.gbSize.TabStop = false;
			this.gbSize.Text = "Size";
			// 
			// tbSizeLarge
			// 
			this.tbSizeLarge.Location = new System.Drawing.Point(189, 93);
			this.tbSizeLarge.Name = "tbSizeLarge";
			this.tbSizeLarge.Size = new System.Drawing.Size(100, 20);
			this.tbSizeLarge.TabIndex = 5;
			this.tbSizeLarge.Text = "500";
			// 
			// tbSizeMedium
			// 
			this.tbSizeMedium.Location = new System.Drawing.Point(189, 56);
			this.tbSizeMedium.Name = "tbSizeMedium";
			this.tbSizeMedium.Size = new System.Drawing.Size(100, 20);
			this.tbSizeMedium.TabIndex = 4;
			this.tbSizeMedium.Text = "300";
			// 
			// tbSizeSmall
			// 
			this.tbSizeSmall.Location = new System.Drawing.Point(189, 19);
			this.tbSizeSmall.Name = "tbSizeSmall";
			this.tbSizeSmall.Size = new System.Drawing.Size(100, 20);
			this.tbSizeSmall.TabIndex = 3;
			this.tbSizeSmall.Text = "200";
			// 
			// rbLarge
			// 
			this.rbLarge.AutoSize = true;
			this.rbLarge.Location = new System.Drawing.Point(6, 93);
			this.rbLarge.Name = "rbLarge";
			this.rbLarge.Size = new System.Drawing.Size(52, 17);
			this.rbLarge.TabIndex = 2;
			this.rbLarge.TabStop = true;
			this.rbLarge.Text = "Large";
			this.rbLarge.UseVisualStyleBackColor = true;
			this.rbLarge.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// rbMedium
			// 
			this.rbMedium.AutoSize = true;
			this.rbMedium.Location = new System.Drawing.Point(6, 56);
			this.rbMedium.Name = "rbMedium";
			this.rbMedium.Size = new System.Drawing.Size(62, 17);
			this.rbMedium.TabIndex = 1;
			this.rbMedium.TabStop = true;
			this.rbMedium.Text = "Medium";
			this.rbMedium.UseVisualStyleBackColor = true;
			this.rbMedium.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// rbSmall
			// 
			this.rbSmall.AutoSize = true;
			this.rbSmall.Location = new System.Drawing.Point(6, 19);
			this.rbSmall.Name = "rbSmall";
			this.rbSmall.Size = new System.Drawing.Size(50, 17);
			this.rbSmall.TabIndex = 0;
			this.rbSmall.TabStop = true;
			this.rbSmall.Text = "Small";
			this.rbSmall.UseVisualStyleBackColor = true;
			this.rbSmall.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// gbExtras
			// 
			this.gbExtras.Controls.Add(this.cbKetchup);
			this.gbExtras.Controls.Add(this.cbExtraCheese);
			this.gbExtras.Controls.Add(this.cbPeppers);
			this.gbExtras.Controls.Add(this.tbExtrasKetchup);
			this.gbExtras.Controls.Add(this.tbExtrasCheese);
			this.gbExtras.Controls.Add(this.tbExtrasPeppers);
			this.gbExtras.Location = new System.Drawing.Point(327, 13);
			this.gbExtras.Name = "gbExtras";
			this.gbExtras.Size = new System.Drawing.Size(302, 131);
			this.gbExtras.TabIndex = 1;
			this.gbExtras.TabStop = false;
			this.gbExtras.Text = "Extras";
			// 
			// cbKetchup
			// 
			this.cbKetchup.AutoSize = true;
			this.cbKetchup.Location = new System.Drawing.Point(7, 93);
			this.cbKetchup.Name = "cbKetchup";
			this.cbKetchup.Size = new System.Drawing.Size(66, 17);
			this.cbKetchup.TabIndex = 2;
			this.cbKetchup.Text = "Ketchup";
			this.cbKetchup.UseVisualStyleBackColor = true;
			this.cbKetchup.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// cbExtraCheese
			// 
			this.cbExtraCheese.AutoSize = true;
			this.cbExtraCheese.Location = new System.Drawing.Point(7, 55);
			this.cbExtraCheese.Name = "cbExtraCheese";
			this.cbExtraCheese.Size = new System.Drawing.Size(88, 17);
			this.cbExtraCheese.TabIndex = 1;
			this.cbExtraCheese.Text = "Extra cheese";
			this.cbExtraCheese.UseVisualStyleBackColor = true;
			this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// cbPeppers
			// 
			this.cbPeppers.AutoSize = true;
			this.cbPeppers.Location = new System.Drawing.Point(7, 19);
			this.cbPeppers.Name = "cbPeppers";
			this.cbPeppers.Size = new System.Drawing.Size(65, 17);
			this.cbPeppers.TabIndex = 0;
			this.cbPeppers.Text = "Peppers";
			this.cbPeppers.UseVisualStyleBackColor = true;
			this.cbPeppers.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// tbExtrasKetchup
			// 
			this.tbExtrasKetchup.Location = new System.Drawing.Point(189, 93);
			this.tbExtrasKetchup.Name = "tbExtrasKetchup";
			this.tbExtrasKetchup.Size = new System.Drawing.Size(100, 20);
			this.tbExtrasKetchup.TabIndex = 5;
			this.tbExtrasKetchup.Text = "20";
			// 
			// tbExtrasCheese
			// 
			this.tbExtrasCheese.Location = new System.Drawing.Point(189, 55);
			this.tbExtrasCheese.Name = "tbExtrasCheese";
			this.tbExtrasCheese.Size = new System.Drawing.Size(100, 20);
			this.tbExtrasCheese.TabIndex = 4;
			this.tbExtrasCheese.Text = "30";
			// 
			// tbExtrasPeppers
			// 
			this.tbExtrasPeppers.Location = new System.Drawing.Point(189, 19);
			this.tbExtrasPeppers.Name = "tbExtrasPeppers";
			this.tbExtrasPeppers.Size = new System.Drawing.Size(100, 20);
			this.tbExtrasPeppers.TabIndex = 3;
			this.tbExtrasPeppers.Text = "40";
			// 
			// gbDrinks
			// 
			this.gbDrinks.Controls.Add(this.label6);
			this.gbDrinks.Controls.Add(this.label5);
			this.gbDrinks.Controls.Add(this.tbDrinksBeerPrice);
			this.gbDrinks.Controls.Add(this.tbDrinksSoftPrice);
			this.gbDrinks.Controls.Add(this.tbDrinksSodaPrice);
			this.gbDrinks.Controls.Add(this.tbDrinksBeerTotal);
			this.gbDrinks.Controls.Add(this.tbDrinksSoftTotal);
			this.gbDrinks.Controls.Add(this.tbDrinksSodaTotal);
			this.gbDrinks.Controls.Add(this.label4);
			this.gbDrinks.Controls.Add(this.tbDrinksBeerQuantity);
			this.gbDrinks.Controls.Add(this.tbDrinksSoftQuantity);
			this.gbDrinks.Controls.Add(this.tbDrinksSodaQuantity);
			this.gbDrinks.Controls.Add(this.label3);
			this.gbDrinks.Controls.Add(this.label2);
			this.gbDrinks.Controls.Add(this.label1);
			this.gbDrinks.Location = new System.Drawing.Point(13, 151);
			this.gbDrinks.Name = "gbDrinks";
			this.gbDrinks.Size = new System.Drawing.Size(616, 145);
			this.gbDrinks.TabIndex = 2;
			this.gbDrinks.TabStop = false;
			this.gbDrinks.Text = "Drink";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(537, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Total";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(379, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Price";
			// 
			// tbDrinksBeerPrice
			// 
			this.tbDrinksBeerPrice.Location = new System.Drawing.Point(346, 113);
			this.tbDrinksBeerPrice.Name = "tbDrinksBeerPrice";
			this.tbDrinksBeerPrice.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksBeerPrice.TabIndex = 8;
			this.tbDrinksBeerPrice.Text = "80";
			this.tbDrinksBeerPrice.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// tbDrinksSoftPrice
			// 
			this.tbDrinksSoftPrice.Location = new System.Drawing.Point(346, 74);
			this.tbDrinksSoftPrice.Name = "tbDrinksSoftPrice";
			this.tbDrinksSoftPrice.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSoftPrice.TabIndex = 7;
			this.tbDrinksSoftPrice.Text = "70";
			this.tbDrinksSoftPrice.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// tbDrinksSodaPrice
			// 
			this.tbDrinksSodaPrice.Location = new System.Drawing.Point(346, 34);
			this.tbDrinksSodaPrice.Name = "tbDrinksSodaPrice";
			this.tbDrinksSodaPrice.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSodaPrice.TabIndex = 6;
			this.tbDrinksSodaPrice.Text = "60";
			this.tbDrinksSodaPrice.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// tbDrinksBeerTotal
			// 
			this.tbDrinksBeerTotal.Location = new System.Drawing.Point(503, 113);
			this.tbDrinksBeerTotal.Name = "tbDrinksBeerTotal";
			this.tbDrinksBeerTotal.ReadOnly = true;
			this.tbDrinksBeerTotal.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksBeerTotal.TabIndex = 11;
			// 
			// tbDrinksSoftTotal
			// 
			this.tbDrinksSoftTotal.Location = new System.Drawing.Point(503, 74);
			this.tbDrinksSoftTotal.Name = "tbDrinksSoftTotal";
			this.tbDrinksSoftTotal.ReadOnly = true;
			this.tbDrinksSoftTotal.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSoftTotal.TabIndex = 10;
			// 
			// tbDrinksSodaTotal
			// 
			this.tbDrinksSodaTotal.Location = new System.Drawing.Point(503, 34);
			this.tbDrinksSodaTotal.Name = "tbDrinksSodaTotal";
			this.tbDrinksSodaTotal.ReadOnly = true;
			this.tbDrinksSodaTotal.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSodaTotal.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(217, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Quantity";
			// 
			// tbDrinksBeerQuantity
			// 
			this.tbDrinksBeerQuantity.Location = new System.Drawing.Point(189, 113);
			this.tbDrinksBeerQuantity.Name = "tbDrinksBeerQuantity";
			this.tbDrinksBeerQuantity.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksBeerQuantity.TabIndex = 5;
			this.tbDrinksBeerQuantity.Text = "0";
			this.tbDrinksBeerQuantity.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// tbDrinksSoftQuantity
			// 
			this.tbDrinksSoftQuantity.Location = new System.Drawing.Point(189, 74);
			this.tbDrinksSoftQuantity.Name = "tbDrinksSoftQuantity";
			this.tbDrinksSoftQuantity.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSoftQuantity.TabIndex = 4;
			this.tbDrinksSoftQuantity.Text = "0";
			this.tbDrinksSoftQuantity.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// tbDrinksSodaQuantity
			// 
			this.tbDrinksSodaQuantity.Location = new System.Drawing.Point(189, 34);
			this.tbDrinksSodaQuantity.Name = "tbDrinksSodaQuantity";
			this.tbDrinksSodaQuantity.Size = new System.Drawing.Size(100, 20);
			this.tbDrinksSodaQuantity.TabIndex = 3;
			this.tbDrinksSodaQuantity.Text = "0";
			this.tbDrinksSodaQuantity.TextChanged += new System.EventHandler(this.drinkTotal_textChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Beer";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apple / Orange juice";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coca Cola / Fanta / Sprite";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnOrder);
			this.groupBox4.Controls.Add(this.btnCancel);
			this.groupBox4.Controls.Add(this.tbDessertPrice);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.lbDessert);
			this.groupBox4.Location = new System.Drawing.Point(13, 302);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(302, 153);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Dessert";
			// 
			// btnOrder
			// 
			this.btnOrder.Enabled = false;
			this.btnOrder.Location = new System.Drawing.Point(169, 86);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(120, 23);
			this.btnOrder.TabIndex = 3;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(169, 118);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tbDessertPrice
			// 
			this.tbDessertPrice.Location = new System.Drawing.Point(169, 47);
			this.tbDessertPrice.Name = "tbDessertPrice";
			this.tbDessertPrice.Size = new System.Drawing.Size(120, 20);
			this.tbDessertPrice.TabIndex = 2;
			this.tbDessertPrice.TextChanged += new System.EventHandler(this.tbDessertPrice_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Dessert Price:";
			// 
			// lbDessert
			// 
			this.lbDessert.FormattingEnabled = true;
			this.lbDessert.Items.AddRange(new object[] {
            "Fruit Salad",
            "Ice Cream",
            "Cake"});
			this.lbDessert.Location = new System.Drawing.Point(7, 20);
			this.lbDessert.Name = "lbDessert";
			this.lbDessert.Size = new System.Drawing.Size(153, 121);
			this.lbDessert.TabIndex = 0;
			this.lbDessert.SelectedIndexChanged += new System.EventHandler(this.lbDessert_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tbChange);
			this.groupBox5.Controls.Add(this.tbPaid);
			this.groupBox5.Controls.Add(this.tbTotalPayment);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Location = new System.Drawing.Point(327, 302);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(302, 153);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Payment";
			// 
			// tbChange
			// 
			this.tbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbChange.Location = new System.Drawing.Point(130, 117);
			this.tbChange.Name = "tbChange";
			this.tbChange.Size = new System.Drawing.Size(159, 26);
			this.tbChange.TabIndex = 5;
			this.tbChange.Text = "0";
			this.tbChange.TextChanged += new System.EventHandler(this.tbChange_TextChanged);
			// 
			// tbPaid
			// 
			this.tbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPaid.Location = new System.Drawing.Point(130, 79);
			this.tbPaid.Name = "tbPaid";
			this.tbPaid.Size = new System.Drawing.Size(159, 26);
			this.tbPaid.TabIndex = 3;
			this.tbPaid.Text = "0";
			this.tbPaid.TextChanged += new System.EventHandler(this.tbPaid_TextChanged);
			// 
			// tbTotalPayment
			// 
			this.tbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotalPayment.Location = new System.Drawing.Point(130, 41);
			this.tbTotalPayment.Name = "tbTotalPayment";
			this.tbTotalPayment.ReadOnly = true;
			this.tbTotalPayment.Size = new System.Drawing.Size(159, 26);
			this.tbTotalPayment.TabIndex = 1;
			this.tbTotalPayment.TextChanged += new System.EventHandler(this.tbTotalPayment_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 123);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Change:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Paid:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 47);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Total for payment:";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnOrder;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(645, 470);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.gbDrinks);
			this.Controls.Add(this.gbExtras);
			this.Controls.Add(this.gbSize);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pizza Order";
			this.gbSize.ResumeLayout(false);
			this.gbSize.PerformLayout();
			this.gbExtras.ResumeLayout(false);
			this.gbExtras.PerformLayout();
			this.gbDrinks.ResumeLayout(false);
			this.gbDrinks.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbSize;
		private System.Windows.Forms.TextBox tbSizeLarge;
		private System.Windows.Forms.TextBox tbSizeMedium;
		private System.Windows.Forms.TextBox tbSizeSmall;
		private System.Windows.Forms.RadioButton rbLarge;
		private System.Windows.Forms.RadioButton rbMedium;
		private System.Windows.Forms.RadioButton rbSmall;
		private System.Windows.Forms.GroupBox gbExtras;
		private System.Windows.Forms.CheckBox cbKetchup;
		private System.Windows.Forms.CheckBox cbExtraCheese;
		private System.Windows.Forms.CheckBox cbPeppers;
		private System.Windows.Forms.TextBox tbExtrasKetchup;
		private System.Windows.Forms.TextBox tbExtrasCheese;
		private System.Windows.Forms.TextBox tbExtrasPeppers;
		private System.Windows.Forms.GroupBox gbDrinks;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbDrinksBeerPrice;
		private System.Windows.Forms.TextBox tbDrinksSoftPrice;
		private System.Windows.Forms.TextBox tbDrinksSodaPrice;
		private System.Windows.Forms.TextBox tbDrinksBeerTotal;
		private System.Windows.Forms.TextBox tbDrinksSoftTotal;
		private System.Windows.Forms.TextBox tbDrinksSodaTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDrinksBeerQuantity;
		private System.Windows.Forms.TextBox tbDrinksSoftQuantity;
		private System.Windows.Forms.TextBox tbDrinksSodaQuantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbDessertPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox lbDessert;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox tbChange;
		private System.Windows.Forms.TextBox tbPaid;
		private System.Windows.Forms.TextBox tbTotalPayment;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
	}
}


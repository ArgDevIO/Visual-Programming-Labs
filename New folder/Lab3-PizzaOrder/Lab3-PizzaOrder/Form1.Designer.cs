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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbSizeLarge = new System.Windows.Forms.TextBox();
			this.tbSizeMedium = new System.Windows.Forms.TextBox();
			this.tbSizeSmall = new System.Windows.Forms.TextBox();
			this.rbLarge = new System.Windows.Forms.RadioButton();
			this.rdMedium = new System.Windows.Forms.RadioButton();
			this.rdSmall = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbKetchup = new System.Windows.Forms.CheckBox();
			this.cbExtraCheese = new System.Windows.Forms.CheckBox();
			this.cbPeppers = new System.Windows.Forms.CheckBox();
			this.tbExtrasKetchup = new System.Windows.Forms.TextBox();
			this.tbExtrasCheese = new System.Windows.Forms.TextBox();
			this.tbExtrasPeppers = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tbChange = new System.Windows.Forms.TextBox();
			this.tbPaid = new System.Windows.Forms.TextBox();
			this.tbTotalPayment = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbSizeLarge);
			this.groupBox1.Controls.Add(this.tbSizeMedium);
			this.groupBox1.Controls.Add(this.tbSizeSmall);
			this.groupBox1.Controls.Add(this.rbLarge);
			this.groupBox1.Controls.Add(this.rdMedium);
			this.groupBox1.Controls.Add(this.rdSmall);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(302, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Size";
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
			// rdMedium
			// 
			this.rdMedium.AutoSize = true;
			this.rdMedium.Location = new System.Drawing.Point(6, 56);
			this.rdMedium.Name = "rdMedium";
			this.rdMedium.Size = new System.Drawing.Size(62, 17);
			this.rdMedium.TabIndex = 1;
			this.rdMedium.TabStop = true;
			this.rdMedium.Text = "Medium";
			this.rdMedium.UseVisualStyleBackColor = true;
			this.rdMedium.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// rdSmall
			// 
			this.rdSmall.AutoSize = true;
			this.rdSmall.Location = new System.Drawing.Point(6, 19);
			this.rdSmall.Name = "rdSmall";
			this.rdSmall.Size = new System.Drawing.Size(50, 17);
			this.rdSmall.TabIndex = 0;
			this.rdSmall.TabStop = true;
			this.rdSmall.Text = "Small";
			this.rdSmall.UseVisualStyleBackColor = true;
			this.rdSmall.CheckedChanged += new System.EventHandler(this.stateChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbKetchup);
			this.groupBox2.Controls.Add(this.cbExtraCheese);
			this.groupBox2.Controls.Add(this.cbPeppers);
			this.groupBox2.Controls.Add(this.tbExtrasKetchup);
			this.groupBox2.Controls.Add(this.tbExtrasCheese);
			this.groupBox2.Controls.Add(this.tbExtrasPeppers);
			this.groupBox2.Location = new System.Drawing.Point(327, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(302, 131);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Extras";
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.tbDrinksBeerPrice);
			this.groupBox3.Controls.Add(this.tbDrinksSoftPrice);
			this.groupBox3.Controls.Add(this.tbDrinksSodaPrice);
			this.groupBox3.Controls.Add(this.tbDrinksBeerTotal);
			this.groupBox3.Controls.Add(this.tbDrinksSoftTotal);
			this.groupBox3.Controls.Add(this.tbDrinksSodaTotal);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.tbDrinksBeerQuantity);
			this.groupBox3.Controls.Add(this.tbDrinksSoftQuantity);
			this.groupBox3.Controls.Add(this.tbDrinksSodaQuantity);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(13, 151);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(616, 145);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Drink";
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
			this.groupBox4.Controls.Add(this.listBox1);
			this.groupBox4.Location = new System.Drawing.Point(13, 302);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(302, 153);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Dessert";
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(169, 86);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(120, 23);
			this.btnOrder.TabIndex = 3;
			this.btnOrder.Text = "Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(169, 118);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// tbDessertPrice
			// 
			this.tbDessertPrice.Location = new System.Drawing.Point(169, 47);
			this.tbDessertPrice.Name = "tbDessertPrice";
			this.tbDessertPrice.Size = new System.Drawing.Size(120, 20);
			this.tbDessertPrice.TabIndex = 2;
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
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Fruit Salad",
            "Ice Cream",
            "Cake"});
			this.listBox1.Location = new System.Drawing.Point(7, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(153, 121);
			this.listBox1.TabIndex = 0;
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
			// 
			// tbPaid
			// 
			this.tbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPaid.Location = new System.Drawing.Point(130, 79);
			this.tbPaid.Name = "tbPaid";
			this.tbPaid.Size = new System.Drawing.Size(159, 26);
			this.tbPaid.TabIndex = 3;
			// 
			// tbTotalPayment
			// 
			this.tbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotalPayment.Location = new System.Drawing.Point(130, 41);
			this.tbTotalPayment.Name = "tbTotalPayment";
			this.tbTotalPayment.ReadOnly = true;
			this.tbTotalPayment.Size = new System.Drawing.Size(159, 26);
			this.tbTotalPayment.TabIndex = 1;
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 470);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Pizza Order";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbSizeLarge;
		private System.Windows.Forms.TextBox tbSizeMedium;
		private System.Windows.Forms.TextBox tbSizeSmall;
		private System.Windows.Forms.RadioButton rbLarge;
		private System.Windows.Forms.RadioButton rdMedium;
		private System.Windows.Forms.RadioButton rdSmall;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox cbKetchup;
		private System.Windows.Forms.CheckBox cbExtraCheese;
		private System.Windows.Forms.CheckBox cbPeppers;
		private System.Windows.Forms.TextBox tbExtrasKetchup;
		private System.Windows.Forms.TextBox tbExtrasCheese;
		private System.Windows.Forms.TextBox tbExtrasPeppers;
		private System.Windows.Forms.GroupBox groupBox3;
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox tbChange;
		private System.Windows.Forms.TextBox tbPaid;
		private System.Windows.Forms.TextBox tbTotalPayment;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
	}
}


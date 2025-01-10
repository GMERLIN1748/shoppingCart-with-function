namespace shoppingCart_with_function
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbGreenTeaQuantity = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeePrice = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            tbNoodlePrice = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaQuantity = new TextBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            rbDiscountDrink = new CheckBox();
            rbDiscountAll = new CheckBox();
            rbDiscountFood = new CheckBox();
            Total = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtTotal = new TextBox();
            txt10 = new TextBox();
            txt20 = new TextBox();
            txt50 = new TextBox();
            txt100 = new TextBox();
            txt500 = new TextBox();
            text1000 = new TextBox();
            txtChange = new TextBox();
            txtCash = new TextBox();
            txt5 = new TextBox();
            txt1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGreenTeaQuantity);
            groupBox1.Controls.Add(tbCoffeeQuantity);
            groupBox1.Controls.Add(tbGreenTeaPrice);
            groupBox1.Controls.Add(tbCoffeePrice);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(25, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(262, 54);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 8;
            tbGreenTeaQuantity.TextChanged += textBox4_TextChanged;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(262, 23);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 7;
            tbCoffeeQuantity.TextChanged += textBox3_TextChanged;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(122, 53);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 6;
            tbGreenTeaPrice.TextChanged += textBox2_TextChanged;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(122, 23);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 5;
            tbCoffeePrice.TextChanged += textBox1_TextChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "GreenTea";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Coffee";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbNoodlePrice);
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Controls.Add(tbNoodleQuantity);
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Location = new Point(25, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 114);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(122, 21);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(125, 27);
            tbNoodlePrice.TabIndex = 9;
            tbNoodlePrice.TextChanged += textBox5_TextChanged;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(122, 56);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(125, 27);
            tbPizzaPrice.TabIndex = 10;
            tbPizzaPrice.TextChanged += textBox6_TextChanged;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(262, 21);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(125, 27);
            tbNoodleQuantity.TabIndex = 11;
            tbNoodleQuantity.TextChanged += textBox7_TextChanged;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(262, 54);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(125, 27);
            tbPizzaQuantity.TabIndex = 12;
            tbPizzaQuantity.TextChanged += textBox8_TextChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 26);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 24);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Noodle";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 56);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(65, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Pizza";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(rbDiscountDrink);
            groupBox3.Controls.Add(rbDiscountAll);
            groupBox3.Controls.Add(rbDiscountFood);
            groupBox3.Location = new Point(25, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(438, 160);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discount";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(368, 26);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 15;
            label12.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(368, 60);
            label13.Name = "label13";
            label13.Size = new Size(21, 20);
            label13.TabIndex = 16;
            label13.Text = "%";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(368, 92);
            label14.Name = "label14";
            label14.Size = new Size(21, 20);
            label14.TabIndex = 17;
            label14.Text = "%";
            label14.Click += label14_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 27);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox11_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 27);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox10_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox9_TextChanged;
            // 
            // rbDiscountDrink
            // 
            rbDiscountDrink.AutoSize = true;
            rbDiscountDrink.Location = new Point(122, 88);
            rbDiscountDrink.Name = "rbDiscountDrink";
            rbDiscountDrink.Size = new Size(65, 24);
            rbDiscountDrink.TabIndex = 10;
            rbDiscountDrink.Text = "Food";
            rbDiscountDrink.UseVisualStyleBackColor = true;
            rbDiscountDrink.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // rbDiscountAll
            // 
            rbDiscountAll.AutoSize = true;
            rbDiscountAll.Location = new Point(122, 29);
            rbDiscountAll.Name = "rbDiscountAll";
            rbDiscountAll.Size = new Size(49, 24);
            rbDiscountAll.TabIndex = 8;
            rbDiscountAll.Text = "All";
            rbDiscountAll.UseVisualStyleBackColor = true;
            rbDiscountAll.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // rbDiscountFood
            // 
            rbDiscountFood.AutoSize = true;
            rbDiscountFood.Location = new Point(122, 60);
            rbDiscountFood.Name = "rbDiscountFood";
            rbDiscountFood.Size = new Size(93, 24);
            rbDiscountFood.TabIndex = 9;
            rbDiscountFood.Text = "Beverage";
            rbDiscountFood.UseVisualStyleBackColor = true;
            rbDiscountFood.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(646, 44);
            Total.Name = "Total";
            Total.Size = new Size(42, 20);
            Total.TabIndex = 3;
            Total.Text = "Total";
            // 
            // button1
            // 
            button1.Location = new Point(499, 35);
            button1.Name = "button1";
            button1.Size = new Size(131, 386);
            button1.TabIndex = 4;
            button1.Text = "Check Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 79);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Cash";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Change";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(646, 152);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(646, 187);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 8;
            label5.Text = "500";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(646, 221);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 9;
            label6.Text = "100";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(646, 253);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 10;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(646, 290);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 11;
            label8.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(646, 322);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 12;
            label9.Text = "10";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(646, 357);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 13;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(646, 401);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 14;
            label11.Text = "1";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(707, 37);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // txt10
            // 
            txt10.Location = new Point(707, 321);
            txt10.Name = "txt10";
            txt10.Size = new Size(125, 27);
            txt10.TabIndex = 15;
            txt10.TextChanged += textBox13_TextChanged;
            // 
            // txt20
            // 
            txt20.Location = new Point(707, 287);
            txt20.Name = "txt20";
            txt20.Size = new Size(125, 27);
            txt20.TabIndex = 16;
            txt20.TextChanged += txt20_TextChanged;
            // 
            // txt50
            // 
            txt50.Location = new Point(707, 249);
            txt50.Name = "txt50";
            txt50.Size = new Size(125, 27);
            txt50.TabIndex = 17;
            txt50.TextChanged += txt50_TextChanged;
            // 
            // txt100
            // 
            txt100.Location = new Point(707, 216);
            txt100.Name = "txt100";
            txt100.Size = new Size(125, 27);
            txt100.TabIndex = 18;
            txt100.TextChanged += txt100_TextChanged;
            // 
            // txt500
            // 
            txt500.Location = new Point(707, 183);
            txt500.Name = "txt500";
            txt500.Size = new Size(125, 27);
            txt500.TabIndex = 19;
            txt500.TextChanged += txt500_TextChanged;
            // 
            // text1000
            // 
            text1000.Location = new Point(707, 148);
            text1000.Name = "text1000";
            text1000.Size = new Size(125, 27);
            text1000.TabIndex = 20;
            text1000.TextChanged += textBox18_TextChanged;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(707, 115);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(125, 27);
            txtChange.TabIndex = 21;
            txtChange.TextChanged += textBox19_TextChanged;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(707, 76);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(125, 27);
            txtCash.TabIndex = 22;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // txt5
            // 
            txt5.Location = new Point(707, 357);
            txt5.Name = "txt5";
            txt5.Size = new Size(125, 27);
            txt5.TabIndex = 23;
            txt5.TextChanged += textBox21_TextChanged;
            // 
            // txt1
            // 
            txt1.Location = new Point(707, 398);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 24;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 467);
            Controls.Add(txt1);
            Controls.Add(txt5);
            Controls.Add(txtCash);
            Controls.Add(txtChange);
            Controls.Add(text1000);
            Controls.Add(txt500);
            Controls.Add(txt100);
            Controls.Add(txt50);
            Controls.Add(txt20);
            Controls.Add(txt10);
            Controls.Add(txtTotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Total);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label Total;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox rbDiscountAll;
        private CheckBox rbDiscountFood;
        private Button button1;
        private CheckBox rbDiscountDrink;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodlePrice;
        private TextBox tbGreenTeaQuantity;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeePrice;
        private TextBox tbPizzaQuantity;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtTotal;
        private TextBox txt10;
        private TextBox txt20;
        private TextBox txt50;
        private TextBox txt100;
        private TextBox txt500;
        private TextBox text1000;
        private TextBox txtChange;
        private TextBox txtCash;
        private TextBox txt5;
        private TextBox txt1;
    }
}

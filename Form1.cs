namespace shoppingCart_with_function
{
    public partial class Form1 : Form
    {
        private object tbTotal;

        public Form1()
        {
            InitializeComponent();
            txtTotal.Text = "0";
            txtCash.Text = "0";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int noodleQuantity, pizzaQuantity, drinkQuantity;
            double noodlePrice, pizzaPrice, drinkPrice, totalFood, totalDrink, total;

            if (int.TryParse(tbNoodleQuantity.Text, out noodleQuantity) &&
                int.TryParse(tbPizzaQuantity.Text, out pizzaQuantity) &&
                int.TryParse(tbCoffeeQuantity.Text, out drinkQuantity) &&
                int.TryParse(tbGreenTeaQuantity.Text, out drinkQuantity) &&
                double.TryParse(tbNoodlePrice.Text, out noodlePrice) &&
                double.TryParse(tbPizzaPrice.Text, out pizzaPrice) &&
                double.TryParse(tbCoffeePrice.Text, out pizzaPrice) &&
                double.TryParse(tbGreenTeaPrice.Text, out drinkPrice))
            {
                totalFood = (noodleQuantity * noodlePrice) + (pizzaQuantity * pizzaPrice);
                totalDrink = drinkQuantity * drinkPrice;
                total = totalFood + totalDrink;

                double discountPercentage = 10;
                double totalAfterDiscount = total;

                if (rbDiscountAll.Checked)
                {
                    totalAfterDiscount = CalculateDiscount(total, discountPercentage);
                }
                else if (rbDiscountFood.Checked)
                {
                    totalAfterDiscount = CalculateDiscount(totalFood, discountPercentage) + totalDrink;
                }
                else if (rbDiscountDrink.Checked)
                {
                    totalAfterDiscount = totalFood + CalculateDiscount(totalDrink, discountPercentage);
                }

                txtTotal.Text = totalAfterDiscount.ToString("F2");

                double cashPaid;
                if (double.TryParse(txtCash.Text, out cashPaid))
                {
                    double change = cashPaid - totalAfterDiscount;
                    txtChange.Text = change.ToString("F2");

                    CalculateChangeDenominations(change);
                }
            }
        }

        private double CalculateDiscount(double total, double discountPercentage)
        {
            double discount = total * (discountPercentage / 100);
            return total - discount;
        }

        private void CalculateChangeDenominations(double change)
        {
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] textBoxes = { text1000, txt500, txt100, txt50, txt20, txt10, txt5, txt1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(change / denominations[i]);
                change %= denominations[i];
                textBoxes[i].Text = count.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1000_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

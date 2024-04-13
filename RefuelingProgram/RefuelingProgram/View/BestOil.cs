using RefuelingProgram.Presenter;

namespace RefuelingProgram
{
    public partial class BestOil : Form
    {
        public PricePresenter Presenter { get; set; }
        delegate void ChangeFuelInfo(object sender, EventArgs e);
        public BestOil(PricePresenter presenter)
        {
            InitializeComponent();
            Presenter = presenter;
            textBoxPriceHotDog.Text = Presenter.price.HotDog.ToString();
            textBoxPriceHamburger.Text = Presenter.price.Hamburger.ToString();
            textBoxPriceFrenchFries.Text = Presenter.price.FrenchFries.ToString();
            textBoxPriceCola.Text = Presenter.price.Cola.ToString();
            buttonPay.Click += checkBoxHotDog_Click;
            buttonPay.Click += checkBoxHamburger_Click;
            buttonPay.Click += checkBoxFrenchFries_Click;
            buttonPay.Click += checkBoxCola_Click;
        }

        private void checkBoxHotDog_Click(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked == true)
            {
                numericUpDownHotDog.Enabled = true;
            }
            else
            {
                numericUpDownHotDog.Enabled = false;
                numericUpDownHotDog.Value = 0;
            }
        }

        private void checkBoxHamburger_Click(object sender, EventArgs e)
        {
            if (checkBoxHamburger.Checked == true)
            {
                numericUpDownHamburger.Enabled = true;
            }
            else
            {
                numericUpDownHamburger.Enabled = false;
                numericUpDownHamburger.Value = 0;
            }
        }

        private void checkBoxFrenchFries_Click(object sender, EventArgs e)
        {
            if (checkBoxFrenchFries.Checked == true)
            {
                numericUpDownFrenchFries.Enabled = true;
            }
            else
            {
                numericUpDownFrenchFries.Enabled = false;
                numericUpDownFrenchFries.Value = 0;
            }
        }

        private void checkBoxCola_Click(object sender, EventArgs e)
        {
            if (checkBoxCola.Checked == true)
            {
                numericUpDownCola.Enabled = true;
            }
            else
            {
                numericUpDownCola.Enabled = false;
                numericUpDownCola.Value = 0;
            }
        }

        private void radioButtonCapacity_Click(object sender, EventArgs e)
        {
            if (radioButtonCapacity.Checked == true)
            {
                textBoxLiters.Enabled = true;
                textBoxFuelSum.Enabled = false;
                textBoxFuelSum.Text = string.Empty;
            }
        }

        private void radioButtonSum_Click(object sender, EventArgs e)
        {
            if (radioButtonSum.Checked == true)
            {
                textBoxLiters.Enabled = false;
                textBoxLiters.Text = string.Empty;
                textBoxFuelSum.Enabled = true;
            }
        }

        public void ChangeInfo(object sender, EventArgs e)
        {
            ChangeFuelInfo change;
            if (radioButtonCapacity.Checked == true)
            {
                change = textBoxLiters_TextChanged;
                change(sender, EventArgs.Empty);
            }
            else
            {
                change = textBoxSum_TextChanged;
                change(sender, EventArgs.Empty);
            }
        }
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fuel = comboBoxFuel.Text;

            switch (fuel)
            {
                case "92":
                    textBoxFuelPrice.Text = Presenter.price.Fuel92.ToString();
                    ChangeInfo(sender, EventArgs.Empty);
                    break;

                case "95":
                    textBoxFuelPrice.Text = Presenter.price.Fuel95.ToString();
                    ChangeInfo(sender, EventArgs.Empty);
                    break;

                case "98":
                    textBoxFuelPrice.Text = Presenter.price.Fuel98.ToString();
                    ChangeInfo(sender, EventArgs.Empty);
                    break;

                case "Diesel":
                    textBoxFuelPrice.Text = Presenter.price.Diesel.ToString();
                    ChangeInfo(sender, EventArgs.Empty);
                    break;

                case "Gas":
                    textBoxFuelPrice.Text = Presenter.price.Gas.ToString();
                    ChangeInfo(sender, EventArgs.Empty);
                    break;
            }
        }

        private void numericUpDownHotDog_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDownHotDog.Value;
            float price = Convert.ToSingle(textBoxPriceHotDog.Text);
            labelMenuPrice.Text = Presenter.MenuOperation(price, count).ToString();
            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        private void numericUpDownHamburger_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDownHamburger.Value;
            float price = Convert.ToSingle(textBoxPriceHamburger.Text);
            labelMenuPrice.Text = Presenter.MenuOperation(price, count).ToString();
            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        private void numericUpDownFrenchFries_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDownFrenchFries.Value;
            float price = Convert.ToSingle(textBoxPriceFrenchFries.Text);
            labelMenuPrice.Text = Presenter.MenuOperation(price, count).ToString();
            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        private void numericUpDownCola_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDownCola.Value;
            float price = Convert.ToSingle(textBoxPriceCola.Text);
            labelMenuPrice.Text = Presenter.MenuOperation(price, count).ToString();
            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        private void textBoxLiters_TextChanged(object sender, EventArgs e)
        {
            int liters;
            string fuel = comboBoxFuel.Text;
            try
            {
                if (textBoxLiters.Text == string.Empty)
                {
                    liters = 0;
                }
                else
                {
                    liters = Convert.ToInt32(textBoxLiters.Text);
                    if (liters > 100) throw new Exception("Max liters: 100");
                }

                labelLitersValue.Text = liters.ToString();
                labelFuelPrice.Text = Presenter.PriceCalculation(liters, fuel).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLiters.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLiters.Text = string.Empty;
            }

            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            int price;
            string fuel = comboBoxFuel.Text;
            try
            {
                if (textBoxFuelSum.Text == string.Empty)
                {
                    price = 0;
                }
                else
                {
                    price = Convert.ToInt32(textBoxFuelSum.Text);
                }

                labelFuelPrice.Text = price.ToString();
                if (Presenter.LitersCalculation(price, fuel) > 100)
                {
                    throw new Exception("Max liters: 100");
                }
                else
                {
                    labelLitersValue.Text = Presenter.LitersCalculation(price, fuel).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFuelSum.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFuelSum.Text = string.Empty;
            }

            labelTotalPayment.Text = Presenter.TotalSum().ToString();
        }

        public void ClearInfo()
        {
            radioButtonCapacity.Checked = false;
            textBoxLiters.Text = string.Empty;
            textBoxLiters.Enabled = false;
            radioButtonSum.Checked = false;
            textBoxFuelSum.Text = string.Empty;
            textBoxFuelSum.Enabled = false;
            checkBoxHotDog.Checked = false;
            checkBoxHamburger.Checked = false;
            checkBoxFrenchFries.Checked = false;
            checkBoxCola.Checked = false;
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            Presenter.RevenuePerDay();
            MessageBox.Show("Success!");
            ClearInfo();
        }

        private void BestOil_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("REVENUE PER DAY: " + Math.Round(Presenter.price.RevenuePerDay, 2).ToString() + " AZN", "Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
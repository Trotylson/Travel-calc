using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double kilometersDifference;
        public double usedFuel;
        public double sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int meter1 = int.Parse(meterTextBox.Text);
                int meter2 = int.Parse(meter2TextBox.Text);
                double fuelPrice = double.Parse(fuelValueTextBox.Text);
                double fuelUsage = double.Parse(fuelUsageTextBox.Text);
                

                if (meter1 <= meter2)
                {
                    kilometersDifference = meter2 - meter1;
                    traveledSumLabel.Text = kilometersDifference.ToString() + " km";

                    if (fuelPrice > 0 && fuelUsage > 0)
                    {
                        fuelUsage = fuelUsage / 100;
                        fuelUsageLabel.Text = fuelUsage.ToString() + "  l / 1 km";

                        usedFuel = kilometersDifference * fuelUsage;
                        usedFuelLabel.Text = usedFuel.ToString() + "  l";

                        sum = usedFuel * fuelPrice;
                        sumLabel.Text = sum.ToString() + " zł";
                    }
                    else
                    {
                        MessageBox.Show("Podaj wartość paliwa za litr!");
                        fuelValueTextBox.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Przebieg po zdaniu pojazdu nie może być " +
                        "mniejszy od przebiegu przed jego wypożyczeniem!");
                    meterTextBox.Clear();
                    meter2TextBox.Clear();
                    
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd wartości pola.", "ERROR");
                return;
            }
        }










        //-------------------------------------------------------------------------------
        // unused Form1 codes
        //-------------------------------------------------------------------------------
        private void meter2TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program zaprojektowany i stworzony przez Damian Jeździkowski.", "Dziękuję ;)");
        }
    }
}

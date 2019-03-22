using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fatbutton_Click(object sender, EventArgs e)
        {
            double fat;
            double value;
            fat = double.Parse(fattextbox.Text);
            value = FatCalorise(fat);
            MessageBox.Show("the number of calorise from" + "fat are" + value);

        }
        private double FatCalorise (double fat)
        {
            return (fat * 9);
        }
        private void fattextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void carbstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void carbsbutton_Click(object sender, EventArgs e)
        {
            double carbs;
            double cal;
            carbs = double.Parse(carbstextbox.Text);
            cal = CarbsCalorise(carbs);
            MessageBox.Show(" the number of calorise from" + "carbs are" + cal);

           
        }
        private double CarbsCalorise(double fat)
        {
            return (fat * 4);

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

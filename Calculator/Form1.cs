using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double data = 0;
        String operate = "";
        bool endinput = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((ResultBox.Text == "0")||(endinput))
                ResultBox.Clear();
            endinput = false;
            Button b = (Button)sender;
            ResultBox.Text = ResultBox.Text + b.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void Operator_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operate = b.Text;
            data = double.Parse(ResultBox.Text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            endinput = true;
            showme.Text = data + " " + operate;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            showme.Text = "";
            switch (operate)
            {
                case "+":
                    ResultBox.Text=(data + Convert.ToDouble(ResultBox.Text)).ToString();
                    break;
                case "-":
                    ResultBox.Text = (data - Convert.ToDouble(ResultBox.Text)).ToString();
                    break;
                case "*":
                    ResultBox.Text = (data * Convert.ToDouble(ResultBox.Text)).ToString();
                    break;
                case "/":
                    ResultBox.Text = (data / Convert.ToDouble(ResultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            data = 0;
        }
    }
}

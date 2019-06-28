using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonMyClick(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            RESULTBOX.Text = RESULTBOX.Text + but.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            string text = textBoxUserInput.Text;
            if(text != null)
            {
                textBoxFormattedString.Text = c.Uppercase(text);
                textBoxVowels.Text = c.VowelCount(text);
            }
            
        }
    }
}

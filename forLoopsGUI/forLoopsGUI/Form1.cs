using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forLoopsGUI
{
    public partial class Fpizza : Form
    {
        public Fpizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumPizza = Convert.ToInt32(txtNumPizza.Text);
            for (int i = 0; i < NumPizza; ++i)
            {
                amountOfPizza.Text += "there is no Pizza you have been beaned\n";
            }
            if (NumPizza == 0)
            {
                Console.WriteLine("You know too much");
            }
            else
            {
                Console.WriteLine("your real funy guy aren't you");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebForms3
{
    public partial class RadioButtons : Form
    {
        public RadioButtons()
        {
            InitializeComponent();
        }
        RadioButton E = new RadioButton();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input;
            if (Rdbtn1.Checked == false || Rdbtn2.Checked == false || Rdbtn3.Checked == false || Rdbtn4.Checked == false)
            {
                E.Hide();
            }
            else
            {
                if(Rdbtn1.Checked == true)
                {
                    input = Rdbtn1.Text;
                    MessageBox.Show(input);
                }
                else if (Rdbtn2.Checked == true)
                {
                    input = Rdbtn2.Text;
                    MessageBox.Show(input);
                }
                else if (Rdbtn3.Checked == true)
                {
                    input = Rdbtn3.Text;
                    MessageBox.Show(input);
                }
                else
                {
                    input = Rdbtn4.Text;
                    MessageBox.Show(input);
                }
            }
        }
    }
}

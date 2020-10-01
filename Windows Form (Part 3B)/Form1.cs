using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form__Part_3B_
{

    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtINPUT.Text;
            lblMessage.Text = "Howdy " + name + "!";
            lblMessage.Visible = true;

        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        { }
            
            }

        }

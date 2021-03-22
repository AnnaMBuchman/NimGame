using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimGame_WinForms
{
    public partial class Form1 : Form
    {
        public int numberOfStacks = 3;
        public int numberOfElements = 3;
        public bool ifHumanStarts = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberElements_ValueChanged(object sender, EventArgs e)
        {
            numberOfElements = (int)numberElements.Value;
        }

        private void stacksNumber_ValueChanged(object sender, EventArgs e)
        {
            numberOfStacks = (int) stacksNumber.Value;
        }

        private void humanOrComputer_SelectedItemChanged(object sender, EventArgs e)
        {
            if (humanOrComputer.SelectedIndex == 0)
                ifHumanStarts = true;
            else
                ifHumanStarts = false;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(numberOfStacks,numberOfElements, this);
            form2.ShowDialog();
            
        }
    }
}

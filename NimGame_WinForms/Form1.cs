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
        List<int> _scores = new List<int>();
        private int strategy = 0;
        public Form1()
        {
            InitializeComponent();
            listNumber.Hide();
            add.Hide();
            listBox1.Hide();
            Clear.Hide();
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
            if(EqualNumber.SelectedIndex==1)
            {
                if(_scores.Count< numberOfStacks)
                {
                    MessageBox.Show("Not enough stacks heights");
                    return;
                }
                else if (_scores.Count > numberOfStacks)
                {
                    MessageBox.Show("To many stacks heights");
                    return;
                }
            }
            this.Hide();            
            Form2 form2 = new Form2(numberOfStacks,numberOfElements, this, ifHumanStarts,_scores, strategy);
            form2.ShowDialog();
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (EqualNumber.SelectedIndex == 0)
            {
                numberElements.Show();
                listNumber.Hide();
                listBox1.Hide();
                add.Hide();
                Clear.Hide();
            }
            else
            {
                numberElements.Hide();
                listNumber.Show();
                add.Show();
                listBox1.Show();
                Clear.Show();
            }
        }

        private void listNumber_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (listNumber.Text != ""&&!int.TryParse(listNumber.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int _score = int.TryParse(listNumber.Text, out int converted) ? converted : 0; // Correct Way Of Handling As Mentioned In Comments
                _scores.Add(_score);
                listBox1.Items.Add(_score);
                listNumber.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _scores.Clear();
        }

        private void strategyCompuuter_SelectedItemChanged(object sender, EventArgs e)
        {
            strategy = strategyCompuuter.SelectedIndex;
        }
    }
}

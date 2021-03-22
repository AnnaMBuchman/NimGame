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
    public partial class Form2 : Form
    {
        private int numberOfStacks;
        private int numberOfElements;
        private List<Stack> stacks;
        private int numberWhichStack=0;
        private int numberElemenetsTaken = 1;
        public Form2(int numberOfStacks, int numberOfElements)
        {
            InitializeComponent();
            this.numberOfStacks = numberOfStacks;
            this.numberOfElements = numberOfElements;
            whichStack.Maximum = numberOfStacks;
            generateStacks();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.BackColor = Color.Gray;
            Take.BackColor = Color.Tomato;
        }
        private void generateStacks()
        {
            stacks = new List<Stack>();
            for(int i =0;i< numberOfStacks;i++)
            {
                stacks.Add(new Stack(i, numberOfElements));
            }
        }

        private void whichStack_ValueChanged(object sender, EventArgs e)
        {
            numberWhichStack = (int)whichStack.Value-1;
            if(stacks[numberWhichStack].checkIfEmpty())
            {
                Take.Hide();
            }
            else
            {
                Take.Show();
                numberElementsToTake.Maximum = stacks[numberWhichStack].numberOfElements;
            }
            
        }

        private void numberElementsToTake_ValueChanged(object sender, EventArgs e)
        {
            numberElemenetsTaken = (int)numberElementsToTake.Value;
        }

        private void Take_Click(object sender, EventArgs e)
        {
            stacks[numberWhichStack].takeNumberOfElements(numberElemenetsTaken);
            if (stacks[numberWhichStack].checkIfEmpty())
            {
                Take.Hide();
            }
            else
            {
                Take.Show();
                numberElementsToTake.Maximum = stacks[numberWhichStack].numberOfElements;
            }
        }
    }
}

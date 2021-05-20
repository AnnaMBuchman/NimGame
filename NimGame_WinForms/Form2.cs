using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimGame_WinForms
{
    public partial class Form2 : Form
    {
        public Dictionary<int, int> minValue = new Dictionary<int, int>();
        public Dictionary<int, int> maxValue = new Dictionary<int, int>();
        private int numberOfStacks;
        private int numberOfElements;
        private List<Stack> stacks;
        private int numberWhichStack=0;
        private int numberElemenetsTaken = 1;
        private bool ifHumanStarts;
        private int strategyComputer;
        Form1 form;

        public Form2(int numberOfStacks, int numberOfElements,Form1 form,bool ifHumanStarts,List<int> stacksHeight, int strategyComputer)
        {

            InitializeComponent();
            this.numberOfStacks = numberOfStacks;
            this.numberOfElements = numberOfElements;
            this.form = form;
            this.ifHumanStarts = ifHumanStarts;
            this.strategyComputer = strategyComputer;
            whichStack.Maximum = numberOfStacks;
            numberElementsToTake.Maximum = numberOfElements;
            generateStacks(stacksHeight);
            splitContainer1.Panel2.Invalidate();
            MinMaxValues();
        }
        private void MinMaxValues()
        {
            minValue.Add(1, 2);
            maxValue.Add(1, 8);
            minValue.Add(2, 4);
            maxValue.Add(2, 5);
            minValue.Add(3, 4);
            maxValue.Add(3, 5);
            minValue.Add(4, 8);
            maxValue.Add(4, 9);
            minValue.Add(5, 8);
            maxValue.Add(5, 9);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Hide();
            if (!ifHumanStarts)
                computerMove();
            if (!stacks[numberWhichStack].checkIfEmpty())
            {
                Take.Show();
                label1.Show();
                label2.Show();
                whichStack.Show();
                numberElementsToTake.Show();
            }
           
        }
        private void generateStacks(List<int> stacksHeight)
        {

            stacks = new List<Stack>();
            if (stacksHeight.Count == 0)
            {
                for (int i = 0; i < numberOfStacks; i++)
                {
                    stacks.Add(new Stack(i, numberOfElements));
                }
            }
            else
            {
                int i = 0;
                foreach (var j in stacksHeight)
                {
                    stacks.Add(new Stack(i, j));
                    i++;
                }
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
                numberElementsToTake.Minimum = 1;
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
                if (!stacks[numberWhichStack].checkIfEmpty())
                {
                    Take.Show();
                    numberElementsToTake.Maximum = stacks[numberWhichStack].numberOfElements;
                }
                
            }
            splitContainer1.Panel2.Invalidate();
            splitContainer1.Panel2.Refresh();
            foreach (var s in stacks)
            {
                if (!s.checkIfEmpty())
                {
                    Take.Hide();
                    Thread.Sleep(1500);
                    computerMove();
                    if (!stacks[numberWhichStack].checkIfEmpty())
                    {
                        Take.Show();
                        numberElementsToTake.Maximum = stacks[numberWhichStack].numberOfElements;
                    }
                    return;
                }
            }

            Form3 form3 = new Form3(this,false);
            form3.ShowDialog();
            form.Close();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Brown);

            SolidBrush sb = new SolidBrush(Color.Brown);
            int i = 0;
            foreach (var s in stacks )
            {
                e.Graphics.DrawRectangle(pen,
                    50+i, 50, 4, 500);
                e.Graphics.FillRectangle(sb,
                    50+i, 50, 4, 500);
                for(int j=0;j< s.numberOfElements;j++)
                {
                    e.Graphics.DrawRectangle(pen,
                    30 + i, 420-j*30, 40, 20);
                    e.Graphics.FillRectangle(sb,
                        30 + i, 420 - j * 30, 40, 20);
                }
                i += 500/numberOfStacks;
            }               
            
        }
        private void computerMove()
        {
            (int s, int num) computerGet=(0,0);
            if (strategyComputer == 0)
                computerGet = ComputerStrategy.nimMove(stacks);
            else if (strategyComputer == 1)
                computerGet = RandomComputerStrategy.SuperRandomStrategy(stacks);
            else if(strategyComputer == 2)
                computerGet = RandomComputerStrategy.Strategy(stacks);
            else if (strategyComputer == 3)
                computerGet = MinimizeComputerStrategy.Strategy(stacks);
            else
                computerGet = KnownStatesComputerStrategy.Strategy(stacks,minValue,maxValue);
            stacks[computerGet.s].takeNumberOfElements(computerGet.num);
            
            splitContainer1.Panel2.Invalidate();
            splitContainer1.Panel2.Refresh();
            foreach (var s in stacks)
            {
                if (!s.checkIfEmpty())
                {
                    whichStack.Value = s.number+1;
                    numberElementsToTake.Maximum = stacks[s.number].numberOfElements;
                    return;
                }
            }

            Form3 form3 = new Form3(this, true);
            form3.ShowDialog();
            form.Close();
        }
    }
}

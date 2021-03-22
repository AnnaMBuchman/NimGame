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
        Form1 form;
        public Form2(int numberOfStacks, int numberOfElements,Form1 form)
        {

            InitializeComponent();
            this.numberOfStacks = numberOfStacks;
            this.numberOfElements = numberOfElements;
            this.form = form;
            whichStack.Maximum = numberOfStacks;
            generateStacks();
            splitContainer1.Panel2.Invalidate();
        }

        private void Start_Click(object sender, EventArgs e)
        {
           
            Take.Visible = true;
            Start.Hide();
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
            splitContainer1.Panel2.Invalidate();
            foreach(var s in stacks)
            {
                if (!s.checkIfEmpty())
                    return;

            }
            Form3 form3 = new Form3(this);
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
    }
}

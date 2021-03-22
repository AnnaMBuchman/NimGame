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
    public partial class Form3 : Form
    {
        Form2 form2;
        public Form3(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            form2.Hide();
            form2.Close();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();            
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            form2.Close();
            this.Close();
        }
    }
}

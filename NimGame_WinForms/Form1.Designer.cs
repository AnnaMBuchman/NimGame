
namespace NimGame_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.stacksNumber = new System.Windows.Forms.NumericUpDown();
            this.numberElements = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.humanOrComputer = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EqualNumber = new System.Windows.Forms.DomainUpDown();
            this.listNumber = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.strategyCompuuter = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stacksNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberElements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of stacks";
            // 
            // stacksNumber
            // 
            this.stacksNumber.Location = new System.Drawing.Point(169, 71);
            this.stacksNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stacksNumber.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.stacksNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stacksNumber.Name = "stacksNumber";
            this.stacksNumber.Size = new System.Drawing.Size(120, 22);
            this.stacksNumber.TabIndex = 1;
            this.stacksNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.stacksNumber.ValueChanged += new System.EventHandler(this.stacksNumber_ValueChanged);
            // 
            // numberElements
            // 
            this.numberElements.Location = new System.Drawing.Point(164, 311);
            this.numberElements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberElements.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numberElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberElements.Name = "numberElements";
            this.numberElements.Size = new System.Drawing.Size(120, 22);
            this.numberElements.TabIndex = 3;
            this.numberElements.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberElements.ValueChanged += new System.EventHandler(this.numberElements_ValueChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.Confirm.Location = new System.Drawing.Point(159, 623);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 50);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of elements on stack";
            // 
            // humanOrComputer
            // 
            this.humanOrComputer.Items.Add("Human");
            this.humanOrComputer.Items.Add("Computer");
            this.humanOrComputer.Location = new System.Drawing.Point(135, 486);
            this.humanOrComputer.Margin = new System.Windows.Forms.Padding(4);
            this.humanOrComputer.Name = "humanOrComputer";
            this.humanOrComputer.ReadOnly = true;
            this.humanOrComputer.Size = new System.Drawing.Size(160, 22);
            this.humanOrComputer.TabIndex = 5;
            this.humanOrComputer.Text = "Human";
            this.humanOrComputer.SelectedItemChanged += new System.EventHandler(this.humanOrComputer_SelectedItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Who starts the game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equal numer of elements?";
            // 
            // EqualNumber
            // 
            this.EqualNumber.Items.Add("Yes");
            this.EqualNumber.Items.Add("No");
            this.EqualNumber.Location = new System.Drawing.Point(145, 180);
            this.EqualNumber.Margin = new System.Windows.Forms.Padding(4);
            this.EqualNumber.Name = "EqualNumber";
            this.EqualNumber.ReadOnly = true;
            this.EqualNumber.Size = new System.Drawing.Size(160, 22);
            this.EqualNumber.TabIndex = 8;
            this.EqualNumber.TabStop = false;
            this.EqualNumber.Text = "Yes";
            this.EqualNumber.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // listNumber
            // 
            this.listNumber.Location = new System.Drawing.Point(68, 310);
            this.listNumber.Name = "listNumber";
            this.listNumber.Size = new System.Drawing.Size(149, 22);
            this.listNumber.TabIndex = 9;
            this.listNumber.TextChanged += new System.EventHandler(this.listNumber_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(72, 372);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 68);
            this.listBox1.TabIndex = 10;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DodgerBlue;
            this.add.Location = new System.Drawing.Point(275, 306);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 29);
            this.add.TabIndex = 11;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear.Location = new System.Drawing.Point(284, 395);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 29);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear list";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Computer strategy";
            // 
            // strategyCompuuter
            // 
            this.strategyCompuuter.Items.Add("Main");
            this.strategyCompuuter.Items.Add("Eeasy");
            this.strategyCompuuter.Items.Add("Random");
            this.strategyCompuuter.Items.Add("Minimize stacks number");
            this.strategyCompuuter.Items.Add("Known states");
            this.strategyCompuuter.Location = new System.Drawing.Point(135, 573);
            this.strategyCompuuter.Margin = new System.Windows.Forms.Padding(4);
            this.strategyCompuuter.Name = "strategyCompuuter";
            this.strategyCompuuter.ReadOnly = true;
            this.strategyCompuuter.Size = new System.Drawing.Size(160, 22);
            this.strategyCompuuter.TabIndex = 14;
            this.strategyCompuuter.Text = "Main";
            this.strategyCompuuter.SelectedItemChanged += new System.EventHandler(this.strategyCompuuter_SelectedItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(455, 703);
            this.Controls.Add(this.strategyCompuuter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listNumber);
            this.Controls.Add(this.EqualNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.humanOrComputer);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.numberElements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stacksNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stacksNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stacksNumber;
        private System.Windows.Forms.NumericUpDown numberElements;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown humanOrComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown EqualNumber;
        private System.Windows.Forms.TextBox listNumber;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown strategyCompuuter;
    }
}



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
            ((System.ComponentModel.ISupportInitialize)(this.stacksNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberElements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of stacks";
            // 
            // stacksNumber
            // 
            this.stacksNumber.Location = new System.Drawing.Point(50, 46);
            this.stacksNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stacksNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stacksNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stacksNumber.Name = "stacksNumber";
            this.stacksNumber.Size = new System.Drawing.Size(90, 20);
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
            this.numberElements.Location = new System.Drawing.Point(50, 108);
            this.numberElements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberElements.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberElements.Name = "numberElements";
            this.numberElements.Size = new System.Drawing.Size(90, 20);
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
            this.Confirm.Location = new System.Drawing.Point(50, 188);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 41);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of elements on stack";
            // 
            // humanOrComputer
            // 
            this.humanOrComputer.Items.Add("Human");
            this.humanOrComputer.Items.Add("Computer");
            this.humanOrComputer.Location = new System.Drawing.Point(32, 163);
            this.humanOrComputer.Name = "humanOrComputer";
            this.humanOrComputer.Size = new System.Drawing.Size(120, 20);
            this.humanOrComputer.TabIndex = 5;
            this.humanOrComputer.Text = "Human";
            this.humanOrComputer.SelectedItemChanged += new System.EventHandler(this.humanOrComputer_SelectedItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "How starts the game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(213, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.humanOrComputer);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.numberElements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stacksNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}


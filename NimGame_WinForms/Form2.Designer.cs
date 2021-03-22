
namespace NimGame_WinForms
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Start = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whichStack = new System.Windows.Forms.NumericUpDown();
            this.numberElementsToTake = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whichStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsToTake)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numberElementsToTake);
            this.splitContainer1.Panel1.Controls.Add(this.whichStack);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Take);
            this.splitContainer1.Panel1.Controls.Add(this.Start);
            this.splitContainer1.Size = new System.Drawing.Size(753, 441);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Tomato;
            this.Start.Location = new System.Drawing.Point(65, 33);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 33);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseCompatibleTextRendering = true;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Take
            // 
            this.Take.BackColor = System.Drawing.Color.Gray;
            this.Take.Location = new System.Drawing.Point(65, 311);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(102, 32);
            this.Take.TabIndex = 1;
            this.Take.Text = "Take";
            this.Take.UseVisualStyleBackColor = false;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which stack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of elements";
            // 
            // whichStack
            // 
            this.whichStack.Location = new System.Drawing.Point(65, 127);
            this.whichStack.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.whichStack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whichStack.Name = "whichStack";
            this.whichStack.Size = new System.Drawing.Size(120, 20);
            this.whichStack.TabIndex = 2;
            this.whichStack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whichStack.ValueChanged += new System.EventHandler(this.whichStack_ValueChanged);
            // 
            // numberElementsToTake
            // 
            this.numberElementsToTake.Location = new System.Drawing.Point(65, 221);
            this.numberElementsToTake.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberElementsToTake.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberElementsToTake.Name = "numberElementsToTake";
            this.numberElementsToTake.Size = new System.Drawing.Size(120, 20);
            this.numberElementsToTake.TabIndex = 3;
            this.numberElementsToTake.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberElementsToTake.ValueChanged += new System.EventHandler(this.numberElementsToTake_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.whichStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsToTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberElementsToTake;
        private System.Windows.Forms.NumericUpDown whichStack;
    }
}
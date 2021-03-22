
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
            this.numberElementsToTake = new System.Windows.Forms.NumericUpDown();
            this.whichStack = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Take = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsToTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whichStack)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 543);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // numberElementsToTake
            // 
            this.numberElementsToTake.Location = new System.Drawing.Point(87, 272);
            this.numberElementsToTake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numberElementsToTake.Size = new System.Drawing.Size(160, 22);
            this.numberElementsToTake.TabIndex = 3;
            this.numberElementsToTake.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberElementsToTake.ValueChanged += new System.EventHandler(this.numberElementsToTake_ValueChanged);
            // 
            // whichStack
            // 
            this.whichStack.Location = new System.Drawing.Point(87, 156);
            this.whichStack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.whichStack.Size = new System.Drawing.Size(160, 22);
            this.whichStack.TabIndex = 2;
            this.whichStack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whichStack.ValueChanged += new System.EventHandler(this.whichStack_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of elements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which stack";
            // 
            // Take
            // 
            this.Take.BackColor = System.Drawing.Color.Tomato;
            this.Take.Location = new System.Drawing.Point(87, 383);
            this.Take.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(136, 39);
            this.Take.TabIndex = 1;
            this.Take.Text = "Take";
            this.Take.UseVisualStyleBackColor = false;
            this.Take.Visible = false;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Tomato;
            this.Start.Location = new System.Drawing.Point(87, 41);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 41);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseCompatibleTextRendering = true;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 543);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberElementsToTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whichStack)).EndInit();
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
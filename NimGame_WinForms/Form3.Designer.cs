
namespace NimGame_WinForms
{
    partial class Form3
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
            this.NewGame = new System.Windows.Forms.Button();
            this.EndGame = new System.Windows.Forms.Button();
            this.howWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewGame.Location = new System.Drawing.Point(82, 92);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(140, 49);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.Tomato;
            this.EndGame.Location = new System.Drawing.Point(306, 92);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(140, 49);
            this.EndGame.TabIndex = 1;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // howWin
            // 
            this.howWin.AutoSize = true;
            this.howWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howWin.Location = new System.Drawing.Point(200, 36);
            this.howWin.Name = "howWin";
            this.howWin.Size = new System.Drawing.Size(126, 24);
            this.howWin.TabIndex = 2;
            this.howWin.Text = "HUMAN WIN!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 225);
            this.Controls.Add(this.howWin);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.NewGame);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Label howWin;
    }
}
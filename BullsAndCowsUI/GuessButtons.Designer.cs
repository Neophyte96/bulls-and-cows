namespace BullsAndCowsUI
{
    public partial class GuessButtons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GuessButton1 = new System.Windows.Forms.Button();
            this.GuessButton2 = new System.Windows.Forms.Button();
            this.GuessButton3 = new System.Windows.Forms.Button();
            this.GuessButton4 = new System.Windows.Forms.Button();
            this.CheckResButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessButton1
            // 
            this.GuessButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GuessButton1.Enabled = false;
            this.GuessButton1.Location = new System.Drawing.Point(0, 2);
            this.GuessButton1.Margin = new System.Windows.Forms.Padding(2);
            this.GuessButton1.Name = "GuessButton1";
            this.GuessButton1.Size = new System.Drawing.Size(37, 33);
            this.GuessButton1.TabIndex = 28;
            this.GuessButton1.UseVisualStyleBackColor = false;
            this.GuessButton1.Click += new System.EventHandler(this.guessButtonClick);
            // 
            // GuessButton2
            // 
            this.GuessButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GuessButton2.Enabled = false;
            this.GuessButton2.Location = new System.Drawing.Point(41, 2);
            this.GuessButton2.Margin = new System.Windows.Forms.Padding(2);
            this.GuessButton2.Name = "GuessButton2";
            this.GuessButton2.Size = new System.Drawing.Size(37, 33);
            this.GuessButton2.TabIndex = 29;
            this.GuessButton2.UseVisualStyleBackColor = false;
            this.GuessButton2.Click += new System.EventHandler(this.guessButtonClick);
            // 
            // GuessButton3
            // 
            this.GuessButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GuessButton3.Enabled = false;
            this.GuessButton3.Location = new System.Drawing.Point(82, 2);
            this.GuessButton3.Margin = new System.Windows.Forms.Padding(2);
            this.GuessButton3.Name = "GuessButton3";
            this.GuessButton3.Size = new System.Drawing.Size(37, 33);
            this.GuessButton3.TabIndex = 30;
            this.GuessButton3.UseVisualStyleBackColor = false;
            this.GuessButton3.Click += new System.EventHandler(this.guessButtonClick);
            // 
            // GuessButton4
            // 
            this.GuessButton4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GuessButton4.Enabled = false;
            this.GuessButton4.Location = new System.Drawing.Point(124, 2);
            this.GuessButton4.Margin = new System.Windows.Forms.Padding(2);
            this.GuessButton4.Name = "GuessButton4";
            this.GuessButton4.Size = new System.Drawing.Size(37, 33);
            this.GuessButton4.TabIndex = 31;
            this.GuessButton4.UseVisualStyleBackColor = false;
            this.GuessButton4.Click += new System.EventHandler(this.guessButtonClick);
            // 
            // CheckResButton
            // 
            this.CheckResButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckResButton.Enabled = false;
            this.CheckResButton.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckResButton.Location = new System.Drawing.Point(163, 7);
            this.CheckResButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckResButton.Name = "CheckResButton";
            this.CheckResButton.Size = new System.Drawing.Size(36, 21);
            this.CheckResButton.TabIndex = 32;
            this.CheckResButton.Text = "-->>";
            this.CheckResButton.UseVisualStyleBackColor = false;
            this.CheckResButton.Click += new System.EventHandler(this.checkResButton_Click);
            // 
            // GuessButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckResButton);
            this.Controls.Add(this.GuessButton4);
            this.Controls.Add(this.GuessButton3);
            this.Controls.Add(this.GuessButton2);
            this.Controls.Add(this.GuessButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuessButtons";
            this.Size = new System.Drawing.Size(201, 36);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button GuessButton1;
        internal System.Windows.Forms.Button GuessButton2;
        internal System.Windows.Forms.Button GuessButton3;
        internal System.Windows.Forms.Button GuessButton4;
        private System.Windows.Forms.Button CheckResButton;
    }
}

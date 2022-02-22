namespace BullsAndCowsUI
{
    public partial class StartForm
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
            this.buttonNumberOfGuesses = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumberOfGuesses
            // 
            this.buttonNumberOfGuesses.Location = new System.Drawing.Point(34, 27);
            this.buttonNumberOfGuesses.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNumberOfGuesses.Name = "buttonNumberOfGuesses";
            this.buttonNumberOfGuesses.Size = new System.Drawing.Size(262, 28);
            this.buttonNumberOfGuesses.TabIndex = 2;
            this.buttonNumberOfGuesses.UseVisualStyleBackColor = true;
            this.buttonNumberOfGuesses.Click += new System.EventHandler(this.buttonNumberOfGuesses_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(242, 84);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(74, 26);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 128);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNumberOfGuesses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfGuesses;
        private System.Windows.Forms.Button buttonStart;
    }
}
namespace BullsAndCowsUI
{
    public partial class ColorPick
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
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonPaleBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonDarkBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPurple.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPurple.Location = new System.Drawing.Point(9, 9);
            this.buttonPurple.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(33, 35);
            this.buttonPurple.TabIndex = 1;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRed.Location = new System.Drawing.Point(46, 9);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(33, 35);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonPaleBlue
            // 
            this.buttonPaleBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonPaleBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPaleBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPaleBlue.Location = new System.Drawing.Point(121, 9);
            this.buttonPaleBlue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPaleBlue.Name = "buttonPaleBlue";
            this.buttonPaleBlue.Size = new System.Drawing.Size(33, 35);
            this.buttonPaleBlue.TabIndex = 4;
            this.buttonPaleBlue.UseVisualStyleBackColor = false;
            this.buttonPaleBlue.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGreen.Location = new System.Drawing.Point(84, 9);
            this.buttonGreen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(33, 35);
            this.buttonGreen.TabIndex = 5;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonDarkBlue
            // 
            this.buttonDarkBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDarkBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDarkBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDarkBlue.Location = new System.Drawing.Point(9, 47);
            this.buttonDarkBlue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDarkBlue.Name = "buttonDarkBlue";
            this.buttonDarkBlue.Size = new System.Drawing.Size(33, 35);
            this.buttonDarkBlue.TabIndex = 6;
            this.buttonDarkBlue.UseVisualStyleBackColor = false;
            this.buttonDarkBlue.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonYellow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonYellow.Location = new System.Drawing.Point(46, 47);
            this.buttonYellow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(33, 35);
            this.buttonYellow.TabIndex = 7;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBrown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBrown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBrown.Location = new System.Drawing.Point(84, 47);
            this.buttonBrown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(33, 35);
            this.buttonBrown.TabIndex = 8;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWhite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonWhite.Location = new System.Drawing.Point(121, 47);
            this.buttonWhite.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(33, 35);
            this.buttonWhite.TabIndex = 9;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonOnClick);
            // 
            // ColorPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(161, 89);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBrown);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonDarkBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonPaleBlue);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonPurple);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick A Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonPaleBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonDarkBlue;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonWhite;
    }
}
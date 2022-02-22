namespace BullsAndCowsUI
{
    public partial class ResultButtons
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
            this.ResultButton1 = new System.Windows.Forms.Button();
            this.ResultButton3 = new System.Windows.Forms.Button();
            this.ResultButton2 = new System.Windows.Forms.Button();
            this.ResultButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultButton1
            // 
            this.ResultButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResultButton1.Enabled = false;
            this.ResultButton1.Location = new System.Drawing.Point(3, 2);
            this.ResultButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton1.Name = "ResultButton1";
            this.ResultButton1.Size = new System.Drawing.Size(23, 18);
            this.ResultButton1.TabIndex = 23;
            this.ResultButton1.UseVisualStyleBackColor = false;
            
            // 
            // ResultButton3
            // 
            this.ResultButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResultButton3.Enabled = false;
            this.ResultButton3.Location = new System.Drawing.Point(3, 24);
            this.ResultButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton3.Name = "ResultButton3";
            this.ResultButton3.Size = new System.Drawing.Size(23, 18);
            this.ResultButton3.TabIndex = 24;
            this.ResultButton3.UseVisualStyleBackColor = false;
            // 
            // ResultButton2
            // 
            this.ResultButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResultButton2.Enabled = false;
            this.ResultButton2.Location = new System.Drawing.Point(24, 2);
            this.ResultButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton2.Name = "ResultButton2";
            this.ResultButton2.Size = new System.Drawing.Size(23, 18);
            this.ResultButton2.TabIndex = 25;
            this.ResultButton2.UseVisualStyleBackColor = false;
            // 
            // ResultButton4
            // 
            this.ResultButton4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResultButton4.Enabled = false;
            this.ResultButton4.Location = new System.Drawing.Point(24, 24);
            this.ResultButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton4.Name = "ResultButton4";
            this.ResultButton4.Size = new System.Drawing.Size(23, 18);
            this.ResultButton4.TabIndex = 26;
            this.ResultButton4.UseVisualStyleBackColor = false;
            // 
            // ResultButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultButton4);
            this.Controls.Add(this.ResultButton2);
            this.Controls.Add(this.ResultButton3);
            this.Controls.Add(this.ResultButton1);
            this.Name = "ResultButtons";
            this.Size = new System.Drawing.Size(50, 44);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResultButton1;
        private System.Windows.Forms.Button ResultButton3;
        private System.Windows.Forms.Button ResultButton2;
        private System.Windows.Forms.Button ResultButton4;
    }
}

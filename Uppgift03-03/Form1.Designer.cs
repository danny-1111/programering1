
namespace Uppgift03_03
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
            this.btxKör = new System.Windows.Forms.Button();
            this.lblDecimaltal = new System.Windows.Forms.Label();
            this.lblHeltal = new System.Windows.Forms.Label();
            this.tbxDecimaltal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btxKör
            // 
            this.btxKör.Location = new System.Drawing.Point(164, 149);
            this.btxKör.Name = "btxKör";
            this.btxKör.Size = new System.Drawing.Size(75, 23);
            this.btxKör.TabIndex = 0;
            this.btxKör.Text = "Kör";
            this.btxKör.UseVisualStyleBackColor = true;
            this.btxKör.Click += new System.EventHandler(this.btxKör_Click);
            // 
            // lblDecimaltal
            // 
            this.lblDecimaltal.AutoSize = true;
            this.lblDecimaltal.Location = new System.Drawing.Point(84, 34);
            this.lblDecimaltal.Name = "lblDecimaltal";
            this.lblDecimaltal.Size = new System.Drawing.Size(56, 13);
            this.lblDecimaltal.TabIndex = 1;
            this.lblDecimaltal.Text = "Decimaltal";
            // 
            // lblHeltal
            // 
            this.lblHeltal.AutoSize = true;
            this.lblHeltal.Location = new System.Drawing.Point(161, 83);
            this.lblHeltal.Name = "lblHeltal";
            this.lblHeltal.Size = new System.Drawing.Size(0, 13);
            this.lblHeltal.TabIndex = 2;
            // 
            // tbxDecimaltal
            // 
            this.tbxDecimaltal.Location = new System.Drawing.Point(164, 34);
            this.tbxDecimaltal.Name = "tbxDecimaltal";
            this.tbxDecimaltal.Size = new System.Drawing.Size(100, 20);
            this.tbxDecimaltal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 197);
            this.Controls.Add(this.tbxDecimaltal);
            this.Controls.Add(this.lblHeltal);
            this.Controls.Add(this.lblDecimaltal);
            this.Controls.Add(this.btxKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxKör;
        private System.Windows.Forms.Label lblDecimaltal;
        private System.Windows.Forms.Label lblHeltal;
        private System.Windows.Forms.TextBox tbxDecimaltal;
    }
}


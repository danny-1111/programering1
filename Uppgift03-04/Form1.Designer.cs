
namespace Uppgift03_04
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
            this.btnKör = new System.Windows.Forms.Button();
            this.lblBelopp = new System.Windows.Forms.Label();
            this.lblHundralappar = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(182, 160);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Location = new System.Drawing.Point(81, 45);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(40, 13);
            this.lblBelopp.TabIndex = 1;
            this.lblBelopp.Text = "Belopp";
            // 
            // lblHundralappar
            // 
            this.lblHundralappar.AutoSize = true;
            this.lblHundralappar.Location = new System.Drawing.Point(202, 117);
            this.lblHundralappar.Name = "lblHundralappar";
            this.lblHundralappar.Size = new System.Drawing.Size(0, 13);
            this.lblHundralappar.TabIndex = 2;
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(182, 38);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxBelopp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 223);
            this.Controls.Add(this.tbxBelopp);
            this.Controls.Add(this.lblHundralappar);
            this.Controls.Add(this.lblBelopp);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.Label lblHundralappar;
        private System.Windows.Forms.TextBox tbxBelopp;
    }
}


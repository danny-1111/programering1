
namespace Uppgift03_01
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
            this.lblTeckenkod = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxTeckenkod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(147, 131);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblTeckenkod
            // 
            this.lblTeckenkod.AutoSize = true;
            this.lblTeckenkod.Location = new System.Drawing.Point(59, 35);
            this.lblTeckenkod.Name = "lblTeckenkod";
            this.lblTeckenkod.Size = new System.Drawing.Size(62, 13);
            this.lblTeckenkod.TabIndex = 1;
            this.lblTeckenkod.Text = "Teckenkod";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(144, 82);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 2;
            // 
            // tbxTeckenkod
            // 
            this.tbxTeckenkod.Location = new System.Drawing.Point(137, 28);
            this.tbxTeckenkod.Name = "tbxTeckenkod";
            this.tbxTeckenkod.Size = new System.Drawing.Size(100, 20);
            this.tbxTeckenkod.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 198);
            this.Controls.Add(this.tbxTeckenkod);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblTeckenkod);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblTeckenkod;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxTeckenkod;
    }
}


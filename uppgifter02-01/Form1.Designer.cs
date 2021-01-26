
using System.Windows.Forms;

namespace uppgifter02_01
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
            this.btnRöd = new System.Windows.Forms.Button();
            this.btnblå = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRöd
            // 
            this.btnRöd.Location = new System.Drawing.Point(55, 37);
            this.btnRöd.Name = "btnRöd";
            this.btnRöd.Size = new System.Drawing.Size(75, 23);
            this.btnRöd.TabIndex = 0;
            this.btnRöd.Text = "Röd";
            this.btnRöd.UseVisualStyleBackColor = true;
            this.btnRöd.Click += new System.EventHandler(this.btnRöd_Click);
            // 
            // btnblå
            // 
            this.btnblå.Location = new System.Drawing.Point(265, 37);
            this.btnblå.Name = "btnblå";
            this.btnblå.Size = new System.Drawing.Size(75, 23);
            this.btnblå.TabIndex = 1;
            this.btnblå.Text = "Blå";
            this.btnblå.UseVisualStyleBackColor = true;
            this.btnblå.Click += new System.EventHandler(this.btnblå_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(411, 115);
            this.Controls.Add(this.btnblå);
            this.Controls.Add(this.btnRöd);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRöd;
        private System.Windows.Forms.Button btnblå;
        private Label lblFlytta;



    }
}


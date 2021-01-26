
namespace Exempel102_02
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
            this.btnklick1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnklick1
            // 
            this.btnklick1.Location = new System.Drawing.Point(46, 49);
            this.btnklick1.Name = "btnklick1";
            this.btnklick1.Size = new System.Drawing.Size(75, 23);
            this.btnklick1.TabIndex = 0;
            this.btnklick1.Text = "Klicka Här";
            this.btnklick1.UseVisualStyleBackColor = true;
            this.btnklick1.Click += new System.EventHandler(this.btnklick1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.btnklick1);
            this.Name = "Form1";
            this.Text = "Exempel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnklick;
        private System.Windows.Forms.Button btnklick1;
    }
}


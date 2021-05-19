
namespace Lab1_1
{
    partial class Form2
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
            this.OpenForm3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenForm3Button
            // 
            this.OpenForm3Button.Location = new System.Drawing.Point(335, 142);
            this.OpenForm3Button.Name = "OpenForm3Button";
            this.OpenForm3Button.Size = new System.Drawing.Size(75, 56);
            this.OpenForm3Button.TabIndex = 0;
            this.OpenForm3Button.Text = "Open Form3";
            this.OpenForm3Button.UseVisualStyleBackColor = true;
            this.OpenForm3Button.Click += new System.EventHandler(this.OpenForm3Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenForm3Button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenForm3Button;
    }
}
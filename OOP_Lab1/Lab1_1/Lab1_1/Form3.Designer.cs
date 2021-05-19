
namespace Lab1_1
{
    partial class Form3
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
            this.CloseForms2and3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseForms2and3Button
            // 
            this.CloseForms2and3Button.Location = new System.Drawing.Point(363, 152);
            this.CloseForms2and3Button.Name = "CloseForms2and3Button";
            this.CloseForms2and3Button.Size = new System.Drawing.Size(190, 91);
            this.CloseForms2and3Button.TabIndex = 0;
            this.CloseForms2and3Button.Text = "Close Form2 and Form3";
            this.CloseForms2and3Button.UseVisualStyleBackColor = true;
            this.CloseForms2and3Button.Click += new System.EventHandler(this.CloseForms2and3Button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseForms2and3Button);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseForms2and3Button;
    }
}
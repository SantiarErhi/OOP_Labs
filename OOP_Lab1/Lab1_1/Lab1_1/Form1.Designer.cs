
namespace Lab1_1
{
    partial class OpenForm2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenForm2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(240, 89);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 69);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenForm2Button
            // 
            this.OpenForm2Button.Location = new System.Drawing.Point(359, 89);
            this.OpenForm2Button.Name = "OpenForm2Button";
            this.OpenForm2Button.Size = new System.Drawing.Size(75, 68);
            this.OpenForm2Button.TabIndex = 1;
            this.OpenForm2Button.Text = "Open Form2";
            this.OpenForm2Button.UseVisualStyleBackColor = true;
            this.OpenForm2Button.Click += new System.EventHandler(this.OpenForm2Button_Click);
            // 
            // OpenForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenForm2Button);
            this.Controls.Add(this.ExitButton);
            this.Name = "OpenForm2";
            this.Text = "To Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenForm2Button;
    }
}



namespace Lab1_4
{
    partial class Form1
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
            this.CreateLabelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateLabelButton
            // 
            this.CreateLabelButton.Location = new System.Drawing.Point(649, 331);
            this.CreateLabelButton.Name = "CreateLabelButton";
            this.CreateLabelButton.Size = new System.Drawing.Size(121, 39);
            this.CreateLabelButton.TabIndex = 0;
            this.CreateLabelButton.Text = "Create label";
            this.CreateLabelButton.UseVisualStyleBackColor = true;
            this.CreateLabelButton.Click += new System.EventHandler(this.CreateLabelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(631, 281);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(139, 15);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Number of pressed label ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateLabelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateLabelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberLabel;
    }
}


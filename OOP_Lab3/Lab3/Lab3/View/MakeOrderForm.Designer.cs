
namespace Lab3.View
{
    partial class MakeOrderForm
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
            this.removeDishButton = new System.Windows.Forms.Button();
            this.createDishButton = new System.Windows.Forms.Button();
            this.cafeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeDishButton
            // 
            this.removeDishButton.Location = new System.Drawing.Point(491, 42);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(297, 23);
            this.removeDishButton.TabIndex = 5;
            this.removeDishButton.Text = "Remove dish";
            this.removeDishButton.UseVisualStyleBackColor = true;
            // 
            // createDishButton
            // 
            this.createDishButton.Location = new System.Drawing.Point(491, 13);
            this.createDishButton.Name = "createDishButton";
            this.createDishButton.Size = new System.Drawing.Size(297, 23);
            this.createDishButton.TabIndex = 4;
            this.createDishButton.Text = "Create dish";
            this.createDishButton.UseVisualStyleBackColor = true;
            // 
            // cafeNameTextBox
            // 
            this.cafeNameTextBox.Location = new System.Drawing.Point(82, 10);
            this.cafeNameTextBox.Name = "cafeNameTextBox";
            this.cafeNameTextBox.Size = new System.Drawing.Size(215, 23);
            this.cafeNameTextBox.TabIndex = 7;
            this.cafeNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cafe name";
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cafeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeDishButton);
            this.Controls.Add(this.createDishButton);
            this.Name = "MakeOrderForm";
            this.Text = "MakeOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeDishButton;
        private System.Windows.Forms.Button createDishButton;
        private System.Windows.Forms.TextBox cafeNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}
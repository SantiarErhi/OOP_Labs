
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
            this.components = new System.ComponentModel.Container();
            this.removeDishButton = new System.Windows.Forms.Button();
            this.createDishButton = new System.Windows.Forms.Button();
            this.cafeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Dishes = new System.Windows.Forms.ListBox();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // removeDishButton
            // 
            this.removeDishButton.Location = new System.Drawing.Point(82, 99);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(215, 23);
            this.removeDishButton.TabIndex = 5;
            this.removeDishButton.Text = "Remove dish";
            this.removeDishButton.UseVisualStyleBackColor = true;
            // 
            // createDishButton
            // 
            this.createDishButton.Location = new System.Drawing.Point(82, 70);
            this.createDishButton.Name = "createDishButton";
            this.createDishButton.Size = new System.Drawing.Size(215, 23);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Dishes
            // 
            this.Dishes.FormattingEnabled = true;
            this.Dishes.ItemHeight = 15;
            this.Dishes.Location = new System.Drawing.Point(304, 10);
            this.Dishes.Name = "Dishes";
            this.Dishes.Size = new System.Drawing.Size(217, 139);
            this.Dishes.TabIndex = 9;
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(82, 128);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(215, 23);
            this.saveOrderButton.TabIndex = 10;
            this.saveOrderButton.Text = "Save order";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 158);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.Dishes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cafeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeDishButton);
            this.Controls.Add(this.createDishButton);
            this.Name = "MakeOrderForm";
            this.Text = "MakeOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox cafeNameTextBox;
        internal System.Windows.Forms.ListBox Dishes;
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Button createDishButton;
        internal System.Windows.Forms.Button removeDishButton;
        internal System.Windows.Forms.Button saveOrderButton;
        internal System.Windows.Forms.ErrorProvider errorProvider;
    }
}
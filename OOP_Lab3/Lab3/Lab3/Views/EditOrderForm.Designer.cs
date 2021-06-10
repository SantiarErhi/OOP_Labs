
namespace Lab3.Views
{
    partial class EditOrderForm
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
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.Dishes = new System.Windows.Forms.ListBox();
            this.cafeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeDishButton = new System.Windows.Forms.Button();
            this.createDishButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(82, 130);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(215, 23);
            this.saveOrderButton.TabIndex = 16;
            this.saveOrderButton.Text = "Save order";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // Dishes
            // 
            this.Dishes.FormattingEnabled = true;
            this.Dishes.ItemHeight = 15;
            this.Dishes.Location = new System.Drawing.Point(304, 12);
            this.Dishes.Name = "Dishes";
            this.Dishes.Size = new System.Drawing.Size(217, 139);
            this.Dishes.TabIndex = 15;
            // 
            // cafeNameTextBox
            // 
            this.cafeNameTextBox.Location = new System.Drawing.Point(82, 12);
            this.cafeNameTextBox.Name = "cafeNameTextBox";
            this.cafeNameTextBox.Size = new System.Drawing.Size(215, 23);
            this.cafeNameTextBox.TabIndex = 14;
            this.cafeNameTextBox.TextChanged += new System.EventHandler(this.cafeNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cafe name";
            // 
            // removeDishButton
            // 
            this.removeDishButton.Location = new System.Drawing.Point(82, 101);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(215, 23);
            this.removeDishButton.TabIndex = 12;
            this.removeDishButton.Text = "Remove dish";
            this.removeDishButton.UseVisualStyleBackColor = true;
            this.removeDishButton.Click += new System.EventHandler(this.removeDishButton_Click);
            // 
            // createDishButton
            // 
            this.createDishButton.Location = new System.Drawing.Point(82, 72);
            this.createDishButton.Name = "createDishButton";
            this.createDishButton.Size = new System.Drawing.Size(215, 23);
            this.createDishButton.TabIndex = 11;
            this.createDishButton.Text = "Create dish";
            this.createDishButton.UseVisualStyleBackColor = true;
            this.createDishButton.Click += new System.EventHandler(this.createDishButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 160);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.Dishes);
            this.Controls.Add(this.cafeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeDishButton);
            this.Controls.Add(this.createDishButton);
            this.Name = "EditOrderForm";
            this.Text = "EditOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox cafeNameTextBox;
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Button createDishButton;
        internal System.Windows.Forms.Button saveOrderButton;
        internal System.Windows.Forms.Button removeDishButton;
        internal System.Windows.Forms.ListBox Dishes;
        internal System.Windows.Forms.ErrorProvider errorProvider;
    }
}
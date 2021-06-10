
namespace Lab3.Views
{
    partial class DetailOrderView
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
            this.Dishes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cafeNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.cookNameAndSurnameLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dishes
            // 
            this.Dishes.FormattingEnabled = true;
            this.Dishes.ItemHeight = 15;
            this.Dishes.Location = new System.Drawing.Point(12, 12);
            this.Dishes.Name = "Dishes";
            this.Dishes.Size = new System.Drawing.Size(217, 424);
            this.Dishes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cafe:";
            // 
            // cafeNameLabel
            // 
            this.cafeNameLabel.AutoSize = true;
            this.cafeNameLabel.Location = new System.Drawing.Point(308, 12);
            this.cafeNameLabel.Name = "cafeNameLabel";
            this.cafeNameLabel.Size = new System.Drawing.Size(0, 15);
            this.cafeNameLabel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Order date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categories:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cook:";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(308, 37);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(0, 15);
            this.orderDateLabel.TabIndex = 18;
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Location = new System.Drawing.Point(308, 62);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(0, 15);
            this.dishNameLabel.TabIndex = 19;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(308, 87);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 15);
            this.costLabel.TabIndex = 20;
            // 
            // cookNameAndSurnameLabel
            // 
            this.cookNameAndSurnameLabel.AutoSize = true;
            this.cookNameAndSurnameLabel.Location = new System.Drawing.Point(308, 112);
            this.cookNameAndSurnameLabel.Name = "cookNameAndSurnameLabel";
            this.cookNameAndSurnameLabel.Size = new System.Drawing.Size(0, 15);
            this.cookNameAndSurnameLabel.TabIndex = 21;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(308, 137);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(0, 15);
            this.categoriesLabel.TabIndex = 22;
            // 
            // DetailOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.cookNameAndSurnameLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dishNameLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cafeNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dishes);
            this.Name = "DetailOrderView";
            this.Text = "DetailOrderView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox Dishes;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label cafeNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label orderDateLabel;
        internal System.Windows.Forms.Label dishNameLabel;
        internal System.Windows.Forms.Label costLabel;
        internal System.Windows.Forms.Label cookNameAndSurnameLabel;
        internal System.Windows.Forms.Label categoriesLabel;
    }
}
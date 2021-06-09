
namespace Lab3
{
    partial class MainForm
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
            this.Orders = new System.Windows.Forms.ListBox();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.detailViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.FormattingEnabled = true;
            this.Orders.ItemHeight = 15;
            this.Orders.Location = new System.Drawing.Point(12, 12);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(473, 424);
            this.Orders.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(491, 12);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(297, 23);
            this.createOrderButton.TabIndex = 1;
            this.createOrderButton.Text = "Make an order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // editOrderButton
            // 
            this.editOrderButton.Location = new System.Drawing.Point(491, 41);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(297, 23);
            this.editOrderButton.TabIndex = 2;
            this.editOrderButton.Text = "Edit order";
            this.editOrderButton.UseVisualStyleBackColor = true;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(491, 99);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(297, 23);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(491, 128);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(297, 23);
            this.saveFileButton.TabIndex = 4;
            this.saveFileButton.Text = "Save file";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // detailViewButton
            // 
            this.detailViewButton.Location = new System.Drawing.Point(491, 70);
            this.detailViewButton.Name = "detailViewButton";
            this.detailViewButton.Size = new System.Drawing.Size(297, 23);
            this.detailViewButton.TabIndex = 5;
            this.detailViewButton.Text = "Detail view";
            this.detailViewButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailViewButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.Orders);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Orders;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button detailViewButton;
    }
}


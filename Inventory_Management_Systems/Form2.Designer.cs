
namespace Inventory_Management_Systems._2
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
            this.InventoryPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShelfPrint = new System.Windows.Forms.TextBox();
            this.backFromView = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InventoryPrint
            // 
            this.InventoryPrint.Location = new System.Drawing.Point(12, 30);
            this.InventoryPrint.Multiline = true;
            this.InventoryPrint.Name = "InventoryPrint";
            this.InventoryPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InventoryPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InventoryPrint.Size = new System.Drawing.Size(272, 135);
            this.InventoryPrint.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "In inventory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "On the shelf:";
            // 
            // ShelfPrint
            // 
            this.ShelfPrint.Location = new System.Drawing.Point(15, 184);
            this.ShelfPrint.Multiline = true;
            this.ShelfPrint.Name = "ShelfPrint";
            this.ShelfPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShelfPrint.Size = new System.Drawing.Size(272, 164);
            this.ShelfPrint.TabIndex = 3;
            // 
            // backFromView
            // 
            this.backFromView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.backFromView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromView.Location = new System.Drawing.Point(290, 30);
            this.backFromView.Name = "backFromView";
            this.backFromView.Size = new System.Drawing.Size(137, 49);
            this.backFromView.TabIndex = 7;
            this.backFromView.Text = "Back";
            this.backFromView.UseVisualStyleBackColor = false;
            this.backFromView.Click += new System.EventHandler(this.backFromView_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(293, 184);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(137, 49);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort Shelf";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(293, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Programmed by Matthew Spuzello";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.backFromView);
            this.Controls.Add(this.ShelfPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InventoryPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "View Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InventoryPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShelfPrint;
        private System.Windows.Forms.Button backFromView;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label3;
    }
}
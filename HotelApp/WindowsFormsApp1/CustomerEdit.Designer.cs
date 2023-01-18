namespace HotelAppForm
{
    partial class CustomerEdit
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
            this.numOfGuestsComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.dailyRateTextBox = new System.Windows.Forms.TextBox();
            this.leaveTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // numOfGuestsComboBox
            // 
            this.numOfGuestsComboBox.FormattingEnabled = true;
            this.numOfGuestsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.numOfGuestsComboBox.Location = new System.Drawing.Point(416, 72);
            this.numOfGuestsComboBox.Name = "numOfGuestsComboBox";
            this.numOfGuestsComboBox.Size = new System.Drawing.Size(35, 21);
            this.numOfGuestsComboBox.TabIndex = 67;
            this.numOfGuestsComboBox.Text = "1";
            this.numOfGuestsComboBox.SelectedIndexChanged += new System.EventHandler(this.numOfGuestsComboBox_SelectedIndexChanged);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115"});
            this.roomComboBox.Location = new System.Drawing.Point(265, 72);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(50, 21);
            this.roomComboBox.TabIndex = 66;
            this.roomComboBox.Text = "101";
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Room";
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.floorComboBox.Location = new System.Drawing.Point(175, 71);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(36, 21);
            this.floorComboBox.TabIndex = 64;
            this.floorComboBox.Text = "1";
            this.floorComboBox.SelectedIndexChanged += new System.EventHandler(this.floorComboBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 49);
            this.backButton.TabIndex = 63;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(18, 83);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 49);
            this.confirmButton.TabIndex = 62;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Customer Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(227, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 20);
            this.nameTextBox.TabIndex = 60;
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.Location = new System.Drawing.Point(227, 46);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.Size = new System.Drawing.Size(88, 20);
            this.arrivalTextBox.TabIndex = 59;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(416, 124);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(88, 20);
            this.totalTextBox.TabIndex = 58;
            // 
            // dailyRateTextBox
            // 
            this.dailyRateTextBox.Location = new System.Drawing.Point(416, 98);
            this.dailyRateTextBox.Name = "dailyRateTextBox";
            this.dailyRateTextBox.ReadOnly = true;
            this.dailyRateTextBox.Size = new System.Drawing.Size(88, 20);
            this.dailyRateTextBox.TabIndex = 57;
            // 
            // leaveTextBox
            // 
            this.leaveTextBox.Location = new System.Drawing.Point(416, 46);
            this.leaveTextBox.Name = "leaveTextBox";
            this.leaveTextBox.Size = new System.Drawing.Size(88, 20);
            this.leaveTextBox.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total Sale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Floor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Num of Guests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Daily Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Room type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date Leaving";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Arrival Date";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMessage.Location = new System.Drawing.Point(139, 124);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessage.TabIndex = 68;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Joint",
            "Connecting",
            "Suite",
            "Accessable"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(227, 101);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(88, 21);
            this.roomTypeComboBox.TabIndex = 71;
            this.roomTypeComboBox.Text = "Standard";
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 156);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.numOfGuestsComboBox);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.floorComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.arrivalTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.dailyRateTextBox);
            this.Controls.Add(this.leaveTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CustomerEdit";
            this.Text = "CustomerEdit";
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox numOfGuestsComboBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox dailyRateTextBox;
        private System.Windows.Forms.TextBox leaveTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
    }
}
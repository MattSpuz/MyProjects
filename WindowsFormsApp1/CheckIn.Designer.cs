namespace HotelAppForm
{
    partial class CheckIn
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numOfGuestsComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Customer Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(221, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 20);
            this.nameTextBox.TabIndex = 39;
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.Location = new System.Drawing.Point(221, 49);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.Size = new System.Drawing.Size(88, 20);
            this.arrivalTextBox.TabIndex = 38;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(410, 127);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(88, 20);
            this.totalTextBox.TabIndex = 37;
            // 
            // dailyRateTextBox
            // 
            this.dailyRateTextBox.Location = new System.Drawing.Point(410, 101);
            this.dailyRateTextBox.Name = "dailyRateTextBox";
            this.dailyRateTextBox.ReadOnly = true;
            this.dailyRateTextBox.Size = new System.Drawing.Size(88, 20);
            this.dailyRateTextBox.TabIndex = 36;
            // 
            // leaveTextBox
            // 
            this.leaveTextBox.Location = new System.Drawing.Point(410, 49);
            this.leaveTextBox.Name = "leaveTextBox";
            this.leaveTextBox.Size = new System.Drawing.Size(88, 20);
            this.leaveTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Sale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Floor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Num of Guests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Daily Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date Leaving";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Arrival Date";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 86);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 49);
            this.confirmButton.TabIndex = 42;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 49);
            this.backButton.TabIndex = 43;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.floorComboBox.Location = new System.Drawing.Point(169, 74);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(36, 21);
            this.floorComboBox.TabIndex = 44;
            this.floorComboBox.Text = "1";
            this.floorComboBox.SelectedIndexChanged += new System.EventHandler(this.floorComboBox_SelectedIndexChanged);
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
            this.roomComboBox.Location = new System.Drawing.Point(259, 75);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(50, 21);
            this.roomComboBox.TabIndex = 46;
            this.roomComboBox.Text = "101";
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Room";
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
            this.numOfGuestsComboBox.Location = new System.Drawing.Point(410, 75);
            this.numOfGuestsComboBox.Name = "numOfGuestsComboBox";
            this.numOfGuestsComboBox.Size = new System.Drawing.Size(35, 21);
            this.numOfGuestsComboBox.TabIndex = 47;
            this.numOfGuestsComboBox.Text = "1";
            this.numOfGuestsComboBox.SelectedIndexChanged += new System.EventHandler(this.numOfGuestsComboBox_SelectedIndexChanged);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMessage.Location = new System.Drawing.Point(133, 127);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessage.TabIndex = 69;
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
            this.roomTypeComboBox.Location = new System.Drawing.Point(221, 102);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(88, 21);
            this.roomTypeComboBox.TabIndex = 70;
            this.roomTypeComboBox.Text = "Standard";
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 155);
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
            this.Name = "CheckIn";
            this.Text = "Customer Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox numOfGuestsComboBox;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
    }
}
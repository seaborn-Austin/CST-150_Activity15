namespace CST_150_Activity15
{
    partial class luckyNumberGeneratorfrm
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
            this.holidayLbl = new System.Windows.Forms.Label();
            this.halloweenRadioButton = new System.Windows.Forms.RadioButton();
            this.thanksGivingRadioButton = new System.Windows.Forms.RadioButton();
            this.christmasRadioButton = new System.Windows.Forms.RadioButton();
            this.favoriteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.favoriteNumberLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.luckyNumberBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayLbl
            // 
            this.holidayLbl.AutoSize = true;
            this.holidayLbl.Location = new System.Drawing.Point(12, 9);
            this.holidayLbl.Name = "holidayLbl";
            this.holidayLbl.Size = new System.Drawing.Size(148, 13);
            this.holidayLbl.TabIndex = 0;
            this.holidayLbl.Text = "What is your favorite Holiday?";
            // 
            // halloweenRadioButton
            // 
            this.halloweenRadioButton.AutoSize = true;
            this.halloweenRadioButton.Location = new System.Drawing.Point(12, 25);
            this.halloweenRadioButton.Name = "halloweenRadioButton";
            this.halloweenRadioButton.Size = new System.Drawing.Size(75, 17);
            this.halloweenRadioButton.TabIndex = 1;
            this.halloweenRadioButton.TabStop = true;
            this.halloweenRadioButton.Text = "Halloween";
            this.halloweenRadioButton.UseVisualStyleBackColor = true;
            // 
            // thanksGivingRadioButton
            // 
            this.thanksGivingRadioButton.AutoSize = true;
            this.thanksGivingRadioButton.Location = new System.Drawing.Point(12, 48);
            this.thanksGivingRadioButton.Name = "thanksGivingRadioButton";
            this.thanksGivingRadioButton.Size = new System.Drawing.Size(89, 17);
            this.thanksGivingRadioButton.TabIndex = 2;
            this.thanksGivingRadioButton.TabStop = true;
            this.thanksGivingRadioButton.Text = "Thanksgiving";
            this.thanksGivingRadioButton.UseVisualStyleBackColor = true;
            // 
            // christmasRadioButton
            // 
            this.christmasRadioButton.AutoSize = true;
            this.christmasRadioButton.Location = new System.Drawing.Point(12, 71);
            this.christmasRadioButton.Name = "christmasRadioButton";
            this.christmasRadioButton.Size = new System.Drawing.Size(70, 17);
            this.christmasRadioButton.TabIndex = 3;
            this.christmasRadioButton.TabStop = true;
            this.christmasRadioButton.Text = "Christmas";
            this.christmasRadioButton.UseVisualStyleBackColor = true;
            // 
            // favoriteNumericUpDown
            // 
            this.favoriteNumericUpDown.Location = new System.Drawing.Point(15, 148);
            this.favoriteNumericUpDown.Name = "favoriteNumericUpDown";
            this.favoriteNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.favoriteNumericUpDown.TabIndex = 4;
            // 
            // favoriteNumberLbl
            // 
            this.favoriteNumberLbl.AutoSize = true;
            this.favoriteNumberLbl.Location = new System.Drawing.Point(12, 119);
            this.favoriteNumberLbl.Name = "favoriteNumberLbl";
            this.favoriteNumberLbl.Size = new System.Drawing.Size(139, 26);
            this.favoriteNumberLbl.TabIndex = 5;
            this.favoriteNumberLbl.Text = "Select your favorite number \r\nbetween 0 and 999:\r\n";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(12, 189);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(120, 13);
            this.firstNameLbl.TabIndex = 6;
            this.firstNameLbl.Text = "What is your first name?";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(15, 205);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 7;
            // 
            // luckyNumberBtn
            // 
            this.luckyNumberBtn.Location = new System.Drawing.Point(12, 278);
            this.luckyNumberBtn.Name = "luckyNumberBtn";
            this.luckyNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.luckyNumberBtn.TabIndex = 8;
            this.luckyNumberBtn.Text = "Click me";
            this.luckyNumberBtn.UseVisualStyleBackColor = true;
            this.luckyNumberBtn.Click += new System.EventHandler(this.luckyNumberBtn_Click);
            // 
            // luckyNumberGeneratorfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.luckyNumberBtn);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.favoriteNumberLbl);
            this.Controls.Add(this.favoriteNumericUpDown);
            this.Controls.Add(this.christmasRadioButton);
            this.Controls.Add(this.thanksGivingRadioButton);
            this.Controls.Add(this.halloweenRadioButton);
            this.Controls.Add(this.holidayLbl);
            this.Name = "luckyNumberGeneratorfrm";
            this.Text = "Lucky Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label holidayLbl;
        private System.Windows.Forms.RadioButton halloweenRadioButton;
        private System.Windows.Forms.RadioButton thanksGivingRadioButton;
        private System.Windows.Forms.RadioButton christmasRadioButton;
        private System.Windows.Forms.NumericUpDown favoriteNumericUpDown;
        private System.Windows.Forms.Label favoriteNumberLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Button luckyNumberBtn;
    }
}


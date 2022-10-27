namespace CST_150_Activity15
{
    partial class luckyNumberFrm
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
            this.luckyNumberTxt = new System.Windows.Forms.TextBox();
            this.luckyNumberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luckyNumberTxt
            // 
            this.luckyNumberTxt.BackColor = System.Drawing.Color.Indigo;
            this.luckyNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luckyNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.luckyNumberTxt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.luckyNumberTxt.Location = new System.Drawing.Point(93, 94);
            this.luckyNumberTxt.Multiline = true;
            this.luckyNumberTxt.Name = "luckyNumberTxt";
            this.luckyNumberTxt.Size = new System.Drawing.Size(58, 42);
            this.luckyNumberTxt.TabIndex = 0;
            this.luckyNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // luckyNumberLbl
            // 
            this.luckyNumberLbl.AutoSize = true;
            this.luckyNumberLbl.Location = new System.Drawing.Point(73, 78);
            this.luckyNumberLbl.Name = "luckyNumberLbl";
            this.luckyNumberLbl.Size = new System.Drawing.Size(104, 13);
            this.luckyNumberLbl.TabIndex = 1;
            this.luckyNumberLbl.Text = "Your Lucky Number!";
            // 
            // luckyNumberFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST_150_Activity15.Properties.Resources._62483633;
            this.ClientSize = new System.Drawing.Size(257, 230);
            this.Controls.Add(this.luckyNumberLbl);
            this.Controls.Add(this.luckyNumberTxt);
            this.Name = "luckyNumberFrm";
            this.Text = "Your Lucky Number!!";
            this.Load += new System.EventHandler(this.luckyNumberFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox luckyNumberTxt;
        private System.Windows.Forms.Label luckyNumberLbl;
    }
}
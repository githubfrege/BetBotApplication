namespace PokerBotApplication
{
    partial class ManualPokerBot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.holeCardsTxt = new System.Windows.Forms.TextBox();
            this.myChipsTxt = new System.Windows.Forms.TextBox();
            this.communityCardsTxt = new System.Windows.Forms.TextBox();
            this.tableChipsTxt = new System.Windows.Forms.TextBox();
            this.opponentBetTxt = new System.Windows.Forms.TextBox();
            this.bankRollTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opponent bet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Community Cards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chips on Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your hole cards";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your chips";
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(12, 354);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(191, 56);
            this.resultBtn.TabIndex = 1;
            this.resultBtn.Text = "Get result";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // holeCardsTxt
            // 
            this.holeCardsTxt.Location = new System.Drawing.Point(236, 367);
            this.holeCardsTxt.Name = "holeCardsTxt";
            this.holeCardsTxt.Size = new System.Drawing.Size(155, 31);
            this.holeCardsTxt.TabIndex = 2;
            // 
            // myChipsTxt
            // 
            this.myChipsTxt.Location = new System.Drawing.Point(255, 246);
            this.myChipsTxt.Name = "myChipsTxt";
            this.myChipsTxt.Size = new System.Drawing.Size(123, 31);
            this.myChipsTxt.TabIndex = 2;
            // 
            // communityCardsTxt
            // 
            this.communityCardsTxt.Location = new System.Drawing.Point(373, 150);
            this.communityCardsTxt.Name = "communityCardsTxt";
            this.communityCardsTxt.Size = new System.Drawing.Size(241, 31);
            this.communityCardsTxt.TabIndex = 2;
            // 
            // tableChipsTxt
            // 
            this.tableChipsTxt.Location = new System.Drawing.Point(38, 150);
            this.tableChipsTxt.Name = "tableChipsTxt";
            this.tableChipsTxt.Size = new System.Drawing.Size(241, 31);
            this.tableChipsTxt.TabIndex = 2;
            // 
            // opponentBetTxt
            // 
            this.opponentBetTxt.Location = new System.Drawing.Point(245, 49);
            this.opponentBetTxt.Name = "opponentBetTxt";
            this.opponentBetTxt.Size = new System.Drawing.Size(164, 31);
            this.opponentBetTxt.TabIndex = 2;
            // 
            // bankRollTxt
            // 
            this.bankRollTxt.Location = new System.Drawing.Point(12, 49);
            this.bankRollTxt.Name = "bankRollTxt";
            this.bankRollTxt.Size = new System.Drawing.Size(156, 31);
            this.bankRollTxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bankroll";
            // 
            // ManualPokerBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bankRollTxt);
            this.Controls.Add(this.opponentBetTxt);
            this.Controls.Add(this.tableChipsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.communityCardsTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myChipsTxt);
            this.Controls.Add(this.holeCardsTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.label1);
            this.Name = "ManualPokerBot";
            this.Text = "Manual Poker Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.TextBox holeCardsTxt;
        private System.Windows.Forms.TextBox myChipsTxt;
        private System.Windows.Forms.TextBox communityCardsTxt;
        private System.Windows.Forms.TextBox tableChipsTxt;
        private System.Windows.Forms.TextBox opponentBetTxt;
        private System.Windows.Forms.TextBox bankRollTxt;
        private System.Windows.Forms.Label label6;
    }
}


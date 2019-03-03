namespace Cards
{
    partial class cardsForm
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
            this.cardOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ShffleButton = new System.Windows.Forms.Button();
            this.verifyAnswerButton = new System.Windows.Forms.Button();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.cardTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.cardThreePictureBox = new System.Windows.Forms.PictureBox();
            this.cardFourPictureBox = new System.Windows.Forms.PictureBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardOnePictureBox
            // 
            this.cardOnePictureBox.Location = new System.Drawing.Point(12, 57);
            this.cardOnePictureBox.Name = "cardOnePictureBox";
            this.cardOnePictureBox.Size = new System.Drawing.Size(227, 337);
            this.cardOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardOnePictureBox.TabIndex = 0;
            this.cardOnePictureBox.TabStop = false;
            // 
            // ShffleButton
            // 
            this.ShffleButton.Location = new System.Drawing.Point(760, 16);
            this.ShffleButton.Name = "ShffleButton";
            this.ShffleButton.Size = new System.Drawing.Size(131, 35);
            this.ShffleButton.TabIndex = 4;
            this.ShffleButton.Text = "Shuffle";
            this.ShffleButton.UseVisualStyleBackColor = true;
            this.ShffleButton.Click += new System.EventHandler(this.ShffleButton_Click);
            // 
            // verifyAnswerButton
            // 
            this.verifyAnswerButton.Location = new System.Drawing.Point(760, 403);
            this.verifyAnswerButton.Name = "verifyAnswerButton";
            this.verifyAnswerButton.Size = new System.Drawing.Size(131, 35);
            this.verifyAnswerButton.TabIndex = 5;
            this.verifyAnswerButton.Text = "Verify";
            this.verifyAnswerButton.UseVisualStyleBackColor = true;
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Location = new System.Drawing.Point(296, 409);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(382, 22);
            this.expressionTextBox.TabIndex = 6;
            // 
            // expressionLabel
            // 
            this.expressionLabel.AutoSize = true;
            this.expressionLabel.Location = new System.Drawing.Point(88, 412);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(134, 17);
            this.expressionLabel.TabIndex = 7;
            this.expressionLabel.Text = "Enter an expression";
            // 
            // cardTwoPictureBox
            // 
            this.cardTwoPictureBox.Location = new System.Drawing.Point(245, 57);
            this.cardTwoPictureBox.Name = "cardTwoPictureBox";
            this.cardTwoPictureBox.Size = new System.Drawing.Size(227, 337);
            this.cardTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardTwoPictureBox.TabIndex = 8;
            this.cardTwoPictureBox.TabStop = false;
            // 
            // cardThreePictureBox
            // 
            this.cardThreePictureBox.Location = new System.Drawing.Point(478, 57);
            this.cardThreePictureBox.Name = "cardThreePictureBox";
            this.cardThreePictureBox.Size = new System.Drawing.Size(227, 337);
            this.cardThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardThreePictureBox.TabIndex = 9;
            this.cardThreePictureBox.TabStop = false;
            // 
            // cardFourPictureBox
            // 
            this.cardFourPictureBox.Location = new System.Drawing.Point(711, 57);
            this.cardFourPictureBox.Name = "cardFourPictureBox";
            this.cardFourPictureBox.Size = new System.Drawing.Size(227, 337);
            this.cardFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFourPictureBox.TabIndex = 10;
            this.cardFourPictureBox.TabStop = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(604, 16);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(46, 17);
            this.resultsLabel.TabIndex = 11;
            this.resultsLabel.Text = "label2";
            // 
            // cardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.cardFourPictureBox);
            this.Controls.Add(this.cardThreePictureBox);
            this.Controls.Add(this.cardTwoPictureBox);
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.verifyAnswerButton);
            this.Controls.Add(this.ShffleButton);
            this.Controls.Add(this.cardOnePictureBox);
            this.Name = "cardsForm";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.cardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardOnePictureBox;
        private System.Windows.Forms.Button ShffleButton;
        private System.Windows.Forms.Button verifyAnswerButton;
        private System.Windows.Forms.TextBox expressionTextBox;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.PictureBox cardTwoPictureBox;
        private System.Windows.Forms.PictureBox cardThreePictureBox;
        private System.Windows.Forms.PictureBox cardFourPictureBox;
        private System.Windows.Forms.Label resultsLabel;
    }
}


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
            this.cardOnePictureBox.Location = new System.Drawing.Point(14, 71);
            this.cardOnePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardOnePictureBox.Name = "cardOnePictureBox";
            this.cardOnePictureBox.Size = new System.Drawing.Size(255, 421);
            this.cardOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardOnePictureBox.TabIndex = 0;
            this.cardOnePictureBox.TabStop = false;
            // 
            // ShffleButton
            // 
            this.ShffleButton.Location = new System.Drawing.Point(855, 20);
            this.ShffleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShffleButton.Name = "ShffleButton";
            this.ShffleButton.Size = new System.Drawing.Size(147, 44);
            this.ShffleButton.TabIndex = 4;
            this.ShffleButton.Text = "Shuffle";
            this.ShffleButton.UseVisualStyleBackColor = true;
            this.ShffleButton.Click += new System.EventHandler(this.ShffleButton_Click);
            // 
            // verifyAnswerButton
            // 
            this.verifyAnswerButton.Location = new System.Drawing.Point(855, 504);
            this.verifyAnswerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verifyAnswerButton.Name = "verifyAnswerButton";
            this.verifyAnswerButton.Size = new System.Drawing.Size(147, 44);
            this.verifyAnswerButton.TabIndex = 5;
            this.verifyAnswerButton.Text = "Verify";
            this.verifyAnswerButton.UseVisualStyleBackColor = true;
            this.verifyAnswerButton.Click += new System.EventHandler(this.verifyAnswerButton_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Location = new System.Drawing.Point(333, 511);
            this.expressionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(429, 26);
            this.expressionTextBox.TabIndex = 6;
            this.expressionTextBox.TextChanged += new System.EventHandler(this.expressionTextBox_TextChanged);
            // 
            // expressionLabel
            // 
            this.expressionLabel.AutoSize = true;
            this.expressionLabel.Location = new System.Drawing.Point(99, 515);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(150, 20);
            this.expressionLabel.TabIndex = 7;
            this.expressionLabel.Text = "Enter an expression";
            // 
            // cardTwoPictureBox
            // 
            this.cardTwoPictureBox.Location = new System.Drawing.Point(276, 71);
            this.cardTwoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardTwoPictureBox.Name = "cardTwoPictureBox";
            this.cardTwoPictureBox.Size = new System.Drawing.Size(255, 421);
            this.cardTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardTwoPictureBox.TabIndex = 8;
            this.cardTwoPictureBox.TabStop = false;
            // 
            // cardThreePictureBox
            // 
            this.cardThreePictureBox.Location = new System.Drawing.Point(538, 71);
            this.cardThreePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardThreePictureBox.Name = "cardThreePictureBox";
            this.cardThreePictureBox.Size = new System.Drawing.Size(255, 421);
            this.cardThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardThreePictureBox.TabIndex = 9;
            this.cardThreePictureBox.TabStop = false;
            // 
            // cardFourPictureBox
            // 
            this.cardFourPictureBox.Location = new System.Drawing.Point(800, 71);
            this.cardFourPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardFourPictureBox.Name = "cardFourPictureBox";
            this.cardFourPictureBox.Size = new System.Drawing.Size(255, 421);
            this.cardFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFourPictureBox.TabIndex = 10;
            this.cardFourPictureBox.TabStop = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(680, 20);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(51, 20);
            this.resultsLabel.TabIndex = 11;
            this.resultsLabel.Text = "label2";
            // 
            // cardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 562);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.cardFourPictureBox);
            this.Controls.Add(this.cardThreePictureBox);
            this.Controls.Add(this.cardTwoPictureBox);
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.verifyAnswerButton);
            this.Controls.Add(this.ShffleButton);
            this.Controls.Add(this.cardOnePictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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


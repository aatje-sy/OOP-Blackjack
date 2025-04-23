namespace oopBlackjack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dealCardsButton = new Button();
            confirmTurnButton = new Button();
            cardsShuffleButton = new Button();
            DealerCards = new Button();
            SuspendLayout();
            // 
            // dealCardsButton
            // 
            dealCardsButton.BackColor = SystemColors.ButtonHighlight;
            dealCardsButton.BackgroundImageLayout = ImageLayout.None;
            dealCardsButton.Font = new Font("Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealCardsButton.ForeColor = Color.Black;
            dealCardsButton.Location = new Point(1094, 428);
            dealCardsButton.Name = "dealCardsButton";
            dealCardsButton.Size = new Size(115, 74);
            dealCardsButton.TabIndex = 0;
            dealCardsButton.Text = "Deal Cards";
            dealCardsButton.UseVisualStyleBackColor = false;
            dealCardsButton.Click += DealCards_Button;
            // 
            // confirmTurnButton
            // 
            confirmTurnButton.BackColor = SystemColors.ButtonHighlight;
            confirmTurnButton.BackgroundImageLayout = ImageLayout.None;
            confirmTurnButton.Font = new Font("Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmTurnButton.ForeColor = Color.Black;
            confirmTurnButton.Location = new Point(169, 520);
            confirmTurnButton.Name = "confirmTurnButton";
            confirmTurnButton.Size = new Size(115, 74);
            confirmTurnButton.TabIndex = 1;
            confirmTurnButton.Text = "Confirm";
            confirmTurnButton.UseVisualStyleBackColor = false;
            confirmTurnButton.Click += ConfirmButton;
            // 
            // cardsShuffleButton
            // 
            cardsShuffleButton.BackColor = SystemColors.ButtonHighlight;
            cardsShuffleButton.BackgroundImageLayout = ImageLayout.None;
            cardsShuffleButton.Font = new Font("Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardsShuffleButton.ForeColor = Color.Black;
            cardsShuffleButton.Location = new Point(1094, 520);
            cardsShuffleButton.Name = "cardsShuffleButton";
            cardsShuffleButton.Size = new Size(115, 74);
            cardsShuffleButton.TabIndex = 2;
            cardsShuffleButton.Text = "Shuffle";
            cardsShuffleButton.UseVisualStyleBackColor = false;
            cardsShuffleButton.Click += cardsShuffleButton_Click;
            // 
            // DealerCards
            // 
            DealerCards.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DealerCards.Location = new Point(32, 519);
            DealerCards.Name = "DealerCards";
            DealerCards.Size = new Size(115, 74);
            DealerCards.TabIndex = 3;
            DealerCards.Text = "Dealer Cards";
            DealerCards.UseVisualStyleBackColor = true;
            DealerCards.Click += DealerCards_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 634);
            Controls.Add(DealerCards);
            Controls.Add(cardsShuffleButton);
            Controls.Add(confirmTurnButton);
            Controls.Add(dealCardsButton);
            Name = "Form1";
            Text = "baseTable";
            ResumeLayout(false);
        }

        #endregion

        private Button dealCardsButton;
        private Button confirmTurnButton;
        private Button cardsShuffleButton;
        private Button DealerCards;
    }
}

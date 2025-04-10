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
            Clubs10 = new PictureBox();
            Clubs2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Clubs10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Clubs2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dealCardsButton
            // 
            dealCardsButton.BackColor = SystemColors.ButtonHighlight;
            dealCardsButton.BackgroundImageLayout = ImageLayout.None;
            dealCardsButton.Font = new Font("Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealCardsButton.ForeColor = Color.Black;
            dealCardsButton.Location = new Point(1094, 408);
            dealCardsButton.Name = "dealCardsButton";
            dealCardsButton.Size = new Size(115, 74);
            dealCardsButton.TabIndex = 0;
            dealCardsButton.Text = "Deal Cards";
            dealCardsButton.UseVisualStyleBackColor = false;
            dealCardsButton.Click += button1_Click;
            // 
            // confirmTurnButton
            // 
            confirmTurnButton.BackColor = SystemColors.ButtonHighlight;
            confirmTurnButton.BackgroundImageLayout = ImageLayout.None;
            confirmTurnButton.Font = new Font("Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmTurnButton.ForeColor = Color.Black;
            confirmTurnButton.Location = new Point(957, 520);
            confirmTurnButton.Name = "confirmTurnButton";
            confirmTurnButton.Size = new Size(115, 74);
            confirmTurnButton.TabIndex = 1;
            confirmTurnButton.Text = "Confirm";
            confirmTurnButton.UseVisualStyleBackColor = false;
            confirmTurnButton.Click += button2_Click;
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
            // 
            // Clubs10
            // 
            Clubs10.BorderStyle = BorderStyle.Fixed3D;
            Clubs10.Image = Properties.Resources.white_c_10;
            Clubs10.Location = new Point(127, 361);
            Clubs10.Name = "Clubs10";
            Clubs10.Size = new Size(142, 192);
            Clubs10.TabIndex = 3;
            Clubs10.TabStop = false;
            Clubs10.Click += pictureBox1_Click;
            // 
            // Clubs2
            // 
            Clubs2.BorderStyle = BorderStyle.Fixed3D;
            Clubs2.Image = Properties.Resources.white_c_2;
            Clubs2.Location = new Point(295, 361);
            Clubs2.Name = "Clubs2";
            Clubs2.Size = new Size(142, 192);
            Clubs2.TabIndex = 4;
            Clubs2.TabStop = false;
            Clubs2.Click += Clubs2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.white_c_3;
            pictureBox1.Location = new Point(469, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 192);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 634);
            Controls.Add(pictureBox1);
            Controls.Add(Clubs2);
            Controls.Add(Clubs10);
            Controls.Add(cardsShuffleButton);
            Controls.Add(confirmTurnButton);
            Controls.Add(dealCardsButton);
            Name = "Form1";
            Text = "baseTable";
            ((System.ComponentModel.ISupportInitialize)Clubs10).EndInit();
            ((System.ComponentModel.ISupportInitialize)Clubs2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button dealCardsButton;
        private Button confirmTurnButton;
        private Button cardsShuffleButton;
        private PictureBox Clubs10;
        private PictureBox Clubs2;
        private PictureBox pictureBox1;
    }
}

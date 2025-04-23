namespace oopBlackjack
{
    using oopBlackjack.Classes;

    public partial class Form1 : Form
    {
        Game game;
        Dealer dealer;
        Player player;


        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.deck = new Deck();
            dealer = new Dealer();
            player = new Player();

        }

        private void DealCards_Button(object sender, EventArgs e)
        {
            dealer.DealToPlayer(player);
            MessageBox.Show("Player received two cards:");
        }

        private void ConfirmButton(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clubs2_Click(object sender, EventArgs e)
        {

        }

        private void cardsShuffleButton_Click(object sender, EventArgs e)
        {
            game.deck.shuffleCards();
            MessageBox.Show("Kaarten zijn geschud!");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DealerCards_Click(object sender, EventArgs e)
        {
            dealer.DealToSelf();
            MessageBox.Show("Dealer received one visible card and one hidden.");
        }
    }
}

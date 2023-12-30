using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        private Stack<string> deck = new Stack<string>();
        private List<string> playerHand = new List<string>();
        private List<string> dealerHand = new List<string>();
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeDeck();
            DealInitialCards();
        }

        private void InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    deck.Push(value + " of " + suit);
                }
            }

            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            var shuffledDeck = deck.ToArray();
            int n = shuffledDeck.Length;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                var value = shuffledDeck[k];
                shuffledDeck[k] = shuffledDeck[n];
                shuffledDeck[n] = value;
            }
            deck = new Stack<string>(shuffledDeck);
        }

        private void DealInitialCards()
        {
            playerHand.Add(DealCard());
            dealerHand.Add(DealCard());
            playerHand.Add(DealCard());
            dealerHand.Add(DealCard());

            UpdateUI();
        }

        private string DealCard()
        {
            if (deck.Count > 0)
                return deck.Pop();
            else
                throw new InvalidOperationException("Deck is empty.");
        }

        private void UpdateUI()
        {
            playerCardsLabel.Text = string.Join("\n", playerHand);
            playerScoreLabel.Text = "Score: " + CalculateScore(playerHand);

            dealerCardsLabel.Text = string.Join("\n", dealerHand);
            dealerScoreLabel.Text = "Score: " + CalculateScore(dealerHand);
        }

        private int CalculateScore(List<string> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (string card in hand)
            {
                string value = card.Split(' ')[0];
                if (value == "A")
                {
                    aceCount++;
                    score += 11;
                }
                else if (value == "K" || value == "Q" || value == "J")
                {
                    score += 10;
                }
                else
                {
                    score += int.Parse(value);
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            playerHand.Add(DealCard());
            UpdateUI();

            if (CalculateScore(playerHand) > 21)
            {
                MessageBox.Show("Player busts! Dealer wins!");
                EndGame();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            while (CalculateScore(dealerHand) < 17)
            {
                dealerHand.Add(DealCard());
            }

            UpdateUI();

            int playerScore = CalculateScore(playerHand);
            int dealerScore = CalculateScore(dealerHand);

            if (dealerScore > 21 || playerScore > dealerScore)
            {
                MessageBox.Show("Player wins!");
            }
            else if (playerScore < dealerScore)
            {
                MessageBox.Show("Dealer wins!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
            EndGame();
        }

        private void EndGame()
        {
            HitButton.Enabled = false;
            StandButton.Enabled = false;

            var result = MessageBox.Show("Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                Close();
            }
        }

        private void RestartGame()
        {
            deck.Clear();
            playerHand.Clear();
            dealerHand.Clear();

            InitializeDeck();
            DealInitialCards();

            HitButton.Enabled = true;
            StandButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Blackjack game!");
        }

        private void playerScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

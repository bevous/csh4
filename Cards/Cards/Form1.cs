using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    using System.Drawing.Drawing2D;

    public partial class cardsForm : Form
    {
        private List<Card> Deck { get; set; } = new List<Card>();

        private static readonly Bitmap CardBack = new Bitmap(@"images\backCard.png");

        Stack<Card> currentCards = new Stack<Card>();

        Stack<Card> usedCards = new Stack<Card>();

        private int numberOfShuffles = 0;
        
        public cardsForm()
        {
            this.InitializeComponent();
        }

        private void MakeDeck()
        {
            var cardValue = 1;
            var suitType = 1;
            for (var imageNumber = 1; imageNumber <= 52; imageNumber++)
            {
                string fileName = $@"images\{imageNumber:G}.png";
                var image = new Bitmap(fileName);
                if (cardValue > 13)
                {
                    cardValue = 1;
                    suitType++;
                }//else, DoNothing();

                if (suitType == 1)
                {
                    this.Deck.Add(new Card { Value = cardValue, Suit = "Spade", CardFace = image });
                }
                else if (suitType == 2)
                {
                    this.Deck.Add(new Card { Value = cardValue, Suit = "Heart", CardFace = image });
                }
                else if (suitType == 3)
                {
                    this.Deck.Add(new Card { Value = cardValue, Suit = "Diamond", CardFace = image });
                }
                else if (suitType == 4)
                {
                    this.Deck.Add(new Card { Value = cardValue, Suit = "Club", CardFace = image });
                }
            }
        }

        private void ShffleButton_Click(object sender, EventArgs e)
        {
            if (this.numberOfShuffles == 12)
            {
                this.numberOfShuffles = 0;
                this.currentCards.Clear();
                this.usedCards.Clear();
            }
           var numberRandom = new Random();
           this.currentCards.Clear();
           while (this.currentCards.Count < 4)
           {
               int cardChosen = numberRandom.Next(0, 51);
               if (!this.currentCards.Contains(this.Deck[cardChosen]) && !this.usedCards.Contains(this.Deck[cardChosen]))
               {
                    this.currentCards.Push(this.Deck[cardChosen]);
               } // else, card is already used doNothing();
           }

           this.numberOfShuffles++;

            this.cardOnePictureBox.Image = this.currentCards.Peek().CardFace;
           this.usedCards.Push(this.currentCards.Pop());
           this.cardTwoPictureBox.Image = this.currentCards.Peek().CardFace;
           this.usedCards.Push(this.currentCards.Pop());
           this.cardThreePictureBox.Image = this.currentCards.Peek().CardFace;
           this.usedCards.Push(this.currentCards.Pop());
           this.cardFourPictureBox.Image = this.currentCards.Peek().CardFace;
           this.usedCards.Push(this.currentCards.Pop());
        }

        private void cardsForm_Load(object sender, EventArgs e)
        {
            this.MakeDeck();
            this.cardOnePictureBox.Image = CardBack;
            this.cardTwoPictureBox.Image = CardBack;
            this.cardThreePictureBox.Image = CardBack;
            this.cardFourPictureBox.Image = CardBack;
            this.verifyAnswerButton.Hide();
        }

        private void verifyAnswerButton_Click(object sender, EventArgs e)
        {
            Stack<char> operatorStack = new Stack<char>();

            Stack<int> numberStack = new Stack<int>();
        }

        private void expressionTextBox_TextChanged(object sender, EventArgs e)
        {
            var validCharacters = "0123456789+-*/() ";
            validCharacters.ToCharArray();
           
            var isvalid = false;
            foreach (var character in this.expressionTextBox.Text)
            {
                var index = 0;
                while (index < validCharacters.Length && !(isvalid = character == validCharacters[index]))
                {
                    index++;
                }
                if (!isvalid)
                {
                    this.expressionTextBox.BackColor = Color.Red;
                    this.verifyAnswerButton.Hide();
                    return;
                }
                else
                {
                    this.expressionTextBox.BackColor = Color.White;
                    this.verifyAnswerButton.Show();
                }
                
            }


        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   The cards form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Windows.Forms;

    /// <summary>
    /// The cards form.
    /// </summary>
    public partial class cardsForm : Form
    {
        /// <summary>
        /// The card back.
        /// </summary>
        private static readonly Bitmap CardBack = new Bitmap(@"images\backCard.png");

        /// <summary>
        /// The current cards.
        /// </summary>
        private readonly Stack<Card> currentCards = new Stack<Card>();

        /// <summary>
        /// The used cards.
        /// </summary>
        private readonly Stack<Card> usedCards = new Stack<Card>();

        /// <summary>
        /// The number of shuffles.
        /// </summary>
        private int numberOfShuffles;
        /// <summary>
        /// the largest value a card can have.
        /// </summary>
        private const int CardMaxValue = 13;

        /// <summary>
        /// The number of cards in the deck.
        /// </summary>
        private const int NumberOfCards = 52;

        /// <summary>
        /// The number one.
        /// </summary>
        private const int One = 1;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="cardsForm"/> class.
        /// </summary>
        public cardsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the deck.
        /// </summary>
        private List<Card> Deck { get; } = new List<Card>();

        private void VerifyExpression()
        {

        }

        /// <summary>
        /// The cards form_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void cardsForm_Load(object sender, EventArgs e)
        {
            this.MakeDeck();
            this.cardOnePictureBox.Image = CardBack;
            this.cardTwoPictureBox.Image = CardBack;
            this.cardThreePictureBox.Image = CardBack;
            this.cardFourPictureBox.Image = CardBack;
            this.verifyAnswerButton.Hide();
        }

        /// <summary>
        /// The expression text box_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void expressionTextBox_TextChanged(object sender, EventArgs e)
        {
            var validCharacters = "0123456789+-*/()";
            validCharacters.ToCharArray();
            string temp = string.Empty;
            var isValid = false;
            foreach (var character in this.expressionTextBox.Text)
            {
                var index = 0;
                while (index < validCharacters.Length && !(isValid = character == validCharacters[index]))
                {
                    index++;
                }
                if (!isValid || !areNumbersGood(this.expressionTextBox.Text))
                {
                    this.expressionTextBox.BackColor = Color.Red;
                    this.verifyAnswerButton.Hide();
                    return;
                }
                
                this.expressionTextBox.BackColor = Color.White;
                this.verifyAnswerButton.Show();
            }
        }

        /// <summary>
        /// checks that there are no numbers larger than 2 digits.
        /// </summary>
        /// <param name="expression">
        /// The expression.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool areNumbersGood(string expression)
        {
            
            bool IsNumber(char character)
            {
                return int.TryParse(character.ToString(),out int number);
            }

            int IsNumberInRange(char character)
            {
                int.TryParse(character.ToString(), out var value);
                return value;
            }
            
            for (int index = 0; index < expression.Length; index++)
            {
                if ((index - One) >= 0 && (index + One) < expression.Length)
                {
                    if (IsNumber(expression[index - One]) &&
                        IsNumber(expression[index + One]) &&
                        IsNumber(expression[index]))
                    {
                        return false;
                    }//else, doNothing();
                    if (IsNumber(expression[index]) && IsNumber(expression[index - One]) && !IsNumber(expression[index + One]))
                    {
                        if (IsNumberInRange(expression[index - One]) <= One && IsNumberInRange(expression[index]) <= 3)
                        {

                        }
                    }//else, doNothing();

                }//else, doNothing();

            }

            return true;
        }

        /// <summary>
        /// The make deck.
        /// </summary>
        private void MakeDeck()
        {
            var cardValue = One;
            var suitType = One;
            for (var imageNumber = One; imageNumber <= NumberOfCards; imageNumber++)
            {
                var fileName = $@"images\{imageNumber:G}.png";
                var image = new Bitmap(fileName);
                if (cardValue > CardMaxValue)
                {
                    cardValue = One;
                    suitType++;
                }

                switch (suitType)
                {
                    // else, DoNothing();
                    case 1:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Spade", CardFace = image });
                        break;
                    case 2:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Heart", CardFace = image });
                        break;
                    case 3:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Diamond", CardFace = image });
                        break;
                    case 4:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Club", CardFace = image });
                        break;
                    default:
                        //something is wrong doNothing();
                        break;
                }
            }
        }

        /// <summary>
        /// The shuffle button_ click event handler.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
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
                var cardChosen = numberRandom.Next(0, 51);
                if (!this.currentCards.Contains(this.Deck[cardChosen])
                    && !this.usedCards.Contains(this.Deck[cardChosen]))
                {
                    this.currentCards.Push(this.Deck[cardChosen]);
                }
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

        /// <summary>
        /// The verify answer button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void verifyAnswerButton_Click(object sender, EventArgs e)
        {
            var operatorStack = new Stack<char>();

            var numberStack = new Stack<int>();
        }
    }
}
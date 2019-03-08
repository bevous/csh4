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
    using System.Data;
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
        /// The zero.
        /// </summary>
        private const int Zero = 0;

        /// <summary>
        /// The number one.
        /// </summary>
        private const int One = 1;

        /// <summary>
        /// The two.
        /// </summary>
        private const int Two = 2;

        /// <summary>
        /// The three.
        /// </summary>
        private const int Three = 3;

        /// <summary>
        /// The four.
        /// </summary>
        private const int Four = 4;

        /// <summary>
        /// The ten.
        /// </summary>
        private const int Ten = 10;

        /// <summary>
        /// The goal.
        /// </summary>
        private const int Goal = 24;


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
            bool areNumbersGood(string expression)
            {

                bool IsNumber(char character)
                {
                    return int.TryParse(character.ToString(), out int number);
                }

                bool IsNumberInRange(int number)
                {
                    foreach (var card in this.currentCards)
                    {
                        if (card.Value == number)
                        {
                            return true;
                        }
                    }

                    return false;
                }

                List<int> usedInts = new List<int>();

                for (int index = 0; index < expression.Length; index++)
                {
                    if (IsNumber(expression[index]))
                    {
                        if ((index + One) < expression.Length && IsNumber(expression[index + One]))
                        {
                            if ((index + One + One) < expression.Length && IsNumber(expression[index + One + One]))
                            {
                                return false;
                            }

                            var number = (int.Parse(expression[index].ToString()) * Ten) + int.Parse(expression[index + One].ToString());
                            if (!IsNumberInRange(number))
                            {
                                return false;
                            }

                            //if (usedInts.Contains(number))
                            //{
                            //    return false;
                            //}
                            //usedInts.Add(number);
                            index++;
                        }
                        else
                        {
                            var number = int.Parse(expression[index].ToString());
                            if (!IsNumberInRange(number))
                            {
                                return false;
                            }

                            //if (usedInts.Contains(number))
                            //{
                            //    return false;
                            //}
                            //usedInts.Add(number);
                            index++;
                        }
                    }
                }

                return true;
            }

            bool areCharactersValid()
            {
                var validCharacters = "0123456789+-*/()";
                validCharacters.ToCharArray();
                string temp = string.Empty;
                var isValid = false;
                foreach (var character in this.expressionTextBox.Text)
                {
                    var index = Zero;
                    while (index < validCharacters.Length && !(isValid = character == validCharacters[index]))
                    {
                        index++;
                    }

                    if (!isValid)
                    {
                        return false;
                    }
                }

                return isValid;
            }

            bool areOperatorsGood()
            {
                var operators = "+-*/";
                var expression = this.expressionTextBox.Text;

                bool isOperator(char character)
                {
                    for (var operatorIndex = Zero; operatorIndex < operators.Length; operatorIndex++)
                    {
                        if (character == operators[operatorIndex])
                        {
                            return true;
                        }
                    }
                
                    return false;
                }

                for (int index = Zero; index < expression.Length; index++)
                {
                    if (isOperator(expression[index]))
                    {
                        if ((index + One) < expression.Length && isOperator(expression[index + One]))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            bool areWrapsClosed()
            {

                var wraps = "()";
                var expressionText = this.expressionTextBox.Text;

                bool closed(string expression, out string newExpression)
                {
                    for (int index = Zero; index < expression.Length; index++)
                    {
                        if (expression[index] == wraps[Zero])
                        {
                            expression = expression.Remove(index, One);
                            for (int charIndex = Zero; charIndex < expression.Length; charIndex++)
                            {
                                if (expression[charIndex] == wraps[One])
                                {
                                    newExpression = expression = expression.Remove(charIndex, One);

                                    return true;
                                }
                            }
                        }
                        
                    }
                    newExpression = string.Empty;
                    return false;
                } 

                bool hasWraps(string expression)
                {
                    for (int index = Zero; index < expression.Length; index++)
                    {
                        if (expression[index] == wraps[Zero])
                        {
                            return true;
                        }

                        if (expression[index] == wraps[One])
                        {
                            return true;
                        }
                    }

                    return false;
                }

                while (hasWraps(expressionText))
                {
                    if (!closed(expressionText, out var newExpression))
                    {
                        return false;
                    }

                    expressionText = newExpression;
                    if (!areNumbersGood(expressionText) || !areOperatorsGood())
                    {
                        return false;
                    }
                }

                return true;
            }

            this.changeColor();

            if (!areCharactersValid() || !areNumbersGood(this.expressionTextBox.Text) || !areOperatorsGood() || !areWrapsClosed())
            {
                this.expressionTextBox.BackColor = Color.Red;
                this.verifyAnswerButton.Hide();
                return;
            }

            this.expressionTextBox.BackColor = Color.White;
            this.verifyAnswerButton.Show();
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
                    case One:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Spade", CardFace = image });
                        break;
                    case Two:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Heart", CardFace = image });
                        break;
                    case Three:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Diamond", CardFace = image });
                        break;
                    case Four:
                        this.Deck.Add(new Card { Value = cardValue, Suit = "Club", CardFace = image });
                        break;
                    default:
                        //something is wrong doNothing();
                        break;
                }

                cardValue++;
            }
        }

        /// <summary>
        /// The change color.
        /// </summary>
        private void changeColor()
        {
            if (this.BackColor.Equals(Color.Red))
            {
                this.BackColor = Color.White;
                this.resultsLabel.Text = string.Empty;
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
            this.changeColor();
            this.expressionTextBox.Text = string.Empty;
            if (this.numberOfShuffles == 12)
            {
                this.numberOfShuffles = Zero;
                this.currentCards.Clear();
                this.usedCards.Clear();
            }

            var numberRandom = new Random();
            this.currentCards.Clear();
            while (this.currentCards.Count < Four)
            {
                var cardChosen = numberRandom.Next(Zero, NumberOfCards - One);
                if (!this.currentCards.Contains(this.Deck[cardChosen])
                    && !this.usedCards.Contains(this.Deck[cardChosen]))
                {
                    this.currentCards.Push(this.Deck[cardChosen]);
                    this.usedCards.Push(this.Deck[cardChosen]);
                }
            }

            this.numberOfShuffles++;
            var tempCurrentCards = this.currentCards.ToArray();
            this.cardOnePictureBox.Image = tempCurrentCards[Zero].CardFace;
            this.cardTwoPictureBox.Image = tempCurrentCards[One].CardFace;
            this.cardThreePictureBox.Image = tempCurrentCards[Two].CardFace;
            this.cardFourPictureBox.Image = tempCurrentCards[Three].CardFace;
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

            bool verifyExpression()
            {
               var expresion = this.expressionTextBox.Text;
                Stack<int> numberStack = new Stack<int>();
                Stack<char> operatorStack=new Stack<char>();

                Stack<int> GetInts(string expression)
                {
                    Stack<int> numbers = new Stack<int>();
                    bool IsNumber(char character)
                    {
                        return int.TryParse(character.ToString(), out int number);
                    }

                    bool IsNumberInRange(int number)
                    {
                        foreach (var card in this.currentCards)
                        {
                            if (card.Value == number)
                            {
                                return true;
                            }
                        }

                        return false;
                    }

                    List<int> usedInts = new List<int>();

                    for (int index = expression.Length - One; index >= Zero; index--)
                    {
                        if (IsNumber(expression[index]))
                        {
                            if ((index - One) < expression.Length && IsNumber(expression[index - One]))
                            {
                                var number = (int.Parse(expression[index - One].ToString()) * Ten)
                                             + int.Parse(expression[index].ToString());
                                if (IsNumberInRange(number))
                                {
                                    numbers.Push(number);
                                }
                                index--;
                            }
                            else
                            {
                                var number = int.Parse(expression[index].ToString());
                                if (IsNumberInRange(number))
                                {
                                    numbers.Push(number);
                                }

                                index--;
                            }
                        }
                    }

                    return numbers;
                }

                Stack<char> GetOperators(string expression)
                {
                    Stack<char> grabedOperators =new Stack<char>();
                    
                    bool isOperator(char character)
                    {
                        var operators = "+-*/()";
                        for (var operatorIndex = Zero; operatorIndex < operators.Length; operatorIndex++)
                        {
                            if (character == operators[operatorIndex])
                            {
                                return true;
                            }
                        }

                        return false;
                    }

                    for (int index = expression.Length - One; index >= Zero; index--)
                    {
                        if (isOperator(expression[index]))
                        {
                            grabedOperators.Push(expression[index]);
                        }
                    }

                    return grabedOperators;
                }

                numberStack = GetInts(expresion);
                operatorStack = GetOperators(expresion);

                double processOperations(double left, int right, char currentOperator)
                {
                    
                    switch (currentOperator)
                    {
                        case '+': return left + (double)right;
                        case '-': return left - (double)right;
                        case '*': return left * (double)right;
                        case '/': return left / (double)right;
                    }

                    return double.MaxValue;
                }

                var answer = 0.0;
                while (operatorStack.Count > Zero && numberStack.Count > Zero)
                {
                    
                    if (operatorStack.Peek() == '(')
                    {
                        operatorStack.Pop();
                        
                        while (operatorStack.Peek() != ')')
                        {
                            
                            if (operatorStack.Count > Zero && numberStack.Count > Zero)
                            {
                                var wrappedAnswer = processOperations(numberStack.Pop(), numberStack.Pop(), operatorStack.Pop());
                                numberStack.Push((int)wrappedAnswer);
                            }
                            
                        }

                        operatorStack.Pop();
                    }
                    else
                    {
                        if (operatorStack.Count > Zero && numberStack.Count > Zero)
                        {
                            answer = processOperations(numberStack.Pop(), numberStack.Pop(), operatorStack.Pop());
                            numberStack.Push((int)answer);
                        }
                    }
                }

                return answer.Equals(Goal);
            }

            if (verifyExpression())
            {
                this.BackColor = Color.Green;
                this.resultsLabel.Text = @"Correct";
            }
            else
            {
                this.BackColor = Color.Red;
                this.resultsLabel.Text = @"Incorrect";
            }
            
        }
    }
}
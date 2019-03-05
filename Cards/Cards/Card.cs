// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Card.cs" company="">
//   
// </copyright>
// <summary>
//   The card.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Cards
{
    using System.Drawing;

    /// <summary>
    /// The card.
    /// </summary>
    internal class Card
    {
        /// <summary>
        /// The suit.
        /// </summary>
        private string suit;

        /// <summary>
        /// The value.
        /// </summary>
        private int value;

        /// <summary>
        /// Gets or sets the card face.
        /// </summary>
        public Bitmap CardFace { get; set; }

        /// <summary>
        /// Gets or sets the suit.
        /// </summary>
        public string Suit
        {
            get => this.suit;

            set => this.suit = value ?? string.Empty;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value
        {
            get => this.value;

            set => this.value = value > 0 ? value : int.MaxValue;
        }
    }
}
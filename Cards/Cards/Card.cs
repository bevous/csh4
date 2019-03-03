namespace Cards
{
    using System.Drawing;

    class Card
    {
        private int value;
        
        private string suit;
        
        public int Value
        {
            get => this.value;

            set => this.value = (value > 0) ? value : int.MaxValue;
        }

        public string Suit
        {
            get => this.suit;

            set => this.suit = value ?? string.Empty;
        }


        public Bitmap CardFace { get; set; }
    }
}

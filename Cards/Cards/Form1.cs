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
    public partial class cardsForm : Form
    {
        private List<Card> Deck { get; set; } = new List<Card>();

        private static readonly Bitmap CardBack = new Bitmap(@"images\backCard.png");

        public cardsForm()
        {
            this.InitializeComponent();
        }

        private void MakeDeck()
        {
            for (var imageNumber = 1; imageNumber <= 52; imageNumber++)
            {
                string fileName = $@"images\{imageNumber:G}.png";
                var image = new Bitmap(fileName);
                this.Deck.Add(new Card { Value = imageNumber, Suit = "spade", CardFace = image });
            }
        }

        private void ShffleButton_Click(object sender, EventArgs e)
        {
            this.MakeDeck();
        }

        private void cardsForm_Load(object sender, EventArgs e)
        {
            this.MakeDeck();
            this.cardOnePictureBox.Image=this.ca
        }
    }
}

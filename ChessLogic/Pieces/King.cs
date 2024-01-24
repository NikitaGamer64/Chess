using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class King(Player color) : Piece
    //Код для короля
    {
        public override PieceType Type => PieceType.King;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            King copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
    }
}
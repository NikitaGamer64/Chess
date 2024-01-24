using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Queen(Player color) : Piece
    //Код для ферзя
    {
        public override PieceType Type => PieceType.Queen;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            Queen copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Knight(Player color) : Piece
    //Код для коня
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            Knight copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Bishop(Player color) : Piece
    //Код для слона
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            Bishop copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
    }
}
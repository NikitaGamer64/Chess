using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class NormalMove(Position from, Position to) : Move
    //Простой ход из точки A в точку B
    {
        public override MoveType Type => MoveType.Normal;
        public override Position FromPos { get; } = from;
        public override Position ToPos { get; } = to;

        public override bool Execute(Board board)
        {
            Piece piece = board[FromPos];
            bool capture = !board.IsEmpty(ToPos);
            board[ToPos] = piece;
            board[FromPos] = null;
            piece.HasMoved = true;

            return capture || piece.Type == PieceType.Pawn;
        }
    }
}

﻿namespace ChessLogic
{
    public class EnPassant(Position from, Position to) : Move
    {
        public override MoveType Type => MoveType.EnPassant;
        public override Position FromPos { get; } = from;
        public override Position ToPos { get; } = to;

        private readonly Position capturePos = new(from.Row, from.Column);

        public override bool Execute(Board board)
        {
            new NormalMove(FromPos, ToPos).Execute(board);
            board[capturePos] = null;

            return true;
        }
    }
}
﻿namespace ChessLogic
{
    public abstract class Move
    {
        public abstract MoveType Type { get; }
        //Тип хода
        public abstract Position FromPos { get; }
        //Поле, с которого сошла фигура
        public abstract Position ToPos { get; }
        //Поле, на которое пошла фигура

        public abstract bool Execute(Board board);
        public virtual bool IsLegal(Board board)
        {
            Player player = board[FromPos].Color;
            Board boardCopy = board.Copy();
            Execute(boardCopy);
            return !boardCopy.IsInCheck(player);
        }
    }
}

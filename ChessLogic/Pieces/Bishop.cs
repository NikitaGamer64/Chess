namespace ChessLogic
{
    public class Bishop(Player color) : Piece
    //Код для слона
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; } = color;
        private static readonly Direction[] dirs =
        [
            Direction.NorthWest,
            Direction.NorthEast,
            Direction.SouthWest,
            Direction.SouthEast
        ];

        public override Piece Copy()
        {
            Bishop copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
namespace ChessLogic
{
    public class Queen(Player color) : Piece
    //Код для ферзя
    {
        public override PieceType Type => PieceType.Queen;
        public override Player Color { get; } = color;
        private static readonly Direction[] dirs =
        [
            Direction.North,
            Direction.South,
            Direction.East,
            Direction.West,
            Direction.NorthWest,
            Direction.NorthEast,
            Direction.SouthWest,
            Direction.SouthEast
        ];

        public override Piece Copy()
        {
            Queen copy = new(Color)
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
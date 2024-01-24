namespace ChessLogic
{
    public class Rook(Player color) : Piece
    //Код для ладьи
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            Rook copy = new(Color)
            {
                HasMoved = HasMoved
            };
            return copy;
        }
    }
}
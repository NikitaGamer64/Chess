namespace ChessLogic
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        //Тип фигуры
        public abstract Player Color { get; }
        //Цвет фигуры
        public bool HasMoved { get; set; } = false;
        //Ходила ли фигура ранее
        public abstract Piece Copy();
        //Предварительное моделирование хода, сделанного фигурой
    }
}
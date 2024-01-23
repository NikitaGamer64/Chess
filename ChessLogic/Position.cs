namespace ChessLogic
{
    public class Position(int row, int column)
    //Клетка, на которой стоит фигура
    {
        public int Row { get; } = row;
        public int Column { get; } = column;
        //(0,0) — это поле a8 вверху слева. Координаты увеличиваются по направлению вправо и вниз.

        public Player SquareColor()
        //Цвет поля
        {
            if ((Row + Column) % 2 == 0)
            {
                return Player.White;
            }
            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
        public static Position operator +(Position pos, Direction dir)
        //Перемещение на 1 клетку в заданном направлении
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
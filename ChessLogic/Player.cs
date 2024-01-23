namespace ChessLogic
{
    public enum Player
    //Игроки и цвета фигур
    {
        None, White, Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        //Инициализация противника
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
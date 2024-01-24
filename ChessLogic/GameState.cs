using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class GameState(Player player, Board board)
    {
        public Board Board { get; } = board;
        //Конфигурация доски
        public Player CurrentPlayer { get; private set; } = player;
        //Чей ход
    }
}
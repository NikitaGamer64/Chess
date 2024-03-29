﻿using ChessLogic;
using System.Windows;
using System.Windows.Controls;

namespace ChessUI
{
    public partial class GameOverMenu : UserControl
    {
        public event Action<Option> OptionSelected;
        public GameOverMenu(GameState gameState)
        {
            InitializeComponent();
            Result result = gameState.Result;
            WinnerText.Text = GetWinnerText(result.Winner);
            ReasonText.Text = GetReasonText(result.Reason, gameState.CurrentPlayer);
        }

        private static string GetWinnerText(Player winner)
        {
            return winner switch
            {
                Player.White => "Победа белых",
                Player.Black => "Победа чёрных",
                _ => "Ничья"
            };
        }
        private static string PlayerString1(Player player)
        {
            return player switch
            {
                Player.White => "белым",
                Player.Black => "чёрным",
                _ => ""
            };
        }
        private static string PlayerString2(Player player)
        {
            return player switch
            {
                Player.White => "Белые",
                Player.Black => "Чёрные",
                _ => ""
            };
        }
        private static string GetReasonText(EndReason reason, Player currentPlayer)
        {
            return reason switch
            {
                EndReason.Stalemate => $"Пат {PlayerString1(currentPlayer)}",
                EndReason.Checkmate => $"Мат {PlayerString1(currentPlayer)}",
                EndReason.Resign => $"{PlayerString2(currentPlayer)} сдались",
                EndReason.FiftyMoveRule => "50 беспрогрессивных ходов",
                EndReason.InsufficientMaterial => "Недостаточно фигур",
                EndReason.ThreefoldRepetition => "Позиция повторилась 3 раза",
                EndReason.Agreement => "По соглашению",
                _ => ""
            };
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Restart);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Exit);
        }


    }
}
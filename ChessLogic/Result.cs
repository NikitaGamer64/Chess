namespace ChessLogic
{
    public class Result(Player winner, EndReason reason)
    {
        public Player Winner { get; } = winner;
        public EndReason Reason { get; } = reason;

        public static Result Win(Player winner, EndReason reason)
        {
            return new Result(winner, reason);
        }
        public static Result Draw(EndReason reason)
        {
            return new Result(Player.None, reason);
        }
    }
}
namespace VGame.CL
{
    public class MatchResult
    {
        public enum MatchState
        {
            Win,
            Draw,
            Lose
        }
        
        public int Id { get; set; }
        public MatchState State { get; set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get; set; }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VGame.CL
{
    public class Tournament
    {
        public enum TournamentType
        {
            Knockout,
            Group
        }
        
        public int TournamentId;
        public IEnumerable<Match> Matches { get; set; }
        public int Reward { get; set; }
        public Tournament Type { get; set; }
        public Match UpcomingMatch { get; set; }
        public bool IsFinished { get; set; }
    }
}
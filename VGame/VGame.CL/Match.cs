using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VGame.CL
{
    public class Match
    {
        public int Id { get; set; }
        public int FirstTeamId { get; set; }
        public int SecondTeamId { get; set; }
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }
        public DateTime MatchDate { get; set; }
        public MatchResult MatchResult { get; set; }
    }
}
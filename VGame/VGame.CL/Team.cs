using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VGame.CL
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public DateTime CreationStamp { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Match> Matches { get; set; }
    }
}
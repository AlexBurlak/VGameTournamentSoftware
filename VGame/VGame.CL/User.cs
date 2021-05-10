
using System;
using System.ComponentModel.DataAnnotations;

namespace VGame.CL
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
#nullable enable
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
#nullable  disable
        public string Password { get; set; }
        public string EMail { get; set; }
        public DateTime? Birthday { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
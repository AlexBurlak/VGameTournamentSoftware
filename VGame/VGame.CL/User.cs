using System;
using System.ComponentModel.DataAnnotations;

namespace VGame.CL
{
    public class User
    {
        public int Id;
        public string NickName;
        public string? FirstName;
        public string? SecondName;
        public byte[] Password;
        public string EMail;
        public DateTime? Birthday;
    }
}
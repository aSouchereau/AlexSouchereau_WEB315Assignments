using System;

namespace AlexSouchereauChat.Models
{
    public class Message
    {
        public string NameInput { get; set; }
        public string MessageInput { get; set; }
        public bool CurrentUser { get; set; }
    }
}
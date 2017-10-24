using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class MessageDTO
    {
        public class Message
        {
            public int Id { get; set; }

            public string MessageText { get; set; }

            public DateTime DateTimeMessage { get; set; }

            public int UserId { get; set; }

            public string Attribute { get; set; }
        }
        
    }
}

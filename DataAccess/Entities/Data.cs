using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Data
    {
        public string Name { get; set; } // User name
        public string Message { get; set; } // User message
        public string DateTimeMessage { get; set; } // Date and time of user's message
        public string Attribute { get; set; } // Adhoc attribute
    }
}

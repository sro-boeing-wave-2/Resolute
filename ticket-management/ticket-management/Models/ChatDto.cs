using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_management.Models
{
    public class ChatDto
    {
        string chatid;
        string description;
        string userhandle;
        string customerhandle;

        public string ChatId { get => chatid; set => chatid = value; }
        public string Description { get => description; set => description = value; }
        public string Userhandle { get => userhandle; set => userhandle = value; }
        public string Customerhandle { get => customerhandle; set => customerhandle = value; }
    }
}

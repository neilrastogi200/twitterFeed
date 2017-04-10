using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterFeed.Models
{
    public class Message
    {
        public string Content { get; set; }

        public DateTime DateTime { get; set; }

        public  User User { get; set; }
    }
}

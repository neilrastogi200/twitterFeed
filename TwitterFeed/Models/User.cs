using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterFeed.Models
{
    public class User
    {
        public Guid Id;
        public string UserName { get; set; }

        public IList<Message> Messages { get; set; }

        public IList<User> Following { get; set; }
    }
}

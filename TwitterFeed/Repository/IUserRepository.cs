using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterFeed.Models;

namespace TwitterFeed.Repository
{
    public interface IUserRepository
    {
        void Add(User entity);

        void Save(User entity);
        User GetUser(string userName);
    }
}

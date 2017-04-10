using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterFeed.Models;

namespace TwitterFeed.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();
       

        public UserRepository()
        {
            
        }

        public void Add(User entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("This user cannot be added");
            }

            var user = _users.Find(p => p.UserName == entity.UserName);

            if ( user == null)
            {
                user.Id = Guid.NewGuid();
                _users.Add(entity);
            }

        }

        public void Save(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

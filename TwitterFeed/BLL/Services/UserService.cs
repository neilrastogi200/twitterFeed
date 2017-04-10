using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterFeed.Models;
using TwitterFeed.Repository;

namespace TwitterFeed.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public void RegisterNewUser(string userName)
        {
            throw new NotImplementedException();
        }

        public bool FollowUser(string userName, string userNameToFollow)
        {
            throw new NotImplementedException();
        }

        public void PublishMessage(string userName, string text)
        {
           
        }
    }
}

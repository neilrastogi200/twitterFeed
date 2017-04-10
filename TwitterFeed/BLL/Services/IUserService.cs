using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterFeed.Models;

namespace TwitterFeed.BLL.Services
{
    public interface IUserService
    {
        User GetUserByUserName(string userName);

        void RegisterNewUser(string userName);

        /// <summary>
        /// User can subscribe to another User's TimeLine.
        /// </summary>
        /// <param name="userName">User who wants to follow someone.</param>
        /// <param name="userNameToFollow">Target user.</param>
        /// <returns>True on success</returns>
        bool FollowUser(string userName, string userNameToFollow);

        void PublishMessage(string userName, string text);
    }
}

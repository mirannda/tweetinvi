﻿using System.Net;
using Tweetinvi.Models;

namespace Tweetinvi.Core.Interfaces.WebLogic
{
    public interface ITwitterRequestGenerator
    {
        /// <summary>
        /// Get the Http Request expected from the given parameters
        /// </summary>
        HttpWebRequest GetQueryWebRequest(ITwitterQuery twitterQuery);
    }
}
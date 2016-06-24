﻿using Tweetinvi.Core.Helpers;
using Tweetinvi.Core.Injectinvi;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.Factories;
using Tweetinvi.Models.DTO;

namespace Tweetinvi.Logic
{
    public class Mention : Tweet, IMention
    {
        public Mention(
            ITweetDTO tweetDTO,
            ITweetController tweetController,
            ITweetFactory tweetFactory,
            IUserFactory userFactory,
            ITaskFactory taskFactory) 
                
                : base(tweetDTO,
                       tweetController,
                       tweetFactory,
                       userFactory,
                       taskFactory)
        {
            // Default constructor inheriting from the default Tweet constructor
        }

        public string Annotations { get; set; }
    }
}
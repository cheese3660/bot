﻿using Miki.Localization;
using Miki.Localization.Exceptions;

namespace Miki.Services.Reddit.Exceptions
{
    public class SubredditNsfwException : LocalizedException
    {
        private readonly string subreddit;

        /// <inheritdoc />
        public override IResource LocaleResource 
            => new LanguageResource("error_subreddit_nsfw", subreddit);

        public SubredditNsfwException(string subreddit)
        {
            this.subreddit = subreddit;
        }
    }
}

﻿using System;
using System.Threading.Tasks;

using TumblThree.Applications.DataModels;

namespace TumblThree.Applications.Downloader
{
    public interface IDownloader
    {
        Task<bool> DownloadBlogAsync();

        void UpdateProgressQueueInformation(string format, params object[] args);
    }
}

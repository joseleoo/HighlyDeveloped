﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDevelop.Core.ViewModel
{
    /// <summary>
    /// This will hold the twitter tweet data for rendering the lastest tweets
    /// </summary>
    public class TwitterViewModel
    {
        public string TwitterHandle { get; set; }
        public bool Error { get; set; }
        public string Json { get; set; }
        public string Message { get; set; }
    }
}

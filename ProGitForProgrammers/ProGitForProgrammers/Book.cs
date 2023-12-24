﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    internal class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }
    }
}

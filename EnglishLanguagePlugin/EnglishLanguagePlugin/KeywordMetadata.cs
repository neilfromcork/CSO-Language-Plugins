﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLanguagePlugin
{
    public class KeywordMetadata
    {
        public string regex { get; set; }
        public IList<string> excludedWords { get; set; }
    }
}

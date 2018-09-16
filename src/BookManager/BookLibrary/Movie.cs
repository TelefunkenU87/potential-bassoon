using System;
using System.Collections.Generic;
using System.Text;

namespace HeyMeow.BookLibrary
{
    public class Movie : Book 
    {
        public String AudioLang { get; set; }
        public String SubLang { get; set; }
    }
}

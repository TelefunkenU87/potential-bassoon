using System;
using System.Collections.Generic;
using System.Text;

namespace HeyMeow.BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String PublishDate { get; set; }
        public String Author { get; set; }
        public String Catagory { get; set; }

        public String GetDetails()
        {
            return $"{Title} {PublishDate} {Author} {Catagory}";
        }
    }
}

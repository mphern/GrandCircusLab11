using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab11
{
    class Movie
    {
        private string title;
        private string catagory;

        public Movie(string Title, string Catagory)
        {
            title = Title;
            catagory = Catagory;
        }

        public string Title { get { return title; } }
        public string Catagory { get { return catagory; } }

    }
}

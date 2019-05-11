using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BO
{
    class Post
    {
        public Post(String title, String link, String text)
        {
            this.title = title;
            this.link = link;
            this.text = text;
        }

        private String title;
        private String link;
        private String text;

        public String getTitle()
        {
            return title;
        }

        public String getLink()
        {
            return link;
        }

        public String getText()
        {
            return text;
        }
    }
}

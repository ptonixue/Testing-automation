using OpenQA.Selenium;
using SeleniumAdvanced.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.BusinessFunctions
{
    class PostFunctions
    {
        public IWebDriver driver;

        public PostFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Post(Post post)
        {
            new NewPostPage(driver).newpost(post.getTitle(), post.getLink(), post.getText());
        }
    }
}

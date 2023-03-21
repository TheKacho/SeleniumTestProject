using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    internal class TwitterPage
    {
        internal string twitterUrl = "https://twitter.com/pants";

        internal string twitterTitle = "mr. joshua (@pants) / Twitter";

        string twitterUrlxLinkPath = "//*[@data-testid=\"UserUrl\"]//child::span[contains(text(), 'theartofpants.com')]";
        internal By twitterUrlLink { get => By.XPath(twitterUrlxLinkPath); }
    }
}

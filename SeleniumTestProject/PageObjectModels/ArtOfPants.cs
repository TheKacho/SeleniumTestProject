using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    internal class ArtOfPants
    {

        public string firstUrl = "https://theartofpants.com/";

        string twitterXpathLink = "//*[@id=\"shopify-section-footer\"]/footer/div[1]/div[2]/ul/li[1]/a";
        string instagramXpathLink = "//*[@id=\"shopify-section-footer\"]/footer/div[1]/div[2]/ul/li[2]/a";
        internal By twitterButton { get => By.XPath(twitterXpathLink); }
        internal By instagramButton { get => By.XPath(instagramXpathLink);}

        

    }
}

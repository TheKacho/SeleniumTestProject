using OpenQA.Selenium;
using SeleniumTestProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    internal class BooksPage : NewTab
    {
        internal string Url = "https://demoqa.com/books";

        string gitPocketGuideLinkId = "see-book-Git Pocket Guide";

        internal By GitPocketGuideLink { get => By.Id(gitPocketGuideLinkId);}
    }
}

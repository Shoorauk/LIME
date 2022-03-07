using LIME.ApplicationLayer.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIME.Helper
{
   public class WebDriver
    {
        public IWebDriver Driver { get; set; }

        public BasePage CurrentPage { get; set; }
    }
}

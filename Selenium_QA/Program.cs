using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.mx/?hl=es-419");

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("cuenta google");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            driver.FindElement(By.ClassName("LC20lb")).Click();

            driver.FindElement(By.LinkText("Crea una cuenta de Google")).Click();
                                                   

            //driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("firstName")).SendKeys("gerson");
            //driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("lastName")).SendKeys("alvarez");
            //driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("gerson0000000004");
            //driver.FindElement(By.Name("Passwd")).Clear();
            driver.FindElement(By.Name("Passwd")).SendKeys("5aldeuva");
            //driver.FindElement(By.Name("ConfirmPasswd")).Clear();
            driver.FindElement(By.Name("ConfirmPasswd")).SendKeys("5aldeuva");
            //driver.FindElement(By.Name("ConfirmPasswd")).Clear();
            driver.FindElement(By.ClassName("CwaK9")).Click();
            //WAIT
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("phoneNumberId")).SendKeys("5574309172");
            driver.FindElement(By.Id("gradsIdvPhoneNext")).Click();
            //WAIT
   





            




        }
    }
}

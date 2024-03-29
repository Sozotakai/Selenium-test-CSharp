﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class MainClass
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement currentElement;

    static string urlMain = "https://docs.google.com/forms/d/e/1FAIpQLScoDYbnj281KhCyEMjAs3XFuOmlvuOz_wLyF-RgYfiZp9DHVg/viewform";

    static void Main()
    {

        //Open the TestForm - Starts the program

        Message("Log in...");
        driver.Manage().Window.Maximize();
        driver.Url = urlMain;
        Thread.Sleep(1000);

        //Starts filling the fields
        Message("Starting filling fields...");
        FillingFields();

        Message("Form finished");

    }

    static void FillingFields()
    {

        string pathSubmit = "#mG61Hd > div.RH5hzf.RLS9Fe > div > div.ThHDze > div.DE3NNc.CekdCb > div.lRwqcd > div";

        IWebElement submit = driver.FindElement(By.CssSelector(pathSubmit));

        //Field1
        Field1();
        Thread.Sleep(1000);

        //Field2
        Field2();
        Thread.Sleep(1000);

        //Field3
        Field3();
        Thread.Sleep(1000);

        //Field4
        Field4();
        Thread.Sleep(1000);

        //Submit the testForm
        submit.Click();
        Thread.Sleep(1000);
        driver.Quit();


    }

    static void Field1()
    {
        string[] paths = new string[2];
        paths[0] = "#i5 > div.vd3tt > div";
        paths[1] = "#i8 > div.vd3tt > div";

        int num;

        num = RandomNum(1, 3);

        switch (num)
        {
            case 1: currentElement = driver.FindElement(By.CssSelector(paths[0])); break;
            case 2: currentElement = driver.FindElement(By.CssSelector(paths[1])); break;
        }

        currentElement.Click();
    }

    static void Field2()
    {
        string pathField2;
        pathField2 = "#mG61Hd > div.RH5hzf.RLS9Fe > div > div.o3Dpx > div:nth-child(2) > div > div > div.vQES8d" +
                      " > div > div:nth-child(1) > div.ry3kXd > div.MocG8c.HZ3kWc.mhLiyf.LMgvRb.DEh1R.KKjvXb";

        int num;
        num = RandomNum(1, 4);

        string value = null;

        switch (num)
        {
            case 1: value = "Uno"; break;
            case 2: value = "Dos"; break;
            case 3: value = "Tres"; break;
        }

        currentElement = driver.FindElement(By.CssSelector(pathField2));
        currentElement.SendKeys(value);
    }

    static void Field3()
    {
        string pathField3;
        pathField3 = "#mG61Hd > div.RH5hzf.RLS9Fe > div > div.o3Dpx > div:nth-child(3) > div >" +
                      " div > div.AgroKb > div > div.aCsJod.oJeWuf > div > div.Xb9hP > input";


        currentElement = driver.FindElement(By.CssSelector(pathField3));
        currentElement.SendKeys("This is a test, /Selenium/");
    }

    static void Field4()
    {
        DateTime thisDay = DateTime.Today;

        string pathField4;
        pathField4 = "#mG61Hd > div.RH5hzf.RLS9Fe > div > div.o3Dpx > div:nth-child(4) > div > div > div:nth-child(2) > div" +
                     " > div > div.rFrNMe.yqQS1.hatWr.zKHdkd > div.aCsJod.oJeWuf > div > div.Xb9hP > input";

        currentElement = driver.FindElement(By.CssSelector(pathField4));
        currentElement.SendKeys(thisDay.ToString("d"));
    }

    static int RandomNum(int min, int max)
    {
        Random random = new Random();
        int num;

        num = random.Next(min, max);

        return num;
    }

    static private void Message(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
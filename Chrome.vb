Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Module Chrome

    'GOOGLE CHROME AUTOMATION'
    Sub Main()

        Dim driver As IWebDriver
        driver = New ChromeDriver
        driver.Navigate().GoToUrl("http://google.com")


        'Dim element As IWebElement = driver.FindElement(By.Id("L2AGLb"))
        'System.Threading.Thread.Sleep(1500)
        'element.Click()
        'System.Threading.Thread.Sleep(5500)


        System.Threading.Thread.Sleep(1500)
        driver.FindElement(By.Id("L2AGLb")).Click()
        System.Threading.Thread.Sleep(1500)
        Dim element As IWebElement = driver.FindElement(By.ClassName("gLFyf"))
        System.Threading.Thread.Sleep(500)
        element.SendKeys("Adiacent")
        System.Threading.Thread.Sleep(2000)
        driver.FindElement(By.ClassName("gNO89b")).Click()
        System.Threading.Thread.Sleep(2500)

        ''''''''''''''''''''''''''''''''''''''''''


    End Sub



End Module

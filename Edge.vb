Imports OpenQA.Selenium
Imports OpenQA.Selenium.Edge
Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.Chromium

Module Edge

    'EDGE AUTOMATION'
    Sub Main()

        'Dim driver As IWebDriver
        'driver = New ChromeDriver
        'driver.Navigate().GoToUrl("http://google.com")


        Dim driver As IWebDriver
        driver = New EdgeDriver
        driver.Navigate().GoToUrl("http://google.com")

        System.Threading.Thread.Sleep(1500)
        driver.FindElement(By.Id("L2AGLb")).Click()
        System.Threading.Thread.Sleep(1500)
        Dim element As IWebElement = driver.FindElement(By.ClassName("gLFyf"))
        System.Threading.Thread.Sleep(500)
        element.SendKeys("Adiacent")
        System.Threading.Thread.Sleep(2000)
        driver.FindElement(By.ClassName("gNO89b")).Click()
        System.Threading.Thread.Sleep(2500)


    End Sub



End Module

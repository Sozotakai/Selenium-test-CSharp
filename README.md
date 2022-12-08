# Selenium-test-CSharp
Test code for form automation with visual studio / selenium

### `Install Selenium / NuGet`
- In manage NuGet packages, search in browse "`Selenium.WebDriver`, `Selenium.Support`, `Selenium.WebDriver.ChromeDriver`" 

---

<img src="Screenshots/Manage NuGet Packages.png"> 

--------
<img src="/Screenshots/Packages.png">

In order to run the code from multiple browsers, you will have to install other packages depending on the browser you want to use.

- Microsoft Edge -> `Selenium.WebDriver.MSEdgeDriver`


After that we have to import the libraries that we´ll use, it will allows you to use types defined in a namespace without specifying the full namespace of that type.

--------
### `Import namespaces`

```c#
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
```



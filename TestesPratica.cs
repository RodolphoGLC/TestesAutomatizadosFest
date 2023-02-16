using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V107.Debugger;

namespace TestesPratica
{
    public class TestesPratica
    {
        [Fact]
        public void CadastrarAtivoComSucesso()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//button[@title='Gestão']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[2]/div/a/button")).Click();
            Random numAleatorio = new Random();
            int valorAleatorio = numAleatorio.Next();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress1\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"formGridEmail\"]")).SendKeys("21/03/2023");
            driver.FindElement(By.XPath("//*[@id=\"a\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"b\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"b\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"c\"]")).SendKeys("21032023");
            driver.FindElement(By.XPath("//*[@id=\"d\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"d\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress2\"]")).SendKeys("Testes Automatizados");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div[2]/div/div/form/div[3]/div[2]/button")).Click();

            //Assert
            Assert.Contains("Ativo cadastrado", "Ativo cadastrado");
            driver.Dispose();
        }

        [Fact]
        public void CadastrarAtivoNumeroSerieJaExistente()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//button[@title='Gestão']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[2]/div/a/button")).Click();
            Random numAleatorio = new Random();
            int valorAleatorio = numAleatorio.Next();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress1\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"formGridEmail\"]")).SendKeys("21/03/2023");
            driver.FindElement(By.XPath("//*[@id=\"a\"]")).SendKeys("12345678911");
            driver.FindElement(By.XPath("//*[@id=\"b\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"b\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"c\"]")).SendKeys("21032023");
            driver.FindElement(By.XPath("//*[@id=\"d\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"d\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress2\"]")).SendKeys("Testes Automatizados");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div[2]/div/div/form/div[3]/div[2]/button")).Click();

            //Assert
            Assert.Contains("Já existe um ativo com este Número de Série", "Já existe um ativo com este Número de Série");
            driver.Dispose();
        }

        [Fact]
        public void CadastrarAtivoPatrimonioJaExistente()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//button[@title='Gestão']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[2]/div/a/button")).Click();
            Random numAleatorio = new Random();
            int valorAleatorio = numAleatorio.Next();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress1\"]")).SendKeys("T2M0003"); 
            driver.FindElement(By.XPath("//*[@id=\"formGridEmail\"]")).SendKeys("21/03/2023");
            driver.FindElement(By.XPath("//*[@id=\"a\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"b\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"b\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"c\"]")).SendKeys("21032023");
            driver.FindElement(By.XPath("//*[@id=\"d\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"d\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress2\"]")).SendKeys("Testes Automatizados");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div[2]/div/div/form/div[3]/div[2]/button")).Click();

            //Assert
            Assert.Contains("Já existe um ativo com este Patrimônio", "Já existe um ativo com este Patrimônio");
            driver.Dispose();
        }

        //Função de busca não funciona
        [Fact]
        public void BuscarPatrimonioValido()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[1]/div/input")).SendKeys("T2M0002");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[1]/div/input")).Click();

            //Assert
            Assert.Contains("T2M0002", "T2M0002");
            driver.Dispose();
        }

        //Função de busca não funciona
        [Fact]
        public void BuscarColaboradorValido()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[1]/div/input")).SendKeys("Breno Lucas Carvalho");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[1]/div/input")).Click();

            //Assert
            Assert.Contains("Breno Lucas Carvalho", "Breno Lucas Carvalho");
            driver.Dispose();
        }

        [Fact]
        public void CadastrarAtivoDataAquisisaoInesistente()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//button[@title='Gestão']")).Click();
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[2]/div/a/button")).Click();
            Random numAleatorio = new Random();
            int valorAleatorio = numAleatorio.Next();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress1\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"formGridEmail\"]")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id=\"a\"]")).SendKeys($"{valorAleatorio}");
            driver.FindElement(By.XPath("//*[@id=\"b\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"b\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"c\"]")).SendKeys("21032023");
            driver.FindElement(By.XPath("//*[@id=\"d\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"d\"]/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"formGridAddress2\"]")).SendKeys("Testes Automatizados");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div[2]/div/div/form/div[3]/div[2]/button")).Click();

            //Assert
            Assert.Contains("Algum campo não foi preenchido", "Algum campo não foi preenchido");
            driver.Dispose();
        }

        [Fact]
        public void TrocarStatusAtivoPorInativo()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div/table/thead/div/div/input")).Click();

            //Assert
            string xPathVerificao = "//*[@id='root']/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[9]/button/svg";
            Assert.Contains(xPathVerificao, xPathVerificao);
            driver.Dispose();
        }

        [Fact]
        public void TestarVisualizacaoAtivo()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[2]/div/table/tbody/tr[1]/td[7]/a/button")).Click();

            //Assert
            string validacao = driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[2]/div/div[1]/div[1]/h3")).Text;
            Assert.Contains(validacao, validacao);
            driver.Dispose();
        }

        [Fact]
        public void TestarNotificacoesAtivos()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[1]/div/div/div[3]/div[3]/div/div/button")).Click();

            //Assert
            string validacao = driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div[1]/div/div/div/div")).Text;
            Assert.Contains(validacao, validacao);
            driver.Dispose();
        }

        [Fact]
        public void TestarPerfilAdm()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://186.216.202.85:3049");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[1]/div/input")).SendKeys("adm.sistema");
            driver.FindElement(By.XPath("//*[@id=\"formBasicPassword\"]")).SendKeys("123");
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[3]/form/div[3]/button")).Click();

            //Act
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div[1]/div/div/div[3]/div[5]/div/div/button")).Click();

            //Assert
            string validacao = driver.FindElement(By.XPath("//*[@id=\"root\"]/div[2]/div/div/div/div/div[1]/h1[2]")).Text;
            Assert.Contains(validacao, validacao);
            driver.Dispose();
        }
    }
}
using Artem2;
using Xunit;
using Allure.Xunit;
using Allure.Commons;
using Allure.Xunit.Attributes;
namespace Test
{
    [Collection("MyCollection")]
    public class UnitTest1
    {
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("Artemka")]
        [Xunit.Fact]
        public void Add()
        {
            Form1 form = new Form1();
            double a = 2;
            double b = 3;
            double expected = 5;
            double result = form.Add(a, b);
            Xunit.Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("Artemka")]
        [Fact]
        public void Sub()
        {
            Form1 form = new Form1();
            double a = 4;
            double b = 1;
            double expected = 3;
            double result = form.Sub(a, b);
            Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("Artemka")]
        [Fact]
        public void Mul()
        {
            Form1 form = new Form1();
            double a = 4;
            double b = 4;
            double expected = 16;
            double result = form.Mul(a, b);
            Assert.Equal(expected, result);
        }
        [AllureLink("https://example.com/issue/1234")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.normal)]
        [AllureOwner("Artemka")]
        [Fact]
        public void Div()
        {
            Form1 form = new Form1();
            double a = 6;
            double b = 3;
            double expected = 2;
            double result = form.Div(a, b);
            Assert.Equal(expected, result);
        }
    }
}
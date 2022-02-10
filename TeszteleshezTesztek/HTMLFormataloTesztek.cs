using NUnit.Framework;
using Teszteleshez;
namespace TeszteleshezTesztek
{
    [TestFixture]
    public class HTMLFormataloTesztek
    {
        [Test]
        [TestCase("valami")]
        [TestCase("ez a másik")]
        public void FelkoverSzoveg_SzovegParameter_SzovegetVissza(string szoveg)
        {
            HTMLFormatalo h = new HTMLFormatalo();
            var result = h.FelkoverSzoveg(szoveg);
            //Assert.That(result, Is.EqualTo("<b>Valami szöveg</b>"));
            Assert.That(result, Does.StartWith("<b>"));
            Assert.That(result, Does.EndWith("</b>"));
            Assert.That(result, Does.Contain(szoveg));
        }
    }
}

using NUnit.Framework;
using Teszteleshez;
using System.Collections.Generic;

namespace TeszteleshezTesztek
{
   
    [TestFixture]
    internal class TombosTeszteles
    {
        Tombos t;
        [SetUp]
        public void SetUp()
        {
            t = new Tombos();
        }
        [Test]
        public void General_6_1_5()
        {
            var answer = t.General(1);
            List<int> lista = new List<int> {1};
            Assert.That(answer, Is.EqualTo(lista), "Szar a kódod bammeg");
        }
    }
}

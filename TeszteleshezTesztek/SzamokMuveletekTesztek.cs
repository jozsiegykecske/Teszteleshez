using NUnit.Framework;
using Teszteleshez;

namespace TeszteleshezTesztek
{
    [TestFixture]
    internal class SzamokMuveletekTesztek
    {
        //[Test]
        //[TestCase(10,2,10)]
        //[TestCase(10,20,20)]
        //[TestCase(1,1,1)]
        //public void Legnagyobb_KetEgeszSzam_aNagyobbVissza(int x, int y, int max)
        //{
        //    SzamokMuveletek sz = new SzamokMuveletek();
        //    var answer = sz.Legnagyobb(x,y);
        //    Assert.That(sz.Legnagyobb(x,y), Is.EqualTo(max), "Szar a kódod he");
        //}
        SzamokMuveletek _sz;

        [SetUp]
        public void SetUp()
        {
            _sz = new SzamokMuveletek();
        }
        [Test]
        public void Legnagyobb_ElsoSzamNagyobb_ElsoSzamVissza()
        {
            var answer = _sz.Legnagyobb(10, 2);
            Assert.That(answer, Is.EqualTo(10), "Szar a kódod bammeg");
        }

        [Test]
        public void Legnagyobb_MasodikSzamNagyobb_MasodikSzamVissza()
        {
            var answer = _sz.Legnagyobb(5, 20);
            Assert.That(answer, Is.EqualTo(20), "Szar a kódod bammeg");
        }
        [Test]
        public void Legnagyobb_KetSzamEgyenlo_BarmelyikSzamVissza()
        {
            var answer = _sz.Legnagyobb(20, 20);
            Assert.That(answer, Is.EqualTo(20), "Szar a kódod bammeg");
        }
    }
}

using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void WhenOneAppleThenTotalIs50()
        {
            var subject = new ShoppingCart();
            subject.Scan("Apple");
            Assert.That(subject.Total(), Is.EqualTo(50));
        }
    }

    public class ShoppingCart
    {
        public int Total()
        {
            return 0;
        }

        public void Scan(string code)
        {
        }
    }
}

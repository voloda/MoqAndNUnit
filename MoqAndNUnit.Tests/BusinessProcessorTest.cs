using System;
using NUnit.Framework;

namespace MoqAndNUnit.Tests
{
    [TestFixture]
    public class BusinessProcessorTest
    {
        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void TestThruDeclarativeAssert()
        {
            var processor = new BusinessProcessor();
            processor.Initialize(); // this is the actual place which throws
            processor.Run(); // this is expected place to throw
        }

        [Test]
        public void TestThruImperativeAssert()
        {
            var processor = new BusinessProcessor();
            processor.Initialize();

            var exception = Assert.Throws<NotSupportedException>(() => processor.Run());
        }

        [Test]
        public void TestThruImperativeAssertFixed()
        {
            var processor = new BusinessProcessor();
            var exception = Assert.Throws<NotSupportedException>(() => processor.Initialize());
        }
    }
}

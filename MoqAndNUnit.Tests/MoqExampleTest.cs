using Moq;
using NUnit.Framework;

namespace MoqAndNUnit.Tests
{
    [TestFixture]
    public class MoqExampleTest
    {
        [Test]
        public void LoginShouldCallVerifyOnRemoteGateWay1()
        {
            var gateway = new Mock<IRemoteGateway>();
            var manager = new LoginManager(gateway.Object);
            manager.Login();

            gateway.Verify(g => g.Verify(), Times.Once);
        }

        [Test]
        public void LoginShouldCallVerifyOnRemoteGateWay2()
        {
            var gateway = new Mock<IRemoteGateway>();
            gateway.Setup(g => g.Verify()).Verifiable();

            var manager = new LoginManager(gateway.Object);
            manager.Login();

            gateway.VerifyAll();
        }
    }
}
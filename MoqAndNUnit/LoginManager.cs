using System;

namespace MoqAndNUnit
{
    public interface IRemoteGateway
    {
        void Verify();
    }

    public class LoginManager
    {
        private readonly IRemoteGateway _remoteGateway;

        public LoginManager(IRemoteGateway dateTimeProvider)
        {
            _remoteGateway = dateTimeProvider;
        }

        public void Login()
        {
            Console.WriteLine("Going to login");
            
            _remoteGateway.Verify();

            Console.WriteLine("Logged in");
        }
    }
}
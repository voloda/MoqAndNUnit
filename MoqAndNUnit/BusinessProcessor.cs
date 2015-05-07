using System;



namespace MoqAndNUnit
{
    public class BusinessProcessor
    {
        public void Initialize()
        {
            Console.WriteLine("Initializing");
            throw new NotSupportedException();
        }

        public void Run()
        {
            throw new NotSupportedException();
        }
    }
}

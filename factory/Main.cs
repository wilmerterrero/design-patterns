using System;

namespace factory 
{
    class Client 
    {
        public void Main() 
        {
            Console.WriteLine("App launched with the Digital Logistics");
            ClientCode(new DigitalMailLogistic());

            Console.WriteLine();

            Console.WriteLine("App launched with the Land Logistics");
            ClientCode(new LandMailLogistic());
        }
        /*
            Client Implementation. The client create a MailLogistic logic
            Each product uses the Factory Method. With this pattern we can create multiple
            Products without change the mail creation logic.
        */
        public void ClientCode(MailLogistic mailLogistics) 
        {
            Console.WriteLine($"Client: Launching app: {mailLogistics.CreateMailOperation()}");
        }
    }
}
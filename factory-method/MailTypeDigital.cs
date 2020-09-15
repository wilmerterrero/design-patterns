using System;

namespace factory 
{
    class MailTypeDigital : IMail 
    {
        public string SendMail() 
        {
            return "Digital Mail";
        }
    }
}
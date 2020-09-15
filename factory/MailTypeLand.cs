using System;

namespace factory 
{
    class MailTypeLand : IMail 
    {
        public string SendMail() 
        {
            return "Land Mail";
        }
    }
}
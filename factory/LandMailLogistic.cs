using System;

namespace factory 
{
    /*
        Concreate Creator: DigitalLogistics
        Concrete Creators override the factory method in order to change the
        resulting product's type, in this example mail's type.
    */
    class LandMailLogistic : MailLogistic
    {
        public override IMail CreateMailOperation() 
        {
            //return the mail type
            return new MailTypeLand();
        }
    }
}
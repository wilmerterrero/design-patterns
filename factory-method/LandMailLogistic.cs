using System;

namespace factory 
{
    /*
        Concreate Creator: LandMailLogistic
        Concrete Creators override the factory method in order to change the
        resulting product's type, in this example mail's type.
    */
    class LandMailLogistic : MailLogistic
    {
        public override IMail CreateMailLogistic() 
        {
            //return the mail type
            return new MailTypeLand();
        }
    }
}
using System;

namespace factory 
{
     /*
        The Creator class declares the factory method that is supposed to return
        an object of a Product class. The Creator's subclasses usually provide
        the implementation of this method.

        In this example our Creator class have the logic of a Mail System Logistic
     */
    abstract class MailLogistic 
    {
        // Factory Method: CreateMailLogistic()
        public abstract IMail CreateMailLogistic();
        public string MailOperation() 
        {
            // Call the factory method to create a mail (product) object.
            var mail = CreateMailLogistic();
            // Using the product and alert each product.
            var result = $"Mail operation working with {mail.SendMail()}";
            return result;
        }
    }
}
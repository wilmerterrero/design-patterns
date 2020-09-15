using System;

namespace factory 
{
    public interface IMail
    {
        /*
            The interface {IMail} have the common action in each
            type of mail logistic.
        */
        string SendMail();
    }
}
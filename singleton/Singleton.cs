using System;

namespace csharptest
{
    class Singleton 
    {
        /*
                CONS: 
                1. They deviate from the Single Responsibility Principle. 
                    A singleton class has the responsibility to create an instance of 
                    itself along with other business responsibilities. However, 
                    this issue can be solved by delegating the creation part to a factory object.

                2. Singleton classes cannot be sub classed. Inherence is not available because 
                    making a singleton class inheritable means any number of child classes can inherit 
                    from it creating multiple instances of the singleton class which will obviously 
                    violate the principle of singletons.
                    
                
                3. Singletons can hide dependencies. One of the features of an efficient 
                    system architecture is minimizing dependencies between classes. 
                    This will in turn help you while conducting unit tests and while isolating any part 
                    of the program to a separate assembly. A singleton will make you 
                    sacrifice this feature in your application. 
                    Since the object creation part is invisible to us, 
                    we cannot expect the singleton constructor to accept any parameters. 
                    This setback may look unimportant on the first glance but as the software 
                    complexity increases, it will limit the flexibility of the program.
        */
        private Singleton() {}
        private static Singleton _instance;
        public static Singleton GetInstance(){

            if(_instance == null){
                _instance = new Singleton();
            }

            return _instance;

        }
        public void SayHello(string message){
            System.Console.WriteLine(message);
        }
    }
}
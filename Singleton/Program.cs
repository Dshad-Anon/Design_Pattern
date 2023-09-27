using System;
namespace DesignPatterns
{
    // 'sealed' class to prevent class inheritance through external classes and neested classes.
    public sealed class Logger
    {
        private static Logger? instance;
        private Logger()
        {
            // Constructor is private to prevent direct constrcution calls using  'new' operator.
        }

        //Static method that controls the access to the singleton instance.Only one instance of the Logger
        // is created.
        public static Logger Instance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;

        }

        // Method to take string message as argument and print message that it receives.
        public void logMessages(string message)
        {
            Console.WriteLine(message);
        }

    }
    public class MainClass
    {
        public static void Main(String[] args)
        {
            Logger lg1 = Logger.Instance();
            lg1.logMessages("Hello World");
            Logger lg2 = Logger.Instance();
            lg2.logMessages("Hi There");

            if (lg1 == lg2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }


        }
    }

}
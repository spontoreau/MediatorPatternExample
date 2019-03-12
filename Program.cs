using System;

namespace MediatorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat example!");
            var mediator = new Mediator();
            var evelyn = new User(mediator) 
            {
                Name = "Evelyn"
            };
            var john = new User(mediator) 
            {
                Name = "John"
            };
            var mike = new User(mediator) 
            {
                Name = "Mike"
            };

            evelyn.SendToAll("Hello everybody!");
            john.SendToAll("Hey Evelyn, how are you today?");
            mike.SendToAll("Hi");
            evelyn.SendToAll("I'm fine, thanks for asking :). And you?");

            Console.ReadKey();
        }
    }
}

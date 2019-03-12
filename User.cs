using System;

namespace MediatorPatternExample
{
    public class User
    {
        Mediator Mediator { get; }
        public Guid Id { get; }
        public string Name { get; set; }

        public User(Mediator mediator)
        {
            Id = Guid.NewGuid();
            Mediator = mediator;
            Mediator.Register(this);
        }

        public void Receive(string message) 
        {
            Console.WriteLine($"{Name} received => {message}");
        }

        public void SendToAll(string message)
        {
            Mediator.SendToAll(message, this);
        }
    }
}
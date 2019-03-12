using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MediatorPatternExample
{
    public class Mediator 
    {
        private IList<User> Users { get; } = new List<User>();

        public void Register(User user)
        {
            Users.Add(user);
        }

        public void SendToAll(string message, User sender)
        {
            var receivers = Users.Where(u => u.Id != sender.Id).ToArray();

            foreach(var r in receivers) 
            {
                r.Receive($"{sender.Name}: {message}");
            }
        }
    }
}
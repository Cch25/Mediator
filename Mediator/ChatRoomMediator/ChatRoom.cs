using System.Collections.Generic;
using System.Linq;

namespace Mediator.ChatRoomMediator
{
    public class ChatRoom
    {
        readonly List<Person> people = new List<Person>();
        public void Broadcast(Person source, string message)
        {
            foreach (var person in people)
            {
                if (person.Id != source.Id)
                {
                    person.ReceiveMessage(message, source);
                }
            }
        }

        public void Join(Person p)
        {
            string joinMessage = $"{p.Name} joined the chat";
            Broadcast(p, joinMessage);
            p.Room = this;
            people.Add(p);
        }

        public void Message(Person source, Person destination, string message)
        {
            people.FirstOrDefault(x => x.Id == destination.Id)
                ?.ReceiveMessage(message, source);
        }
    }
}

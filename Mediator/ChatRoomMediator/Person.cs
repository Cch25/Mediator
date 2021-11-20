using System;

namespace Mediator.ChatRoomMediator
{
    public class Person
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public ChatRoom Room { get; set; }
        public Person(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public void ReceiveMessage(string message, Person person)
        {
            Console.WriteLine($"{person.Name}: {message}");
        }

        public void Say(string message)
        {
            Room.Broadcast(this, message);
        }

        public void PrivateMessage(Person who, string message)
        {
            Room.Message(this, who, $"(private message) {message}");
        }
    }
}

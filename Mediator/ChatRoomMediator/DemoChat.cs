using System;

namespace Mediator.ChatRoomMediator
{
    public class DemoChat
    {
        public void Chat()
        {
            ChatRoom room = new ChatRoom();
            Person john = new Person(Guid.NewGuid(), "John");
            Person anna = new Person(Guid.NewGuid(), "Anna");

            room.Join(john);
            room.Join(anna);

            john.Say("Hello everyone!");
            anna.Say("Hi John");
            john.PrivateMessage(anna, "How are you?");
        }
    }
}

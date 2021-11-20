using Mediator.ChatRoomMediator;
using Mediator.RxMediator;

namespace Mediator
{
    class Program
    {
        private static void Main(string[] args)
        {
            DemoChat demoChat = new DemoChat();
            demoChat.Chat();

            Demo demo = new Demo();
            demo.MainB(null);

        }
    }


}

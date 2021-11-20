using Mediator.RxMediator.Events;
using Mediator.RxMediator.Mediator;
using System;
using System.Reactive.Linq;

namespace Mediator.RxMediator.Actors
{
    public class Ref : Actor
    {
        public Ref(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerEvent>()
              .Subscribe(e =>
              {
                  if (e is PlayerScoredEvent scored)
                      Console.WriteLine($"REF: player {scored.Name} has scored his {scored.GoalsScored} goal.");
                  if (e is PlayerSentOffEvent sentOff)
                      Console.WriteLine($"REF: player {sentOff.Name} sent off due to {sentOff.Reason}.");
              });
        }
    }
}

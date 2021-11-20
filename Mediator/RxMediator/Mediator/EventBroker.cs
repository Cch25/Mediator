﻿using Mediator.RxMediator.Events;
using System;
using System.Reactive.Subjects;

namespace Mediator.RxMediator.Mediator
{
    public class EventBroker : IObservable<PlayerEvent>
    {
        private readonly Subject<PlayerEvent> subscriptions = new Subject<PlayerEvent>();
        public IDisposable Subscribe(IObserver<PlayerEvent> observer)
        {
            return subscriptions.Subscribe(observer);
        }

        public void Publish(PlayerEvent pe)
        {
            subscriptions.OnNext(pe);
        }
    }
}

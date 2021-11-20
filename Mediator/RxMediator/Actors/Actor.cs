﻿using Mediator.RxMediator.Mediator;
using System;

namespace Mediator.RxMediator.Actors
{
    public class Actor
    {
        protected EventBroker broker;

        public Actor(EventBroker broker)
        {
            this.broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
        }
    }
}

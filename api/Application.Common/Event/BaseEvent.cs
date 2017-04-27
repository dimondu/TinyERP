namespace App.Common.Event
{
    using System;
    public class BaseEvent : IEvent
    {
        public virtual Type HandlerType { get;}
    }
}

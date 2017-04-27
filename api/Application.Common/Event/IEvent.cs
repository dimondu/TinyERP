using System;

namespace App.Common.Event
{
    public interface IEvent
    {
        Type HandlerType { get;}
    }
}
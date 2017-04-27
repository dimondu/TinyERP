namespace App.Common.Event.Strategy
{
    using DI;
    using Exception;
    using Helpers;

    public class InAppEventHandlerStategy : IEventHandlerStrategy
    {
        public void Publish<TEventType>(TEventType ev) where TEventType : IEvent
        {
            object handler = IoC.Container.Resolve(ev.HandlerType);
            if (handler == null)
            {
                throw new EventHandlerNotFound<TEventType>();
            }
            ObjectHelper.Invoke(handler, "Execute", ev);
            //IEventHandler<TEventType> handler= IoC.Container.Resolve<IEventHandler<TEventType>>(ev.HandlerType);
            //if (handler == null) {
            //    throw new EventHandlerNotFound<TEventType>();
            //}
            //handler.Execute(ev);
            //IEventManager eventManager = IoC.Container.Resolve<IEventManager>();
            //eventManager.Publish<TEventType>(ev);
        }
    }
}

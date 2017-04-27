namespace App.Common.Event.Strategy
{
    using DI;
    using Exception;
    using Helpers;

    public class InAppEventHandlerStategy : IEventHandlerStrategy
    {
        public void Publish<TEventType>(TEventType ev) where TEventType : IEvent
        {
            IEventHandler<TEventType> handler= IoC.Container.Resolve<IEventHandler<TEventType>>();
            if (handler == null) {
                throw new EventHandlerNotFound<TEventType>();
            }
            handler.Execute(ev);
            //IEventManager eventManager = IoC.Container.Resolve<IEventManager>();
            //eventManager.Publish<TEventType>(ev);
        }
    }
}

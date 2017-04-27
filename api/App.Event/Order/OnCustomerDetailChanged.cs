namespace App.Event.Order
{
    using System;
    using App.Common.Event;
    public class OnCustomerDetailChanged : BaseEvent
    {
        public override Type HandlerType
        {
            get
            {
                return typeof(IEventHandler<OnCustomerDetailChanged>);
            }
        }
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public OnCustomerDetailChanged(Guid orderId, string customerName) : base()
        {
            this.OrderId = orderId;
            this.CustomerName = customerName;
        }
    }
}

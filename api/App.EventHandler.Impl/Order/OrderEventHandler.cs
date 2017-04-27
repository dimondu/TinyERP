namespace App.EventHandler.Impl.Order
{
    using Event.Order;
    using App.EventHandler.Order;
    using System;

    public class OrderEventHandler : IOrderEventHandler
    {
        public void Execute(OnOrderLineItemAdded ev)
        {
            Console.WriteLine("OnOrderLineItemAdded", ev.Price);
        }

        public void Execute(OnCustomerDetailChanged ev)
        {
            Console.WriteLine("OnCustomerDetailChanged", ev.CustomerName);
        }
    }
}

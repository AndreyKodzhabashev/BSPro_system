namespace BiesPro.Services
{
    using BiesPro.Models;
    public interface IOrderServices
    {
        Order CreateOrder();

        Order GetOrder(uint orderId);
    }
}
using System;
using System.Linq;
namespace LMS.API.Models
{
    interface IRepository
    {
       IQueryable<Order> GetAllOrders();
       IQueryable<Order> GetAllOrdersWithDetails();
        Order GetOrder(int id);
    }
}

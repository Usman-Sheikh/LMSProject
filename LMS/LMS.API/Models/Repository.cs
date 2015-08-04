using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.API.Models
{
    public class Repository : LMS.API.Models.IRepository
    {
        private LMSAPIContext db;

        public Repository(LMSAPIContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Orders.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Orders.Include("OrderDetails.Book").FirstOrDefault(o => o.Id == id);
        }
       
    }
}
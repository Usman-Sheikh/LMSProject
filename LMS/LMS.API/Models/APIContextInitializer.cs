using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LMS.API.Models
{
    public class APIContextInitializer : DropCreateDatabaseAlways<LMSAPIContext>
    {
        protected override void Seed(LMSAPIContext context)
        {
            var books = new List<Book>
            {
                new Book() {Name = "War and Peace", Author = "Tolstoy", Price = 19.95m},
                new Book() {Name = "As I Lay Dying", Author = "Faulkner", Price = 9.95m},
                new Book() {Name = "Harry Potter 1", Author = "J.K. Rowling", Price = 29.95m},
                new Book() {Name = "Pro Win 8", Author = "Liberty", Price = 49.95m},
                new Book() {Name = "Book one", Author = "Author1", Price = 10.95m},
                new Book() {Name = "Book two", Author = "Authro2", Price = 20.95m},
                new Book() {Name = "Book three", Author = "Author3", Price = 30.95m},
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() { Customer = "John Doe", OrderDate = new DateTime(2014, 7, 10) };
            var details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[0], Quantity = 1, Order = order},
                new OrderDetail() {Book = books[2], Quantity = 2, Order = order},
                new OrderDetail() {Book = books[1], Quantity = 3, Order = order}

            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Joe Smith", OrderDate = new DateTime(2014, 9, 18) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[1], Quantity = 1, Order =  order},
                new OrderDetail() {Book = books[1], Quantity = 1, Order =  order},  // note duplication - see ref in json
                new OrderDetail() {Book = books[3], Quantity = 12, Order =  order},
                new OrderDetail() {Book = books[4], Quantity = 3, Order =  order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Ward Bell", OrderDate = new DateTime(2014, 12, 25) };
            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[2], Quantity = 1, Order =  order},
                new OrderDetail() {Book = books[4], Quantity = 1, Order =  order}, 
                new OrderDetail() {Book = books[3], Quantity = 1, Order =  order},
                new OrderDetail() {Book = books[1], Quantity = 3, Order =  order}
            };

            context.Orders.Add(order);
            details.ForEach(od => context.OrderDetails.Add(od));
            context.SaveChanges();



            base.Seed(context);
        }
    }
}
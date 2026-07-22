using Linq_Task.Data;
using Linq_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linq_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();

            #region Task 1
            //1 - List all customers' first and last names along with their email addresses.

            //var customers = _context.Customers.AsQueryable();

            //var customer = _context.Customers.Select(c => new
            //{
            //    c.FirstName,
            //    c.LastName,
            //    c.Email
            //}
            //);

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"  {item.FirstName} , {item.LastName}  , {item.Email}");
            //} 
            #endregion

            #region Task 2

            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).

            //var orders = _context.Orders.AsQueryable();
            //orders = _context.Orders.Where(o => o.StaffId == 3);

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"  {item.OrderId} , {item.OrderDate}  , {item.StaffId}");
            //}

            #endregion

            #region Task 3

            //3 - Get all products that belong to a category named "Mountain Bikes".

            //var products = _context.Products.AsQueryable();

            //var ProductWithCatogry = _context.Products.Where(p => p.Category.CategoryName == "Mountain Bikes");

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductName}");
            //} 
            #endregion

            #region Task 4


            //4 - Count the total number of orders per store.

            //var orders = _context.Orders.AsQueryable();
            //var OrdersGroupBy = _context.Orders.GroupBy(o => o.StoreId).Select(o => new

            //{
            //    o.Key,
            //    Count = o.Count()

            //}  
            //);

            //foreach (var item in OrdersGroupBy)
            //{
            //    Console.WriteLine($"{item.Key} , {item.Count}");
            //} 
            #endregion

            #region task 5

            //5 - List all orders that have not been shipped yet(shipped_date is null). 

            //var orders = _context.Orders.AsQueryable();
            //var unshippedOrders = _context.Orders.Where(o => o.ShippedDate == null);

            //foreach (var order in unshippedOrders)
            //{
            //    Console.WriteLine($"{order.OrderId} {order.CustomerId}  {order.StaffId}");
            //}
            #endregion

            #region Task 6

            ////6 - Display each customer’s full name and the number of orders they have placed.
            //var Customer = _context.Customers.AsQueryable();
            //var Customers = _context.Customers.Select(c => new
            //{
            //    FullName = c.FirstName + " " + c.LastName,
            //    OrdersCount = c.Orders.Count()

            //});
            ////_context.Orders,
            ////c => c.CustomerId,
            ////o => o.CustomerId,
            ////(c ,orders)=> new
            ////{
            ////    fullname = c.FirstName + ' ' +c.LastName,
            ////    OrdersCount = orders.Count()
            ////}
            ////);

            //foreach (var itme in Customers)
            //{
            //    Console.WriteLine($"{itme.FullName}  {itme.OrdersCount}");
            //} 
            #endregion

            #region task 7

            //7 - List all products that have never been ordered(not found in order_items).

            //var products = _context.Products.Where(p => !_context.OrderItems.Any(oi => oi.ProductId == p.ProductId));

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ProductId} - {product.ProductName}");
            //} 
            #endregion

            #region Task 8

            ////8 - Display products that have a quantity of less than 5 in any store stock.
            //var stock = _context.Stocks.AsQueryable();

            //var stocks = _context.Stocks.Include(s=> s.Product).Where(s => s.Quantity < 5);

            //foreach (var s in stocks)
            //{
            //    Console.WriteLine($"{s.Product.ProductName}");
            //} 
            #endregion

            #region Task 9 


            ////9 - Retrieve the first product from the products table.

            //var product =_context.Products.AsQueryable;

            //var productfirst = _context.Products.FirstOrDefault();

            //if(productfirst != null)

            //    Console.WriteLine($"{productfirst.ProductId} {productfirst.ProductName} "); 
            #endregion

            #region Task 10


            ////10 - Retrieve all products from the products table with a certain model year.

            //var products = _context.Products.AsQueryable();

            //var product = _context.Products.Where(p => p.ModelYear == 2019);

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"{item.ProductId}  {item.ProductName}   {item.ModelYear}");
            //} 
            #endregion

            #region task 11 


            //11 - Display each product with the number of times it was ordered.

            // var products = _context.Products.AsQueryable();

            //var product = _context.Products.Select(p => new

            //{
            //   ProductName = p.ProductName,
            //   OrdersCount = p.OrderItems.Count()

            //}

            //);


            //foreach (var item in product)
            //{
            //    Console.WriteLine($"{item.ProductName}  {item.OrdersCount}   ");
            //} 
            #endregion

            #region Task 12


            //12 - Count the number of products in a specific category

            //var products = _context.Products.AsQueryable();

            //var count = _context.Products.Count(p => p.Category.CategoryName == "Mountain Bikes");

            //Console.WriteLine($"Number of Products = {count}"); 
            #endregion

            #region Task 13  


            //13 - Calculate the average list price of products.

            //var products = _context.Products.AsQueryable();

            //var averagePrice = _context.Products.Average(p => p.ListPrice );

            //Console.WriteLine($"averagePrice = {averagePrice:F2}");  
            #endregion

            #region Task 14


            //14 - Retrieve a specific product from the products table by ID.

            //var products = _context.Products.AsQueryable();
            //var specific_product = _context.Products.SingleOrDefault(p => p.ProductId == 10 );

            //if (specific_product != null)
            //    Console.WriteLine($"{specific_product.ProductId} {specific_product.ProductName}  {specific_product.ListPrice}");  

            #endregion

            #region Task 15


            //15 - List all products that were ordered with a quantity greater than 3 in any order.

            //var OrderItems = _context.OrderItems.AsQueryable();

            //var quantity_greater = _context.OrderItems.Where(oi => oi.Quantity > 3 ).Select(oi => oi.Product);

            //if(quantity_greater != null) 
            //foreach (var item in quantity_greater)
            //{
            //    Console.WriteLine($"{item.ProductId}  {item.ProductName}");  
            //} 
            #endregion

            #region Task 16


            //16 - Display each staff member’s name and how many orders they processed. 

            //var staff = _context.Staffs.AsQueryable();
            //var staffs = _context.Staffs.Select(s => new
            //{
            //    FullName = s.FirstName +" "+ s.LastName,
            //    ordercount = s.Orders.Count()
            //}

            //);

            //foreach (var item in staffs)
            //{
            //    Console.WriteLine($"{item.FullName}   {item.ordercount}");
            //} 
            #endregion

            #region Task 17


            //17 - List active staff members only(active = true) along with their phone numbers.
            //var staff = _context.Staffs.AsQueryable();
            //var staffs = _context.Staffs.Where(s => s.Active == 1).Select(s => new
            //{
            //    FullName = s.FirstName + " " + s.LastName,
            //    Phone = s.Phone
            //}

            //);

            //foreach (var item in staffs)
            //{
            //    Console.WriteLine($"{item.FullName}   {item.Phone}");
            //} 
            #endregion

            #region Task 18


            //18 - List all products with their brand name and category name.


            //var product = _context.Products.AsQueryable();
            //var productWithBrand = _context.Products.Join(
            //       _context.Brands,
            //       p => p.BrandId,
            //       b => b.BrandId,
            //       (p, b) => new
            //       {
            //           p,b
            //       }
            //   ).Join(
            //        _context.Categories,
            //        pb => pb.p.CategoryId,
            //        c => c.CategoryId,
            //        (pb, c) => new
            //        {
            //            pb.p.ProductName,
            //            pb.b.BrandId,
            //            BrandName = pb.b.BrandName,
            //            CategryName = c.CategoryName
            //        }
            //    );

            //foreach (var item in productWithBrand)
            //{
            //    Console.WriteLine($" {item.BrandName} , {item.ProductName} , {item.CategryName} ");
            //} 
            #endregion

            #region Task 19

            //19 - Retrieve orders that are completed.

            //var order = _context.Orders.AsQueryable();
            //var CompOrder = _context.Orders.Where(o => o.OrderStatus == 3);

            //foreach (var item in CompOrder)
            //{

            //Console.WriteLine($"{item.OrderId}  {item.OrderStatus}");  
            //}

            #endregion

            #region Task 20
            
            
            //20 - List each product with the total quantity sold(sum of quantity from order_items).


            //var product = _context.Products.AsQueryable();

            //var sumquantityproduct = _context.Products.GroupJoin(

            //    _context.OrderItems,
            //    p => p.ProductId,
            //    oi => oi.ProductId,
            //    (p,oi) => new
            //    {
            //        ProductName = p.ProductName,
            //        Totalquantity = oi.Sum(oi => oi.Quantity)
            //    }

            //    );

            //foreach (var item in sumquantityproduct)
            //{
            //    Console.WriteLine($"{item.ProductName}  ---- {item.Totalquantity}");
            //} 
            #endregion



        }
    }
}

using ConsoleApp1;
using MohamedWael;
using System;
using System.Linq;

 

Customer customer = new Customer { Name = "Mohamed Wael", CurrentBalance = 500 } ;

//error with balance is insufficient
//Customer customer = new Customer { Name = "Mohamed Wael", CurrentBalance = 100 } ;

List<Product> Products = new List<Product>();
Products.Add(new Product { Name = "TV", Price = 22000, Quantity = 5,Weight=3500 });
Products.Add(new Product { Name = "Biscuits", Price = 150, Quantity = 20, Weight = 700});
Products.Add(new Product { Name = "Cheese", Price = 100, Quantity = 5, Weight = 200 });

//error with expire date of cheese
//Products.Add(new Product { Name = "Cheese", Price = 100, Quantity = 5, Weight = 200, DataOfBuy = new DateOnly(2025, 4, 1), DayOfStore = 2 });

List<Item> cart = new List<Item>();
cart.Add(new Item { Name = "Cheese", Quantity = 2 });
cart.Add(new Item { Name = "Biscuits", Quantity = 1 });

//error with item out of stock
//cart.Add(new Item { Name = "dd", Quantity = 1 });

Payment payment = new Payment();
payment.checkout(cart, Products, customer);




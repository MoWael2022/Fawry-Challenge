using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedWael
{
    public class Payment
    {
        public void checkout(List<Item> item, List<Product> product, Customer customer)
        {
            double totalWeight = 0;
            double totalPrice = 0;
            double Shipping = 30;

            foreach (Item CurrentItem in item)
            {
                var myProduct = product.SingleOrDefault(x => x.Name == CurrentItem.Name);

                if (myProduct == null)
                {
                    Console.WriteLine(CurrentItem.Name + "  is out of store");
                    return;
                }

                if (myProduct.DataOfBuy.AddDays(myProduct.DayOfStore) < DateOnly.FromDateTime(DateTime.Now))
                {
                    Console.WriteLine(CurrentItem.Name + "  is expire");
                    return;
                }
                CurrentItem.Weight = myProduct.Weight;
                totalWeight += myProduct.Weight * CurrentItem.Quantity;
                CurrentItem.Price = myProduct.Price;
                totalPrice += myProduct.Price * CurrentItem.Quantity;
            }

            if (customer.CurrentBalance < totalPrice)
            {
                Console.WriteLine("your's balance is insufficient");
                return;
            }

            Console.WriteLine("** Shipment notice **");
            foreach (Item CurrentItem in item)
            {
                Console.WriteLine(CurrentItem.Quantity + "x" + "  " + CurrentItem.Name + "  " + (CurrentItem.Weight * CurrentItem.Quantity), "g");
            }
            Console.WriteLine("Total pacage weight " + (totalWeight / 1000) + "kg");
            Console.WriteLine();

            Console.WriteLine("** Checout receipt **");
            foreach (Item CurrentItem in item)
            {
                Console.WriteLine(CurrentItem.Quantity + "x" + "  " + CurrentItem.Name + "  " + (CurrentItem.Price * CurrentItem.Quantity));
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Subtotal  " + totalPrice);
            Console.WriteLine("Shipping  " + Shipping);
            Console.WriteLine("Amount    " + (totalPrice + Shipping));

        }
    }
}

using System;

namespace CSharpExercise
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Hank");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
            
        }
    }
}

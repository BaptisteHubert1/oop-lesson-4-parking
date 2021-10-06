using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking
{
    public class CarPark
    {

        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();

        public CarPark()
        {
            Console.WriteLine("I am the carpark code");
        }

        public override string ToString()
        {
            return "I am the carpark code";
        }

        public void calculateCharge()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedcharge = carParkCharge.calculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is{calculatedcharge}");
            }
        }
    }
}

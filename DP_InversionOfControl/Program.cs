using System;

namespace DP_InversionOfControl
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IAddress address1 = new CustomerAddress();
            Customer customer1 = new Customer(address1);
            Console.WriteLine("Setting customer's address using AddAddress() method \n");
            customer1.address.AddAddress("1 E. Jackson, Chicago, IL");

            address1 = new ClientAddress();
            Customer customer2 = new Customer(address1);
            Console.WriteLine("Setting client's address using AddAddress() method \n");
            customer2.address.AddAddress("230 W. Michingan Ave, Chicago, IL");


            // Console.WriteLine("Customer's new address is :\n");

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public IAddress address;
        public Customer(IAddress address)
        {
            if(address.GetType() == typeof(CustomerAddress))
            {
                Console.WriteLine("Customer object created with dependency on CustomerAddress class \n");
            }
            if (address.GetType() == typeof(ClientAddress))
            {
                Console.WriteLine("Client object created with dependency on ClientAddress class \n");
            }
            this.address = address;

        }

    }

    public interface IAddress
    {
        void AddAddress(string strAddress);
    }
    public class CustomerAddress : IAddress
    {
        public string HomeAddress { get; set; }

        public CustomerAddress()
        {
            Console.WriteLine("CustomerAddress object is created, using reference of \"IAddress\" interface \n");
        }

        public void AddAddress(string strAddress)
        {
            this.HomeAddress = strAddress;
        }
    }

    public class ClientAddress : IAddress
    {
        public string OfficeAddress { get; set; }

        public ClientAddress()
        {
            Console.WriteLine("ClientAddress object is created, using reference of \"IAddress\" interface \n");
        }

        public void AddAddress(string strAddress)
        {
            this.OfficeAddress = strAddress;
        }
    }
}

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdepter());
            customerManager.Save(new Entities.Customer { DateofBirth = new DateTime(1999,9,20), FirstName = "Mehmet Kayra", LastName = "Akın", Id = 1, NationalityID = "38293674462" });
        }
    }
}

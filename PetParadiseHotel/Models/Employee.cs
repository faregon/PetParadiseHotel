using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Employee : Person
    {
        private List<Invoice> invoices = new List<Invoice>();

        public int EmployeeId { get; set; }
        public string Initials { get; set; }

        public List<Invoice> Invoices {
            get { return invoices; }
        }
        //creating constructors
        public Employee() { }
        public Employee(int employeeId, string firstName, string lastName, string initials, string phone):base(firstName, lastName, phone)
        {
            EmployeeId = employeeId;
            Initials = initials;
        }
        //creating a method to add emplyoes to the list of invoices
        public void AddInvoice (Invoice invoice)
        {
            Invoices.Add(invoice);
        }
     }
}
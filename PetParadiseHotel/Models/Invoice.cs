﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetParadiseHotel.Models
{
    public class Invoice
    {
        private List<OrderItem> orderItems = new List<OrderItem>();
        private double totalPrice;

        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<OrderItem> OrderItems { get { return orderItems; } }

        public double TotalPrice { get {
                foreach(var item in orderItems)
                {
                    totalPrice += (item.PricePerday * item.Days);
                }
                return totalPrice;
            }
        }

        public Invoice() { }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer, Employee employee)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
            Employee = employee;
            
        }

        public void AddOrderItem (OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}
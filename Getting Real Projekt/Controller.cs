﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real_Projekt
{
    public class Controller
    {
        SQLController Sqlcontroller = new SQLController();
        private bool spWorked;
        public bool InsertReservation(string name, string tlfNumber, DateTime timeOfReservation, int numberOfPersons)
        {
            return spWorked = Sqlcontroller.InsertReservation(name, tlfNumber, timeOfReservation, numberOfPersons);
        }
        public bool InsertEntry(DateTime date, int numberofitems,double total)
        {
            
            return spWorked= Sqlcontroller.InsertEntry(date, numberofitems, total);
        }
        public bool ReadData()
        {
            return spWorked = Sqlcontroller.ReadData();
        }
        public bool ReadSpecificData(DateTime date)
        {
            return spWorked = Sqlcontroller.ReadSpecificData(date);
        }
        public bool FindReservation(DateTime date,string customerName ="")
        {
            return spWorked = Sqlcontroller.FindReservation(date,customerName);
        }

        public bool FindTotalPurchases(DateTime d)
        {
            return spWorked = Sqlcontroller.FindTotalPuchases(d);
        }
        public List<Product> GetProducts()
        {
            return Sqlcontroller.GetProducts();
        }
        public bool BuyProduct(DateTime date, int numberofitems, double total, int productId)
        {
            return Sqlcontroller.BuyProduct(date, numberofitems, total, productId);
        }

        public void ChangePrices(List<Product> pro)
        {
            Console.WriteLine("Products and their prices");
            foreach (Product item in pro)
            {
                Console.WriteLine("Product: " + item.Name + " Current price: " + item.Price);
            }
            Console.WriteLine("What would you like to change? Type 1 to choose " + pro[0].Name + " and so on");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Insert new price");
                    pro[0].Price = double.Parse(Console.ReadLine());
                    pro[0].Price = pro[0].Price * 0.75;
                    break;
                case 2:
                    Console.WriteLine("Insert new price");
                    pro[1].Price = double.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Insert new price");
                    pro[2].Price = double.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}

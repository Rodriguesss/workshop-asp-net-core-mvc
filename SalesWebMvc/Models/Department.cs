using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller s)
        {
            Sellers.Add(s);
        }

        public double TotalSales(DateTime inital, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inital, final));
        }
    }
}

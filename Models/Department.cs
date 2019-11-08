using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models {
    public class Department {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Seller> Seller { get; set; } = new List<Seller>();

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }

        public Department() {

        }

        public void AddSeller(Seller seller) {
            Seller.Add(seller);
        }

        //public double TotalSales(DateTime initial, DateTime final) {


        //}
    }
}

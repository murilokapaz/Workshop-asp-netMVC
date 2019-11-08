using System;
using System.Collections.Generic;
using System.Globalization;


namespace ProjetoWeb.Models {
    public class Seller {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public List<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

        public Seller() {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, SalesRecord sr) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            AddSales(sr);
        }

        public void AddSales(SalesRecord sr) {
            SalesRecord.Add(sr);
        }

        //public double TotalSales(DateTime initial, DateTime final) {


        //}

    }
}

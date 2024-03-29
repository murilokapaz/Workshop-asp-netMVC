﻿using System;
using ProjetoWeb.Models.Enums;

namespace ProjetoWeb.Models {
    public class SalesRecord {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord() {

        }
    }
}

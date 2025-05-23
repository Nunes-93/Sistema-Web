﻿namespace MySite.Models 
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public Status Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Venda() { }

        public Venda(int id, DateTime data, double total, Status status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}

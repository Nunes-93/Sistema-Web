using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace MySite.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void NovoVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(v => v.TotalVendas(inicial, final));  
        }
    }
}

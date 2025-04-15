namespace MySite.Models

{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
        public DateTime Nascimento { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, double salario, DateTime nascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Salario = salario;
            Nascimento = nascimento;
            Departamento = departamento;
        }

        public void NovaVenda(Venda venda)
        {
            Vendas.Add(venda);
        }

        public void RemoverVenda(Venda venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(v => v.Data >= inicial && v.Data <= final).Sum(v => v.Total);
        }

    }
}


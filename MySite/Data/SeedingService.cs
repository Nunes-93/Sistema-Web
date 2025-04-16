using MySite.Models;

namespace MySite.Data
{
    public class SeedingService
    {
        private MySiteContext _context;

        public SeedingService(MySiteContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Venda.Any() ||
                _context.Vendedor.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Eletronicos");
            Departamento d2 = new Departamento(2, "Fashion");
            Departamento d3 = new Departamento(3, "Books");

            Vendedor s1 = new Vendedor(1, "Nunes", "nunes@email.com", 5000, DateTime.Parse("12/07/1993"), d1);
            Vendedor s2 = new Vendedor(2, "Ana", "ana@email.com", 1650, DateTime.Parse("11/06/2003"), d2);
            Vendedor s3 = new Vendedor(3, "Rita", "rita@email.com", 2300, DateTime.Parse("03/11/2007"), d3);
            Vendedor s4 = new Vendedor(4, "Ricado", "ricardo@email.com", 3350, DateTime.Parse("28/05/1998"), d2);
            Vendedor s5 = new Vendedor(5, "Lucia", "Lucia@email.com", 3600, DateTime.Parse("03/02/1996"), d1);
            Vendedor s6 = new Vendedor(6, "Laura", "laura@email.com", 4100, DateTime.Parse("25/09/2000"), d3);

            Venda v1 = new Venda(1, new DateTime(2001, 03, 12), 10000, Status.Faturado,s1);
            Venda v2 = new Venda(2, new DateTime(2001, 04, 10), 8500, Status.Cancelado,s2);
            Venda v3 = new Venda(3, new DateTime(2001, 05, 15), 7500, Status.Pendente,s3);
            Venda v4 = new Venda(4, new DateTime(2001, 06, 20), 9000, Status.Faturado,s4);
            Venda v5 = new Venda(5, new DateTime(2001, 07, 25), 5600, Status.Pendente, s5);
            Venda v6 = new Venda(6, new DateTime(2001, 08, 30), 6700, Status.Cancelado, s6);
            Venda v7 = new Venda(7, new DateTime(2001, 09, 05), 7200, Status.Faturado, s1);
            Venda v8 = new Venda(8, new DateTime(2001, 10, 10), 8200, Status.Pendente, s2);
            Venda v9 = new Venda(9, new DateTime(2001, 11, 15), 9100, Status.Faturado, s3);
            Venda v10 = new Venda(10, new DateTime(2001, 12, 20), 4300, Status.Cancelado, s4);
            Venda v11 = new Venda(11, new DateTime(2002, 01, 10), 12500, Status.Faturado, s5);
            Venda v12 = new Venda(12, new DateTime(2002, 02, 15), 6600, Status.Cancelado, s6);
            Venda v13 = new Venda(13, new DateTime(2002, 03, 20), 3900, Status.Pendente, s1);
            Venda v14 = new Venda(14, new DateTime(2002, 04, 25), 4700, Status.Faturado, s2);
            Venda v15 = new Venda(15, new DateTime(2002, 05, 30), 8200, Status.Cancelado, s3);
            Venda v16 = new Venda(16, new DateTime(2002, 06, 05), 5100, Status.Pendente, s4);
            Venda v17 = new Venda(17, new DateTime(2002, 07, 10), 7500, Status.Faturado, s5);
            Venda v18 = new Venda(18, new DateTime(2002, 08, 15), 6600, Status.Cancelado, s6);
            Venda v19 = new Venda(19, new DateTime(2002, 09, 20), 8100, Status.Pendente, s1);
            Venda v20 = new Venda(20, new DateTime(2002, 10, 25), 5800, Status.Faturado, s2);
            Venda v21 = new Venda(21, new DateTime(2002, 11, 30), 7700, Status.Pendente, s3);
            Venda v22 = new Venda(22, new DateTime(2002, 12, 05), 9100, Status.Faturado, s4);
            Venda v23 = new Venda(23, new DateTime(2003, 01, 10), 4900, Status.Cancelado, s5);
            Venda v24 = new Venda(24, new DateTime(2003, 02, 15), 6500, Status.Pendente, s6);
            Venda v25 = new Venda(25, new DateTime(2003, 03, 20), 7200, Status.Faturado, s1);
            Venda v26 = new Venda(26, new DateTime(2003, 04, 25), 8600, Status.Cancelado, s2);
            Venda v27 = new Venda(27, new DateTime(2003, 05, 30), 6800, Status.Faturado, s3);
            Venda v28 = new Venda(28, new DateTime(2003, 06, 05), 5400, Status.Pendente, s4);
            Venda v29 = new Venda(29, new DateTime(2003, 07, 10), 8100, Status.Cancelado, s5);
            Venda v30 = new Venda(30, new DateTime(2003, 08, 15), 9400, Status.Faturado, s6);


            _context.Departamento.AddRange(d1, d2, d3);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);
            _context.Venda.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,
                        v11, v12, v13, v14, v15, v16, v17, v18, v19, v20,
                        v21, v22, v23, v24, v25, v26, v27, v28, v29, v30);

            // Salva as alterações no banco de dados
            _context.SaveChanges();
        }
    }
}

using MySite.Data;
using MySite.Models;

namespace MySite.Servicos
{
    public class VendedorServico
    {
        private readonly MySiteContext _context;

        public VendedorServico(MySiteContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

    }

}
    
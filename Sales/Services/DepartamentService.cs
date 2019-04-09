using Sales.Models;
using System.Collections.Generic;
using System.Linq;


namespace Sales.Services
{
    public class DepartamentService
    {
        private readonly SalesContext _context;

        public DepartamentService(SalesContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
using Sales.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sales.Services
{
    public class DepartamentService
    {
        private readonly SalesContext _context;

        public DepartamentService(SalesContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
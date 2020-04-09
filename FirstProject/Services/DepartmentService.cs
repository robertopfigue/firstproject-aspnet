using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Services
{
    public class DepartmentService
    {
        private readonly FirstProjectContext _context;

        public DepartmentService(FirstProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
           return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

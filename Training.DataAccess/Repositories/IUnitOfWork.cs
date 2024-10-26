using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Repositories.Interface;

namespace Training.DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        public IdepartmentRepo DepartmentRepo { get; }
        public IDesignationRepo DesignationRepo { get; }
        public IEmployeeRepo EmployeeRepo { get; }
    }
}

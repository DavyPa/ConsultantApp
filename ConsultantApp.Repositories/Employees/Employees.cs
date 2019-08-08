using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultantApp.Repositories.Employee
{
    public class Employees : IRepository<Employee>
    {

        private List<Employee> employees;

        public Employee Create(Employee entity)
        {
            this.employees.Add(entity);
            return entity;
        }

        public void Delete(Employee entity)
        {
            this.employees.Remove(entity);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employees;
        }

        public Employee GetById(Guid id)
        {
            var employee = from e in this.employees
                       where e.Id == id
                       select e;
            return employee.SingleOrDefault();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}

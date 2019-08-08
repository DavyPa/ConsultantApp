using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultantApp.Services.Consultants
{
    public class Consultants : IConsultants
    {
        private readonly IRepository<Consultants> consultantsRepo;

        public Consultants(IRepository<Consultants> consultantRepo)
        {
            this.consultantsRepo = consultantsRepo;
        }

        public Consultant CreateConsultant(Consultant parking)
        {
           
        }

        public void DeleteConsultant(Consultant parking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consultant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Consultant GetConsultantById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateConsultant(Consultant parking)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultantApp.Services.Consultants
{
    public interface IConsultants
    {
        IEnumerable<Consultant> GetAll();
        Consultant GetConsultantById(Guid id);
        Consultant CreateConsultant(Consultant parking);
        void DeleteConsultant(Consultant parking);
        void UpdateConsultant(Consultant parking);
    }
}

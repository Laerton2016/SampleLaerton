using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public interface IOtpadministrationRepository : IUnitOfWorkRepository
    {
        void Add(Otpadministration otpadmin);
        void Update(Otpadministration otpadmin);
        void Remove(Otpadministration otpadmin);
        IList<Otpadministration> FindAll();
        Otpadministration Find(string id);
    }
}

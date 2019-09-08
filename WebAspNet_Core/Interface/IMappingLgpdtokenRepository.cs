using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public interface IMappingLgpdtokenRepository: IUnitOfWorkRepository
    {
        void Add(MappingLgpdtoken mapping);
        void Update(MappingLgpdtoken mapping);
        void Remove(MappingLgpdtoken mapping);
        IList<MappingLgpdtoken> FindAll();
        MappingLgpdtoken Find(string id, string id2);
    }
}

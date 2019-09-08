using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public interface IMappingPaymentTokenRepository : IUnitOfWorkRepository
    {
        void Add(MappingPaymentToken mapping);
        void Update(MappingPaymentToken mapping);
        void Remove(MappingPaymentToken mapping);
        IList<MappingPaymentToken> FindAll();
        MappingPaymentToken Find(string id, string id2);
    }
}

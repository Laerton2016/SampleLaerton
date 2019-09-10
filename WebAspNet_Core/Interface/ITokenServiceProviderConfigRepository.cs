using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public interface ITokenServiceProviderConfigRepository : IUnitOfWorkRepository
    {
        void Add(TokenServiceProviderConfig token);
        void Update(TokenServiceProviderConfig token);
        void Remove(TokenServiceProviderConfig token);
        IList<TokenServiceProviderConfig> FindAll();
        TokenServiceProviderConfig Find(String id);
    }
}

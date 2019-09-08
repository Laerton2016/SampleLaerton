using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public interface ITokenRequestorRegistrationRepository: IUnitOfWorkRepository
    {
        void Add(TokenRequestorRegistration token);
        void Update(TokenRequestorRegistration token);
        void Remove(TokenRequestorRegistration token);
        IList<TokenRequestorRegistration> FindAll();
        TokenRequestorRegistration Find(string id);
    }
}

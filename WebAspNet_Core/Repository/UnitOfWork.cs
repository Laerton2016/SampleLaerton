using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<IPersistenceBase, IUnitOfWorkRepository> _entidadesAdd;
        private Dictionary<IPersistenceBase, IUnitOfWorkRepository> _entidadesUpdate;
        private Dictionary<IPersistenceBase, IUnitOfWorkRepository> _entidadesRemove;

        public UnitOfWork()
        {
            _entidadesAdd = new Dictionary<IPersistenceBase, IUnitOfWorkRepository>();
            _entidadesRemove = new Dictionary<IPersistenceBase, IUnitOfWorkRepository>();
            _entidadesUpdate = new Dictionary<IPersistenceBase, IUnitOfWorkRepository>();
        }
        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (IPersistenceBase item in this._entidadesAdd.Keys)
                {
                    this._entidadesAdd[item].InsertPersistence(item);
                }
                foreach (IPersistenceBase item in this._entidadesRemove.Keys)
                {
                    this._entidadesRemove[item].DeletePersistence(item);
                }
                foreach (IPersistenceBase item in this._entidadesUpdate.Keys)
                {
                    this._entidadesUpdate[item].UpdatePersistence(item);
                }
                scope.Complete();
            }
        }

        public void RegistraAdd(IPersistenceBase entidade, IUnitOfWorkRepository repository)
        {
            if (!_entidadesAdd.ContainsKey(entidade))
            {
                _entidadesAdd.Add(entidade, repository);
            }
        }

        public void RegistraRemove(IPersistenceBase entidade, IUnitOfWorkRepository repository)
        {
            if (!_entidadesRemove.ContainsKey(entidade))
            {
                _entidadesRemove.Add(entidade, repository);
            }
        }

        public void RegistraUpdate(IPersistenceBase entidade, IUnitOfWorkRepository repository)
        {
            if (!_entidadesUpdate.ContainsKey(entidade))
            {
                _entidadesUpdate.Add(entidade, repository);
            }
        }
    }
}

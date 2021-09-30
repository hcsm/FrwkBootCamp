using FrwkBootCamp.Domain.Interfaces.Repositories;
using FrwkBootCamp.Domain.Models;
using FrwkBootCamp.Infra.Data;

namespace FrwkBootCamp.Infra.Repository
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        private readonly DatabaseContext _context;
        public RepositoryPessoa(DatabaseContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}

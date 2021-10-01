using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Models;
using FrameBook.Infra.Data;

namespace FrameBook.Infra.Repository
{
    public class RepositoryProfissional : RepositoryBase<Profissional>, IRepositoryProfissional
    {
        private readonly DatabaseContext _context;
        public RepositoryProfissional(DatabaseContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}

using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Models;
using FrameBook.Infra.Data;

namespace FrameBook.Infra.Repository
{
    public class RepositoryStack : RepositoryBase<Stack>, IRepositoryStack
    {
        private readonly DatabaseContext _context;
        public RepositoryStack(DatabaseContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}

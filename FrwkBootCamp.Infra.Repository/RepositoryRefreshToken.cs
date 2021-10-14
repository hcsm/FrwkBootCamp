using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Models;
using FrameBook.Infra.Data;
using System.Linq;

namespace FrameBook.Infra.Repository
{
    public class RepositoryRefreshToken : RepositoryBase<RefreshToken>, IRepositoryAuth
    {
        private readonly DatabaseContext _context;

        public RepositoryRefreshToken(DatabaseContext Context)
            : base(Context)
        {
            _context = Context;
        }

        public Profissional GetByEmail(string email)
        {
            var profissional = _context.Profissionais.Where(p => p.Email == email.ToLower()).FirstOrDefault();
            return profissional;
        }
    }
}

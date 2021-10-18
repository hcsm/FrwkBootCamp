using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Models;
using FrameBook.Infra.Data;
using System.Collections.Generic;
using System.Linq;

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

        public Profissional GetByEmail(string email, string senha)
        {
            var profissional = _context.Profissionais.Where(p => p.Email == email.ToLower()).FirstOrDefault();
            if (profissional != null)
            {
                if (senha != null)
                {
                    if (BCrypt.Net.BCrypt.Verify(senha, profissional.Senha))
                    {
                        return profissional;
                    }
                }

                return profissional;
                
            }

            return null;

        }
    }
}

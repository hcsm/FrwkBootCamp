using FrameBook.Domain.Models;

namespace FrameBook.Domain.Interfaces.Repositories
{
    public interface IRepositoryProfissional : IRepositoryBase<Profissional>
    {
        Profissional GetByEmail(string email, string senha);
    }
}

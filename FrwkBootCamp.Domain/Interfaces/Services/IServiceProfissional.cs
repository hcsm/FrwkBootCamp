using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Models;

namespace FrameBook.Domain.Interfaces.Services
{
    public interface IServiceProfissional : IServiceBase<Profissional>
    {
        ProfissionalDTO GetByEmail(string email);
    }
}

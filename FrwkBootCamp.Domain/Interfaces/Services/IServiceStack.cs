using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Models;

namespace FrameBook.Domain.Interfaces.Services
{
    public interface IServiceStack : IServiceBase<Stack>
    {
        StackDTO GetById(int id);
    }
}

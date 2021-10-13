using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;

namespace FrameBook.Domain.Services
{
    public class ServiceStack : ServiceBase<Stack>, IServiceStack
    {
        public readonly IRepositoryStack _repositoryStack;

        public ServiceStack(IRepositoryStack repositoryStack)
            : base(repositoryStack)
        {
            _repositoryStack = repositoryStack;
        }

        public StackDTO GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

using AutoMapper;
using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Interfaces.Repositories;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;

namespace FrameBook.Domain.Services
{
    public class ServiceProfissional : ServiceBase<Profissional>, IServiceProfissional
    {
        public readonly IRepositoryProfissional _repositoryProfissional;
        IMapper _mapper;

        public ServiceProfissional(IRepositoryProfissional repositoryProfissional, IMapper mapper)
            : base(repositoryProfissional)
        {
            _repositoryProfissional = repositoryProfissional;
            _mapper = mapper;
        }

        public ProfissionalDTO GetByEmail(string email)
        {
            var profissional = _repositoryProfissional.GetByEmail(email);
            return _mapper.Map<ProfissionalDTO>(profissional);
        }
    }
}

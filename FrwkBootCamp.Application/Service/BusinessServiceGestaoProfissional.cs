using System.Collections.Generic;
using AutoMapper;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;

namespace FrameBook.Business.Service
{
    public class BusinessServiceGestaoProfissional : IBusinessServiceGestaoProfissional
    {
        private readonly IServiceProfissional _serviceProfissional;
        private readonly IMapper _mapper;

        public BusinessServiceGestaoProfissional(IServiceProfissional serviceProfissional, IMapper mapper)
        {
            _serviceProfissional = serviceProfissional;
            _mapper = mapper;
        }

        public void Add(ProfissionalDTO obj)
        {
            var objProfissional = _mapper.Map<Profissional>(obj);
            _serviceProfissional.Add(objProfissional);
        }

        public void Dispose()
        {
            _serviceProfissional.Dispose();
        }

        public IEnumerable<ProfissionalDTO> GetAll()
        {
            var objProfissionais = _serviceProfissional.GetAll();
            return _mapper.Map<IEnumerable<ProfissionalDTO>>(objProfissionais);
        }

        public ProfissionalDTO GetByEmail(string email)
        {
            var objProfissional = _serviceProfissional.GetByEmail(email);
            if (objProfissional == null)
                return null;
            return _mapper.Map<ProfissionalDTO>(objProfissional);
        }

        public void Remove(ProfissionalDTO obj)
        {
            var objProfissional = _mapper.Map<Profissional>(obj);
            _serviceProfissional.Remove(objProfissional);
        }

        public void Update(ProfissionalDTO obj)
        {
            var objProfissional = _mapper.Map<Profissional>(obj);
            _serviceProfissional.Update(objProfissional);
        }
    }
}

using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Infra.CrossCutting.Adapter.Interfaces;

namespace FrameBook.Business.Service
{
    public class BusinessServiceGestaoProfissional : IBusinessServiceGestaoProfissional
    {
        private readonly IServiceProfissional _serviceProfissional;
        private readonly IMapperProfissional _mapperProfissional;

        public BusinessServiceGestaoProfissional(IServiceProfissional serviceProfissional, IMapperProfissional MapperProfissional)
        {
            _serviceProfissional = serviceProfissional;
            _mapperProfissional = MapperProfissional;
        }

        public void Add(ProfissionalDTO obj)
        {
            var objProfissional = _mapperProfissional.MapperToEntity(obj);
            _serviceProfissional.Add(objProfissional);
        }

        public void Dispose()
        {
            _serviceProfissional.Dispose();
        }

        public IEnumerable<ProfissionalDTO> GetAll()
        {
            var objProfissionais = _serviceProfissional.GetAll();
            return _mapperProfissional.MapperListProfissionals(objProfissionais);
        }

        public ProfissionalDTO GetById(int id)
        {
            var objProfissional = _serviceProfissional.GetById(id);
            if (objProfissional == null)
                return null;
            return _mapperProfissional.MapperToDTO(objProfissional);
        }

        public void Remove(ProfissionalDTO obj)
        {
            var objProfissional = _mapperProfissional.MapperToEntity(obj);
            _serviceProfissional.Remove(objProfissional);
        }

        public void Update(ProfissionalDTO obj)
        {
            var objProfissional = _mapperProfissional.MapperToEntity(obj);
            _serviceProfissional.Update(objProfissional);
        }
    }
}

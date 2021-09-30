using FrwkBootCamp.Domain.Interfaces.Services;
using FrwkBootCamp.Pessoa.Application.Interfaces;
using System.Collections.Generic;
using FrwkBootCamp.Infra.CrossCutting.Adapter.Interfaces;
using FrwkBootCamp.Business.DTO.DTO;

namespace FrwkBootCamp.Pessoa.Application.Service
{
    public class BusinessServiceGestaoPessoa : IBusinessServiceGestaoPessoa
    {
        private readonly IServicePessoa _servicePessoa;
        private readonly IMapperPessoa _mapperPessoa;

        public BusinessServiceGestaoPessoa(IServicePessoa ServicePessoa, IMapperPessoa MapperPessoa)
        {
            _servicePessoa = ServicePessoa;
            _mapperPessoa = MapperPessoa;
        }

        public void Add(PessoaDTO obj)
        {
            var objPessoa = _mapperPessoa.MapperToEntity(obj);
            _servicePessoa.Add(objPessoa);
        }

        public void Dispose()
        {
            _servicePessoa.Dispose();
        }

        public IEnumerable<PessoaDTO> GetAll()
        {
            var objProdutos = _servicePessoa.GetAll();
            return _mapperPessoa.MapperListPessoas(objProdutos);
        }

        public PessoaDTO GetById(int id)
        {
            var objcliente = _servicePessoa.GetById(id);
            return _mapperPessoa.MapperToDTO(objcliente);
        }

        public void Remove(PessoaDTO obj)
        {
            var objPessoa = _mapperPessoa.MapperToEntity(obj);
            _servicePessoa.Remove(objPessoa);
        }

        public void Update(PessoaDTO obj)
        {
            var objPessoa = _mapperPessoa.MapperToEntity(obj);
            _servicePessoa.Update(objPessoa);
        }
    }
}

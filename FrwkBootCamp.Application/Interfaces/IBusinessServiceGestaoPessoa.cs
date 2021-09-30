using FrwkBootCamp.Business.DTO.DTO;
using System.Collections.Generic;

namespace FrwkBootCamp.Pessoa.Application.Interfaces
{
    public interface IBusinessServiceGestaoPessoa
    {
        void Add(PessoaDTO obj);

        PessoaDTO GetById(int id);

        IEnumerable<PessoaDTO> GetAll();

        void Update(PessoaDTO obj);

        void Remove(PessoaDTO obj);

        void Dispose();
    }
}

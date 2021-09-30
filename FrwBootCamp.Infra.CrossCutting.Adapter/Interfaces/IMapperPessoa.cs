using FrwkBootCamp.Business.DTO.DTO;
using FrwkBootCamp.Domain.Models;
using System.Collections.Generic;

namespace FrwkBootCamp.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPessoa
    {
        Pessoa MapperToEntity(PessoaDTO clienteDTO);

        IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas);

        PessoaDTO MapperToDTO(Pessoa pessoa);
    }
}

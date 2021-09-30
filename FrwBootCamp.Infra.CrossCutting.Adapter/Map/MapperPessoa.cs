using FrwkBootCamp.Business.DTO.DTO;
using FrwkBootCamp.Domain.Models;
using FrwkBootCamp.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace FrwkBootCamp.Infra.CrossCutting.Adapter.Map
{
    public class MapperPessoa : IMapperPessoa
    {
        List<PessoaDTO> pessoaDTOs = new List<PessoaDTO>();

        public Pessoa MapperToEntity(PessoaDTO pessoaDTO)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = pessoaDTO.Id,
                Nome = pessoaDTO.Nome,
                Email = pessoaDTO.Email,
                Telefone = pessoaDTO.Telefone,
                Cidade = pessoaDTO.Cidade,
                Estado = pessoaDTO.Estado
            };

            return pessoa;
        }

        public IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas)
        {
            foreach (var item in pessoas)
            {
                PessoaDTO pessoaDTO = new PessoaDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Email = item.Email,
                    Telefone = item.Telefone,
                    Cidade = item.Cidade,
                    Estado = item.Estado
                };

                pessoaDTOs.Add(pessoaDTO);
            }

            return pessoaDTOs;
        }

        public PessoaDTO MapperToDTO(Pessoa pessoa)
        {

            PessoaDTO pessoaDTO = new PessoaDTO
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Email = pessoa.Email,
                Telefone = pessoa.Telefone,
                Cidade = pessoa.Cidade,
                Estado = pessoa.Estado
            };

            return pessoaDTO;
        }
    }
}

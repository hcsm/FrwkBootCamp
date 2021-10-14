using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Models;
using FrameBook.Infra.CrossCutting.Adapter.Interfaces;

namespace FrameBook.Infra.CrossCutting.Adapter.Map
{
    public class MapperProfissional : IMapperProfissional
    {
        List<ProfissionalDTO> ProfissionalDTOs = new List<ProfissionalDTO>();

        public Profissional MapperToEntity(ProfissionalDTO profissionalDTO)
        {
            Profissional profissional = new Profissional
            {
                Nome = profissionalDTO.Nome,
                Email = profissionalDTO.Email,
                Telefone = profissionalDTO.Telefone,
                Cidade = profissionalDTO.Cidade,
                Uf = profissionalDTO.Uf,
                Senha = profissionalDTO.Senha
            };

            return profissional;
        }

        public IEnumerable<ProfissionalDTO> MapperListProfissionals(IEnumerable<Profissional> profissionais)
        {
            foreach (var item in profissionais)
            {
                ProfissionalDTO profissionalDTO = new ProfissionalDTO
                {
                    Nome = item.Nome,
                    Email = item.Email,
                    Telefone = item.Telefone,
                    Cidade = item.Cidade,
                    Uf = item.Uf,
                    Senha = item.Senha
                };

                ProfissionalDTOs.Add(profissionalDTO);
            }

            return ProfissionalDTOs;
        }

        public ProfissionalDTO MapperToDTO(Profissional profissional)
        {

            ProfissionalDTO profissionalDTO = new ProfissionalDTO
            {
                Nome = profissional.Nome,
                Email = profissional.Email,
                Telefone = profissional.Telefone,
                Cidade = profissional.Cidade,
                Uf = profissional.Uf,
                Senha = profissional.Senha
            };

            return profissionalDTO;
        }
    }
}

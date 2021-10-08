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
                Id = profissionalDTO.Id,
                Nome = profissionalDTO.Nome,
                Email = profissionalDTO.Email,
                Telefone = profissionalDTO.Telefone,
                Cidade = profissionalDTO.Cidade,
                Estado = profissionalDTO.Estado
            };

            return profissional;
        }

        public IEnumerable<ProfissionalDTO> MapperListProfissionals(IEnumerable<Profissional> profissionais)
        {
            foreach (var item in profissionais)
            {
                ProfissionalDTO profissionalDTO = new ProfissionalDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Email = item.Email,
                    Telefone = item.Telefone,
                    Cidade = item.Cidade,
                    Estado = item.Estado
                };

                ProfissionalDTOs.Add(profissionalDTO);
            }

            return ProfissionalDTOs;
        }

        public ProfissionalDTO MapperToDTO(Profissional profissional)
        {

            ProfissionalDTO profissionalDTO = new ProfissionalDTO
            {
                Id = profissional.Id,
                Nome = profissional.Nome,
                Email = profissional.Email,
                Telefone = profissional.Telefone,
                Cidade = profissional.Cidade,
                Estado = profissional.Estado
            };

            return profissionalDTO;
        }
    }
}

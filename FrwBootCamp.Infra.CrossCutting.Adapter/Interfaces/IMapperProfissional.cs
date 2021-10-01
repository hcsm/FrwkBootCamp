using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;
using FrameBook.Domain.Models;

namespace FrameBook.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProfissional
    {
        Profissional MapperToEntity(ProfissionalDTO clienteDTO);

        IEnumerable<ProfissionalDTO> MapperListProfissionals(IEnumerable<Profissional> profissionais);

        ProfissionalDTO MapperToDTO(Profissional profissional);
    }
}

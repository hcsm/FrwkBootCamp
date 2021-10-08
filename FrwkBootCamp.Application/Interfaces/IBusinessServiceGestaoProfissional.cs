using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;

namespace FrameBook.Business.Interfaces
{
    public interface IBusinessServiceGestaoProfissional
    {
        void Add(ProfissionalDTO obj);

        ProfissionalDTO GetById(int id);

        IEnumerable<ProfissionalDTO> GetAll();

        void Update(ProfissionalDTO obj);

        void Remove(ProfissionalDTO obj);

        void Dispose();
    }
}

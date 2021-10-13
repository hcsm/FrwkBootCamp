using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;

namespace FrameBook.Business.Interfaces
{
    public interface IBusinessServiceGestaoProfissional
    {
        void Add(ProfissionalDTO obj);
        #nullable enable
        ProfissionalDTO? GetByEmail(string email);
        #nullable disable

        IEnumerable<ProfissionalDTO> GetAll();

        void Update(ProfissionalDTO obj);

        void Remove(ProfissionalDTO obj);

        void Dispose();
    }
}

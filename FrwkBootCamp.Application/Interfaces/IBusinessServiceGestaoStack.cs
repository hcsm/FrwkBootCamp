using System.Collections.Generic;
using FrameBook.Business.DTO.DTO;

namespace FrameBook.Business.Interfaces
{
    public interface IBusinessServiceGestaoStack
    {
        void Add(StackDTO obj);

        StackDTO GetById(int id);

        IEnumerable<StackDTO> GetAll();

        void Update(StackDTO obj);

        void Remove(StackDTO obj);

        void Dispose();
    }
}

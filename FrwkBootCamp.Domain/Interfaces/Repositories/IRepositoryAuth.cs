using FrameBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameBook.Domain.Interfaces.Repositories
{
    public interface IRepositoryAuth : IRepositoryBase<RefreshToken>
    {
        Profissional GetByEmail(string email);
    }
}

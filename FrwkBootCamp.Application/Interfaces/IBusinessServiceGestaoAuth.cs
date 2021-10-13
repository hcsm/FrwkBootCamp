using FrameBook.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrameBook.Business.Interfaces
{
    public interface IBusinessServiceGestaoAuth
    {
        ActionResult<dynamic> Add(RefreshToken obj);
    }
}

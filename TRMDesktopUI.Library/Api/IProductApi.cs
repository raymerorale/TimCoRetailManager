using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface IProductApi
    {
        Task<List<ProductModel>> GetAll();
    }
}
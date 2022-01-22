using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/Prodiuct")]
    public class ProductController : ApiController
    {

        [HttpGet]
        public List<ProductModel> Get()
        {
            return new ProductData().GetProducts();
        }
    }
}

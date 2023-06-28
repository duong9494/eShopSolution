using eShopSolution.Appplication.Catalog.Products.Dtos;
using eShopSolution.Appplication.Catalog.Products.Dtos.Public;
using eShopSolution.Appplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appplication.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}

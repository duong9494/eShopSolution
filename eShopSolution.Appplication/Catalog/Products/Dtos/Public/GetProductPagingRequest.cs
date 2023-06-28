using eShopSolution.Appplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Appplication.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}

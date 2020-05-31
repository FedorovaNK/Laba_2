using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TorgObject.DomainObjects.Ports
{
    public interface IReadOnlyPechatProductRepository
    {
        Task<Pechatproduct> GetPechatProduct(long id);
       
        Task<IEnumerable<Pechatproduct>> GetAllPechatProducts();

        Task<IEnumerable<Pechatproduct>> QueryPechatProducts(ICriteria<Pechatproduct> criteria);

    }

    public interface IPechatProductRepository
    {
        Task AddPechatProduct(Pechatproduct pechatproduct);

        Task RemovePechatProduct(Pechatproduct pechatproduct);

        Task UpdatePechatProduct(Pechatproduct pechatproduct);
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;

namespace OrderCreationAccessors.SQL
{
    public interface IOrderAccessor
    {
        Task Create(OrderDTO toCreate);
        Task<List<OrderDTO>> List();
        Task<OrderDTO> Retrieve(Guid orderIdentifier);
        Task Update(OrderDTO toUpdate);
        Task Delete(Guid orderIdentifier);
    }
}
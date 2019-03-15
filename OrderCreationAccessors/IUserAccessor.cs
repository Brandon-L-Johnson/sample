using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;

namespace OrderCreationAccessors.SQL
{
    public interface IUserAccessor
    {
        Task Create(UserDTO toCreate);
        Task<List<UserDTO>> List();
        Task<UserDTO> Retrieve(Guid userIdentifier);
        Task Update(UserDTO toUpdate);
        Task Delete(Guid userIdentifier);
    }
}
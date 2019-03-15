using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;
using OrderCreationAccessors.SQL;
using OrderCreationEngines;

namespace OrderCreationManagers
{
    public class UserManager
    {
        private readonly UserEngine _userEngine;
        private IUserAccessor _userAccessor;
        private IOrderAccessor _orderAccessor;

        public UserManager(IUserAccessor userAccessor, IOrderAccessor orderAccessor)
        {
            _userEngine = new UserEngine(userAccessor, orderAccessor);
        }

        public async Task<List<UserDTO>> ListUsers()
        {
            var fullList = await _userAccessor.List();

            return fullList;
        }

        public async Task<UserDTO> RetrieveUser(Guid userIdentifier)
        {
            return await _userEngine.RetrieveUser(userIdentifier);
        }

        public async Task DeleteUser(Guid userIdentifier)
        {
            await _userEngine.DeleteUser(userIdentifier);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;
using OrderCreationAccessors.SQL;

namespace OrderCreationEngines
{
    public class UserEngine
    {
        private readonly IUserAccessor _userAccessor;
        private readonly IOrderAccessor _orderAccessor;

        
        public UserEngine(IUserAccessor userAccessor, IOrderAccessor orderAccessor)
        {
            _userAccessor = userAccessor;
            _orderAccessor = orderAccessor;
        }

        public async Task<List<UserDTO>> ListUsers()
        {
            var toReturn = new List<UserDTO>();
            var fullList = await _userAccessor.List();

            foreach (var user in fullList)
            {
                var userToAdd = await RetrieveUser(user.UserIdentifier);

                toReturn.Add(userToAdd);
            }

            return toReturn;
        }
        public async Task<UserDTO> RetrieveUser(Guid userIdentifier)
        {
            // find the user
            var user = await _userAccessor.Retrieve(userIdentifier);

            // find all orders for this user
            var allOrders = await _orderAccessor.List();
            var userOrders = allOrders.Where(e => e.UserIdentifier == userIdentifier).ToList();

            //attach to the user
            user.Orders = userOrders;

            return user;
        }

        public async Task DeleteUser(Guid userIdentifier)
        {
            await _userAccessor.Delete(userIdentifier);
        }
    }
}
using System;
using System.Collections.Generic;

namespace OrderCreation.Common.DTO
{
    public class UserDTO
    {
        public Guid UserIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
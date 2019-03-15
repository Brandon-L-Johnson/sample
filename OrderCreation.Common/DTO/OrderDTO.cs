using System;
using System.Collections.Generic;
using OrderCreation.Common.Enums;

namespace OrderCreation.Common.DTO
{
    public class OrderDTO
    {
        public Guid UserIdentifier { get; set; }
        public Guid OrderIdentifier { get; set; }
        public Status OrderStatus { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<ItemsDTO> Items { get; set; }
    }
}
using System;

namespace OrderCreation.Common.DTO
{
    public class ItemsDTO
    {
        public Guid ItemIdentifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
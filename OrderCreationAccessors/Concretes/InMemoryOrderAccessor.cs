using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;
using OrderCreation.Common.Enums;

namespace OrderCreationAccessors.SQL
{
    public class InMemoryOrderAccessor : IOrderAccessor
    {
        private static List<OrderDTO> _orders;

        public InMemoryOrderAccessor()
        {
            if (_orders == null)
            {
                _orders = new List<OrderDTO>();

                _orders = SeedData();
            }
        }


        public async Task Create(OrderDTO toCreate)
        {
            _orders.Add(toCreate);
        }

        public async Task<List<OrderDTO>> List()
        {
            return _orders;
        }

        public async Task<OrderDTO> Retrieve(Guid orderIdentifier)
        {
            return _orders.FirstOrDefault(e => e.OrderIdentifier == orderIdentifier);
        }

        public async Task Update(OrderDTO toUpdate)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid orderIdentifier)
        {
            var order = _orders.FirstOrDefault(e => e.OrderIdentifier == orderIdentifier);

            _orders.Remove(order);
        }


        private List<OrderDTO> SeedData()
        {
            var toReturn = new List<OrderDTO>();

            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("f888c46a-af03-4798-a4b2-b09fbb86952c"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("f9e1ae3b-8775-4acf-b99f-03e49b381863") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("af2da3cc-b3de-4a13-8d01-201e06ea8155"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("789635c4-4a4b-4242-a6e7-94e21894b48d") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("27f01e8f-1c4a-49b2-8a84-361326be4d04"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("d1c4759e-c777-4971-bbd3-54bfd2b9b129") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("1021339e-6eb6-49ca-9c70-9eeefac57710"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("85d7541e-6e59-4621-aa31-7ede3dc57603") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("0fadf1e2-235d-4065-9b6b-939fa25c12a9"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("bb4bd52e-ecc1-4d08-8777-0357a79c83ac") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("c7e69e4c-fff4-4c5e-a27a-a96ec146a976"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("7eac9ea6-f61f-47aa-80e5-6fd870c97460") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("4f12182c-ed39-462c-bdcd-0247e174ae3b"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("1912cb6c-867c-41a0-b3aa-a2e88d6421ef") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("8da01a7c-96c5-4961-aa2b-2644bca1c340"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("e1d63cb8-ff80-497f-83b2-d2cdfe49754a") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("041d9475-6722-4b6f-a00c-f2e5099cd463"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("f50d37ab-d60f-4a72-831a-ea5a53142a92") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("5bf12705-8fcd-4963-b44e-6979a825ccc3"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("de81f36d-85cb-4e27-9220-905c78cf2146") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("33703cb1-d59e-4cc6-b565-f63b3f475d3f"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("867b563b-db1e-4739-bc9f-c381136a0d44") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("03ff29d3-cdfe-4704-9092-d0c3e9f28f42"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("7d64775b-ca28-4cc7-97a0-f9e90d15fa35") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("ec3cc51b-8399-4819-b5dd-6df62ec3acfe"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("bb76c7a5-4f40-4d44-b6d8-28cd0ddb8e1d") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("19c2becd-48eb-4170-aca2-51c0c4a0d1b1"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("afbdbfcf-c45a-42a2-b4bf-2a2da480d0c4") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("5aa1a06f-10a8-4ed5-98bd-730ee6c06bb5"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("bdadb338-8933-4a23-a6e3-4dfefa196a32") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("d1aaf4d1-741b-43d8-81e9-55ad4c8fddf6"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("14ded7ba-b5ac-49fe-92fe-c9c09e210907") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("8f9bb1ff-ca6f-4ec5-b17c-ab1708510981"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("d2dc5951-7e0a-4ffc-ba61-4f1f8896b331") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("cc9c3a9e-a61a-4b07-8697-34798f3ea5e5"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("220ce97a-b339-41e1-9fed-062faccd7964") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("07444e2d-334b-4e01-8d1e-230272925a2d"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("fa85f5a2-610a-4f77-9bf9-a6dd1b6b672d") });
            toReturn.Add(new OrderDTO { UserIdentifier = Guid.Parse("6a2123ac-64d5-4b83-807c-0643d002c77a"), OrderStatus = Status.Pending, OrderIdentifier = Guid.Parse("16ad481f-479b-4054-bafd-7170105faa79") });


            return toReturn;
        }
    }
}
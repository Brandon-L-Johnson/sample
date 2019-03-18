using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderCreation.Common.DTO;

namespace OrderCreationAccessors.SQL
{
    public class InMemoryUserAccessor : IUserAccessor
    {
        private List<UserDTO> _users;

        public InMemoryUserAccessor()
        {
            if (_users == null)
            {
                _users = new List<UserDTO>();

                _users = SeedData();
            }
        }

        public async Task Create(UserDTO toCreate)
        {
            _users.Add(toCreate);
        }

        public async Task<List<UserDTO>> List()
        {
            return _users;
        }

        public async Task<UserDTO> Retrieve(Guid userIdentifier)
        {
            var toReturn = _users.FirstOrDefault(e => e.UserIdentifier == userIdentifier);

            return toReturn;
        }

        public async Task Update(UserDTO toUpdate)
        {
            var user = _users.FirstOrDefault(e => e.UserIdentifier == toUpdate.UserIdentifier);

            if (user == null)
                return;

            user.FirstName = toUpdate.FirstName;
            user.LastName = toUpdate.LastName;
        }

        public async Task Delete(Guid userIdentifier)
        {
            var user = _users.FirstOrDefault(e => e.UserIdentifier == userIdentifier);
            _users.Remove(user);
        }



        private List<UserDTO> SeedData()
        {
            var toReturn = new List<UserDTO>();
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("f888c46a-af03-4798-a4b2-b09fbb86952c"), FirstName = "Lakesha", LastName = "Rathke" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("af2da3cc-b3de-4a13-8d01-201e06ea8155"), FirstName = "Lupe", LastName = "Wiedeman" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("27f01e8f-1c4a-49b2-8a84-361326be4d04"), FirstName = "Ezra", LastName = "Rathburn" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("1021339e-6eb6-49ca-9c70-9eeefac57710"), FirstName = "Josh", LastName = "Garibay" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("0fadf1e2-235d-4065-9b6b-939fa25c12a9"), FirstName = "Charmaine", LastName = "Barnwell" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("c7e69e4c-fff4-4c5e-a27a-a96ec146a976"), FirstName = "Lavern", LastName = "Gile" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("4f12182c-ed39-462c-bdcd-0247e174ae3b"), FirstName = "Denice", LastName = "Ervin" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("8da01a7c-96c5-4961-aa2b-2644bca1c340"), FirstName = "Ruth", LastName = "Newson" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("041d9475-6722-4b6f-a00c-f2e5099cd463"), FirstName = "Grady", LastName = "Neisler" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("5bf12705-8fcd-4963-b44e-6979a825ccc3"), FirstName = "Dionna", LastName = "Burtner" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("33703cb1-d59e-4cc6-b565-f63b3f475d3f"), FirstName = "Sergio", LastName = "Jimenez" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("03ff29d3-cdfe-4704-9092-d0c3e9f28f42"), FirstName = "Lasandra", LastName = "Wareham" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("ec3cc51b-8399-4819-b5dd-6df62ec3acfe"), FirstName = "Lizzie", LastName = "Honore" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("19c2becd-48eb-4170-aca2-51c0c4a0d1b1"), FirstName = "Celine", LastName = "Whitten" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("5aa1a06f-10a8-4ed5-98bd-730ee6c06bb5"), FirstName = "Maurine", LastName = "Welles" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("d1aaf4d1-741b-43d8-81e9-55ad4c8fddf6"), FirstName = "Mariko", LastName = "Brunetti" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("8f9bb1ff-ca6f-4ec5-b17c-ab1708510981"), FirstName = "Misha", LastName = "Dumas" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("cc9c3a9e-a61a-4b07-8697-34798f3ea5e5"), FirstName = "Gayle", LastName = "Duenes" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("07444e2d-334b-4e01-8d1e-230272925a2d"), FirstName = "Domenica", LastName = "Buntin" });
            toReturn.Add(new UserDTO { UserIdentifier = Guid.Parse("6a2123ac-64d5-4b83-807c-0643d002c77a"), FirstName = "", LastName = "" });



            return toReturn;
        }
    }
}
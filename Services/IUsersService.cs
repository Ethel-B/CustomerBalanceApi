using Microsoft.AspNetCore.Mvc;


namespace CustomerBalanceApi.Services.UsersService
{
    public interface IUsersService
    {
        public Task<List<Users>> GetAllUsers();

        public Task<Users> GetSingleUserByName(string name);

        public Task<Users> GetSingleUserByTelephone(string telephone);

        public Task<Users> GetSingleUserByEmailAddress(string emailaddress);

        public Task<Users> GetSingleUserByGender(string gender);

        public Task<Users> GetSingleUserByUserName(string username);

        public Task<Users> GetSingleUserByPasswordHash(string passwordhash);

        public Task<List<Users>> AddUsers(Users users);

        public Task<List<Users>> UpdateUserByName(string name, Users request);

        public Task<List<Users>> UpdateUserByTelephone(string telephone, Users request);

        public Task<List<Users>> UpdateUserByEmailAddress(string emailaddress, Users request);

        public Task<List<Users>> UpdateUserByGender(string gender, Users request);

        public Task<List<Users>> UpdateUserByUserName(string username, Users request);

        public Task<List<Users>> UpdateUserByPasswordHash(string passwordhash, Users request);

        public Task<List<Users>> DeleteUserByName(string name);

        public Task<List<Users>> DeleteUserByTelephone(string telephone);

        public Task<List<Users>> DeleteUserByEmailAddress(string emailaddress);

        public Task<List<Users>> DeleteUserByGender(string gender);

        public Task<List<Users>> DeleteUserByUserName(string username);

        public Task<List<Users>> DeleteUserByPasswordHash(string passwordhash);
    }
}

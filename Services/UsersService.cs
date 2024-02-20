using System;
using Microsoft.AspNetCore.Mvc;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.UsersService;
using Microsoft.EntityFrameworkCore;
using CustomerBalanceApi.Services.TransactionsService;
using System.Net.Mail;
using System.Security.Claims;


namespace CustomerBalanceApi.Services.UsersService
{
    public class UsersService : IUsersService
    {
        private readonly DataContext _context;

        public UsersService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<Users> GetSingleUserByName(string name)
        {
            var user = await _context.Users.Where(u => u.Name == name).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users> GetSingleUserByTelephone(string telephone)
        {
            var user = await _context.Users.Where(u => u.Telephone == telephone).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users> GetSingleUserByEmailAddress(string emailaddress)
        {
            var user = await _context.Users.Where(u => u.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users> GetSingleUserByGender(string gender)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users> GetSingleUserByUserName(string username)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users> GetSingleUserByPasswordHash(string passwordhash)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<Users>> AddUsers(Users users)
        {

            _context.Users.Add(users);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByName(string name, Users request)
        {
            var user = await _context.Users.Where(u => u.Name == name).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.Name = request.Name;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByTelephone(string telephone, Users request)
        {
            var user = await _context.Users.Where(u => u.Telephone == telephone).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByEmailAddress(string emailaddress, Users request)
        {
            var user = await _context.Users.Where(u => u.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.EmailAddress = request.EmailAddress;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByGender(string gender, Users request)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.Gender = request.Gender;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByUserName(string username, Users request)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.UserName = request.UserName;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> UpdateUserByPasswordHash(string passwordhash, Users request)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.PasswordHash = request.PasswordHash;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByName(string name)
        {
            var user = await _context.Users.Where(u => u.Name == name).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByTelephone(string telephone)
        {
            var user = await _context.Users.Where(u => u.Telephone == telephone).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByEmailAddress(string emailaddress)
        {
            var user = await _context.Users.Where(u => u.EmailAddress == emailaddress).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByGender(string gender)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByUserName(string username)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByPasswordHash(string passwordhash)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}
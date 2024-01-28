using CoreApi1.Data;
using CoreApi1.Interface;
using CoreApi1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System;
using System.Text;

namespace CoreApi1.Repo
{
    public class UserRepo : IUser
    {

        private readonly AppDBContext _context;

        public UserRepo(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUserList()
        {
           
                var user = await _context.user.ToListAsync();
                return user;
      
        }

        public async Task<User> GetUserListById(Guid ID)
        {
            User user = await _context.user.FindAsync(ID);
               return user;
        }

        public bool InsertUserData(User user)
        {
            bool result = false;
            _context.user.Add(user);
            if (user.Username !="")
            {
                 _context.SaveChangesAsync();
                result = true;
            }
            return result;
        }
        public bool UpdateUserData(User user)
        {
            bool result = false;
            _context.Entry(user).State = EntityState.Modified;
            if (user.Id != Guid.Empty)
            {
                _context.SaveChangesAsync();
                result = true;
            }
            return result;
        }

        public bool DeleteUserData(Guid ID)
        {
            bool result = false;
            var user = _context.user.Find(ID);
            if (user != null)
            {
                _context.Entry(user).State = EntityState.Deleted;
                _context.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}

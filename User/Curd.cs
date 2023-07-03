using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class Curd
    {
        public void Create(User user)
        {
            DB db = new DB();
            db.users.Add(user);
        }
        public void Update(User user)
        {
            DB db = new DB();
            db.users.Update(user);
        }
        public void Delete(User user)
        {
            DB db = new DB();
            db.users.Remove(user);
        }
        public async Task<List<User>> GetAll()
        {
            DB db = new DB();
            return await db.users
                .Include(x => x.Details)
                .ToListAsync();
        }
        public async Task<User> GetById(int id)
        {
            DB db = new DB();

            return await db.users
                .Include(x => x.Details)
                .Where(x => x.Id == id)
                .FirstAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class UserContext : IDB<User, int>
    {
        private MVRSystemDBContext _context;

        public UserContext(MVRSystemDBContext context)
        {
            _context = context;
        }

        public void Create(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                User userFromDB = Read(key);
                _context.Remove(userFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public User Read(int key)
        {
            try
            {
                return _context.Users.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<User> ReadAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(User item)
        {
            try
            {
                User userFromDB = Read(item.ID);

                _context.Entry(userFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

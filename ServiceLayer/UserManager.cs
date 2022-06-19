using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserManager:IContext<User, int>
    {
        private UserContext _UserContext;
        public UserManager(MVRSystemDBContext context)
        {
            this._UserContext = new UserContext(context);
        }
        public void Create(User item)
        {
            try
            {
                _UserContext.Create(item);
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
                _UserContext.Delete(key);
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
                return _UserContext.Read(key);
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
                return _UserContext.ReadAll().ToList();
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
                _UserContext.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

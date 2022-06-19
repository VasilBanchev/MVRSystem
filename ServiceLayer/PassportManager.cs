using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class PassportManager : IContext<Passport, string>
    {
        private PassportContext _PassportContext;
        public PassportManager(MVRSystemDBContext context)
        {
            this._PassportContext = new PassportContext(context);
        }
        public void Create(Passport item)
        {
            try
            {
                _PassportContext.Create(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                _PassportContext.Delete(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Passport Read(string key)
        {
            try
            {
                return _PassportContext.Read(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public IEnumerable<Passport> ReadAll()
        {
            try
            {
                return _PassportContext.ReadAll().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Update(Passport item)
        {
            try
            {
                _PassportContext.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

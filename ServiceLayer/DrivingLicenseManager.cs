using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class DrivingLicenseManager : IContext<DrivingLicense, string>
    {
        private DrivingLicenseContext _DrivingLicenseContext;
        public DrivingLicenseManager(MVRSystemDBContext context)
        {
            this._DrivingLicenseContext = new DrivingLicenseContext(context);
        }
        public void Create(DrivingLicense item)
        {
            try
            {
                _DrivingLicenseContext.Create(item);
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
                _DrivingLicenseContext.Delete(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DrivingLicense Read(string key)
        {
            try
            {
                return _DrivingLicenseContext.Read(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public IEnumerable<DrivingLicense> ReadAll()
        {
            try
            {
                return _DrivingLicenseContext.ReadAll().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Update(DrivingLicense item)
        {
            try
            {
                _DrivingLicenseContext.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

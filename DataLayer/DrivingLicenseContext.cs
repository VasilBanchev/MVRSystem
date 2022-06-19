using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class DrivingLicenseContext : IDB<DrivingLicense, string>   
    {
        private MVRSystemDBContext _context;

        public DrivingLicenseContext(MVRSystemDBContext context)
        {
            _context = context;
        }

        public void Create(DrivingLicense item)
        {
            try
            {
                _context.DrivingLicenses.Add(item);
                _context.SaveChanges();
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
                DrivingLicense drivinglicenseFromDB = Read(key);
                _context.Remove(drivinglicenseFromDB);
                _context.SaveChanges();
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
                return _context.DrivingLicenses.Find(key);
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
                return _context.DrivingLicenses.ToList();
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
                DrivingLicense drivinglicenseFromDB = Read(item.Id);

                _context.Entry(drivinglicenseFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

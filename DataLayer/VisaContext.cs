using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class VisaContext : IDB<Visa, int>
    {
        private MVRSystemDBContext _context;

        public VisaContext(MVRSystemDBContext context)
        {
            _context = context;
        }

        public void Create(Visa item)
        {
            try
            {
                _context.Visas.Add(item);
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
                Visa visaFromDB = Read(key);
                _context.Remove(visaFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Visa Read(int key)
        {
            try
            {
                return _context.Visas.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Visa> ReadAll()
        {
            try
            {
                return _context.Visas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Visa item)
        {
            try
            {
                Visa visaFromDB = Read(item.ID);

                _context.Entry(visaFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

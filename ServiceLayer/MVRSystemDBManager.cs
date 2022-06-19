using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class MVRSystemDBManager
    {
        private static MVRSystemDBContext _context;

        static MVRSystemDBManager()
        {
            _context = new MVRSystemDBContext();
        }

        public static MVRSystemDBContext CreateContext()
        {
            _context = new MVRSystemDBContext();
            return _context;
        }

        public static MVRSystemDBContext GetContext()
        {
            return _context;
        }

        public static void SetAutoDetectChanges(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }
    }
}

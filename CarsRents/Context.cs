using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRents
{
    class Context
    {
        private static dbCarRentalEntities _context;

        public static dbCarRentalEntities GetContext()
        {
            if (_context == null)
            {
                _context = new dbCarRentalEntities();
            }

            return _context;
        }
    }
}

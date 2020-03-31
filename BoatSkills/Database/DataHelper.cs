using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSkills.Database
{
    public abstract class DataHelper
    {
        private static BoatSkillsEntities _context = new BoatSkillsEntities();

        public static BoatSkillsEntities GetContext()
        {
            return _context;
        }
    }
}

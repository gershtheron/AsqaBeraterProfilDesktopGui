using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Kompetenz
    {
        private int komp_id;
        private int komp_level;

        public Kompetenz()
        {
        }

        public int Komp_id { get => komp_id; set => komp_id = value; }
        public int Komp_level { get => komp_level; set => komp_level = value; }

        public Kompetenz(int komp_id, int komp_level)
        {
            Komp_id = komp_id;
            Komp_level = komp_level;
            
        }
    }
}

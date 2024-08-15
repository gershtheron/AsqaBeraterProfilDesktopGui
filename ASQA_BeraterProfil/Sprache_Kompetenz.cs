using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Sprache_Kompetenz
    {
        private int sprachkomp_id;
        private string sprach_komp;

        public Sprache_Kompetenz(int sprachkomp_id, string sprach_komp)
        {
            this.sprachkomp_id = sprachkomp_id;
            this.sprach_komp = sprach_komp;
        }

        public Sprache_Kompetenz()
        {
        }

        public int Sprachkomp_id { get => sprachkomp_id; set => sprachkomp_id = value; }
        public string Sprach_komp { get => sprach_komp; set => sprach_komp = value; }
    }
}

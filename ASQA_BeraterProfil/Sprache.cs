using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
   public class Sprache
    {
        private int Sprache_id;
        private string Sprache_name;

        public int Sprache_id1 { get => Sprache_id; set => Sprache_id = value; }
        public string Sprache_name1 { get => Sprache_name; set => Sprache_name = value; }

        public Sprache(int sprache_id, string sprache_name)
        {
            Sprache_id = sprache_id;
            Sprache_name = sprache_name;
        }

        public Sprache()
        {
        }
    }
}

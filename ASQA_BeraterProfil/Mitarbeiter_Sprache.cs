using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Mitarbeiter_Sprache
    {
        private int ma_sprache_id;
        private int ma_id;
        private int sprache_id;        
        private string sprache_name;
        private string sprach_komp;

        public int Ma_sprache_id { get => ma_sprache_id; set => ma_sprache_id = value; }
        public int Ma_id { get => ma_id; set => ma_id = value; }
        public int Sprache_id { get => sprache_id; set => sprache_id = value; }
       
        public string Sprache_name { get => sprache_name; set => sprache_name = value; }
        public string Sprach_komp { get => sprach_komp; set => sprach_komp = value; }

        public Mitarbeiter_Sprache()
        {
        }

        public Mitarbeiter_Sprache(int ma_sprache_id, int ma_id, int sprache_id, string sprache_name, string sprach_komp)
        {
            this.Ma_sprache_id = ma_sprache_id;
            this.Ma_id = ma_id;
            this.Sprache_id = sprache_id;            
            this.Sprache_name = sprache_name;
            this.Sprach_komp = sprach_komp;

        }
    }
}

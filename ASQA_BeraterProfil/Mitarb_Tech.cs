using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Mitarb_Tech
    {
        private int ma_tech_id;
        private int ma_id;
        private int tech_id;
        private int komp_id;
        private string seit_jahr;
        private string tech_name; 

        public int Ma_tech_id { get => ma_tech_id; set => ma_tech_id = value; }
        public int Ma_id { get => ma_id; set => ma_id = value; }
        public int Tech_id { get => tech_id; set => tech_id = value; }
        public int Komp_id { get => komp_id; set => komp_id = value; }
        public string Seit_jahr { get => seit_jahr; set => seit_jahr = value; }
        public string Tech_name { get => tech_name; set => tech_name = value; }

        public Mitarb_Tech(int ma_ski_id, int ma_id, int tech_id, int komp_id, string seit_jahr, string tech_name)
        {
            this.Ma_tech_id = ma_tech_id;
            this.Ma_id = ma_id;
            this.Tech_id = tech_id;
            this.Komp_id = komp_id;
            this.seit_jahr = seit_jahr;          
            this.Seit_jahr = seit_jahr;
            this.tech_name = tech_name;
        }

        public Mitarb_Tech()
        {
        }
    }
}

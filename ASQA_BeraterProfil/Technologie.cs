using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Technologie
    {
        private int tech_id;
        private string tech_name;

        public int Tech_id { get => tech_id; set => tech_id = value; }
        public string Tech_name { get => tech_name; set => tech_name = value; }

        public Technologie(){         }

        public Technologie(int tech_id, string tech_name)
        {
            this.Tech_id = tech_id;
            this.Tech_name = tech_name;
          
        }
    }
}

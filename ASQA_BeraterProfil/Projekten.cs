using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Projekten
    {
        private int proj_id;
        private string proj_name;

        public Projekten()
        {
        }

        public int Proj_id { get => proj_id; set => proj_id = value; }
        public string Proj_name { get => proj_name; set => proj_name = value; }

        public Projekten( int proj_id, string proj_name)
        {
            this.proj_id = proj_id; 
            this.proj_name = proj_name;
        }


    }
}

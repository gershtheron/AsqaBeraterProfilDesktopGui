using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Ausbildungen
    {
        private int Ausb_id;
        private string Ausb_name;
        private string Ausb_institut;
        private string Ausb_jahr;

        public int Ausb_id1 { get => Ausb_id; set => Ausb_id = value; }
        public string Ausb_name1 { get => Ausb_name; set => Ausb_name = value; }
        public string Ausb_institut1 { get => Ausb_institut; set => Ausb_institut = value; }
        public string Ausb_jahr1 { get => Ausb_jahr; set => Ausb_jahr = value; }

        public Ausbildungen(int ausb_id, string ausb_name, string ausb_institut, string ausb_jahr)
        {
            Ausb_id = ausb_id;
            Ausb_name = ausb_name;
            Ausb_institut = ausb_institut;
            Ausb_jahr = ausb_jahr;
            
        }

        public Ausbildungen()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Mitarbeiter_Ausbildung
    {
        private int ma_ausb_id;
        private int ma_id;
        private int ausb_id;
        private string ausb_name;

        public Mitarbeiter_Ausbildung(int ma_ausb_id, int ma_id, int ausb_id, string ausb_name)
        {
            this.ma_ausb_id = ma_ausb_id;
            this.ma_id = ma_id;
            this.ausb_id = ausb_id;
            this.ausb_name = ausb_name;
            
        }

        public int Ma_ausb_id { get => ma_ausb_id; set => ma_ausb_id = value; }
        public int Ma_id { get => ma_id; set => ma_id = value; }
        public int Ausb_id { get => ausb_id; set => ausb_id = value; }
        public string Ausb_name { get => ausb_name; set => ausb_name = value; }

        public Mitarbeiter_Ausbildung()
        {
        }
    }
}

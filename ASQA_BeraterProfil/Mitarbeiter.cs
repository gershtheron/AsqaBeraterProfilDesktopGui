using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Mitarbeiter
    {
        private int Ma_id;
        private string Ma_Nachname;
        private string Ma_Vorname;
        private string Ma_Gebjahr;
        private string Firma_Rolle;
        private string Schwerpunkte;        
   
        public Mitarbeiter()
        {
        }

        public int Ma_id1 { get => Ma_id; set => Ma_id = value; }
        public string Ma_Nachname1 { get => Ma_Nachname; set => Ma_Nachname = value; }
        public string Ma_Vorname1 { get => Ma_Vorname; set => Ma_Vorname = value; }
        public string Ma_Gebjahr1 { get => Ma_Gebjahr; set => Ma_Gebjahr = value; }
        public string Firma_Rolle1 { get => Firma_Rolle; set => Firma_Rolle = value; }
        public string Schwerpunkte1 { get => Schwerpunkte; set => Schwerpunkte = value; }
        
      

        public Mitarbeiter(int ma_id, string ma_Nachname, string ma_Vorname, string ma_Gebjahr, string firma_Rolle, string schwerpunkte)
        {
            this.Ma_id = ma_id;
           this.Ma_Nachname = ma_Nachname;
            this.Ma_Vorname = ma_Vorname;
            this.Ma_Gebjahr = ma_Gebjahr;
            this.Firma_Rolle = firma_Rolle;
            this.Schwerpunkte = schwerpunkte;
           
         
         
        }
    }
}

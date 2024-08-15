using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASQA_BeraterProfil
{
    public class Mitarb_Projekt
    {
        private int ma_proj_id;
        private int ma_id;
        private int proj_id;
        private string ma_rolle;
        private string start_date;
        private string end_date;       
        private string proj_name;
        private string taetigkeiten;
        public int Ma_proj_id { get => ma_proj_id; set => ma_proj_id = value; }
        public int Ma_id { get => ma_id; set => ma_id = value; }
        public int Proj_id { get => proj_id; set => proj_id = value; }
        public string Ma_rolle { get => ma_rolle; set => ma_rolle = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }       
        public string Proj_name { get => proj_name; set => proj_name = value; }
        public string Taetigkeiten { get => taetigkeiten; set => taetigkeiten = value; }

        public Mitarb_Projekt(int ma_proj_id, int ma_id, int proj_id, string ma_rolle,string start_date, string end_date, string proj_name, string taetigkeiten)
        {
            this.ma_proj_id = ma_proj_id;
            this.ma_id = ma_id;
            this.proj_id = proj_id;
            this.ma_rolle = ma_rolle;
            this.start_date = start_date;
            this.end_date = end_date;            
            this.proj_name = proj_name;
            this.taetigkeiten = taetigkeiten;
        }

        public Mitarb_Projekt()
        {
        }
    }
}

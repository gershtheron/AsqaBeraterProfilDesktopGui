using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASQA_BeraterProfil;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ASQA_BeraterProfil
{
    public class Database
    {
        private MySqlConnection con;
        private string connectionString;

        public Database()
        {
            con = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=root ;DATABASE=asqa_projekt");
        }

        //OpenClose Methods ------------------------>
        private void oeffnen()
        {
            con.Open();
        }
        private void schliessen()
        {
            if (con != null)
                con.Close();
        }//--------------------------      ----------------|end








        //PROJEKTEN ---------------------------------------------------->
        //--GET METHOD 
        public List<Projekten> getProjekten()
        {
            List<Projekten> ListProjekten = new List<Projekten>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM projekten;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ListProjekten.Add(
                  new Projekten(
                       reader.GetInt32(0),
                        reader.GetString(1)
                       ));
            }
            schliessen();
            return ListProjekten;
        }

        //--SAVE PROJEKTEN METHOD                                        
        public void saveProjekten(Projekten Proj)
        {

            try
            {
                oeffnen();

                using (MySqlCommand checkProjektName = new MySqlCommand("SELECT COUNT(*) FROM projekten WHERE proj_name = @ProjName", con))
                {
                    checkProjektName.Parameters.AddWithValue("@ProjName", Proj.Proj_name);
                    long count = (long)checkProjektName.ExecuteScalar();

                    if (count > 1) ////originally: if (count > 0)
                    {
                        MessageBox.Show("This Projekt has already been entered.");
                        return;
                    }
                }

                // If the tech_name does not exist, proceed with the insert
                using (MySqlCommand com = new MySqlCommand("INSERT INTO projekten VALUES (NULL, @ProjName);", con))
                {
                    com.Parameters.AddWithValue("@ProjName", Proj.Proj_name);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Projekt added successfully.");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                schliessen();
            }
        }

        //--DELETE PROJEKTEN  
        public void delProjekten(int proj_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM projekten WHERE proj_id = @ProjId;", con);
            com.Parameters.AddWithValue("@ProjId", proj_id);

            com.ExecuteNonQuery();

            schliessen();
        }

        //--GetDetailsForListboxMethod
        public List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date, string End_date, string Nachname, string Vorname)> GetMitarbeiterForProjekt(int projektId)
        {
            List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date, string End_date, string Nachname, string Vorname)> result =
                new List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date, string End_date, string Nachname, string Vorname)>();

            oeffnen(); 

            string query = @"
            SELECT p.proj_name, mp.ma_rolle, mp.taetigkeiten, mp.start_date, mp.end_date, m.ma_nachname, m.ma_vorname
            FROM ma_projekt mp
            INNER JOIN projekten p ON mp.proj_id = p.proj_id
            INNER JOIN mitarbeiter m ON mp.ma_id = m.ma_id
            WHERE mp.proj_id = @ProjektId;
            ";

            MySqlCommand cmd = new MySqlCommand(query, con); 
            cmd.Parameters.AddWithValue("@ProjektId", projektId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string projName = reader.GetString("proj_name");
                string maRolle = reader.GetString("ma_rolle");
                string taetigkeiten = reader.GetString("taetigkeiten");
                string startDate = reader.GetString("start_date");
                string endDate = reader.GetString("end_date");
                string nachname = reader.GetString("ma_nachname");
                string vorname = reader.GetString("ma_vorname");
                result.Add((projName, maRolle, taetigkeiten, startDate, endDate, nachname, vorname));
            }

            schliessen(); 
            return result;
        }

        //-------------------------------------------------------------|PROJEKTEN end









        //TECHNOLOGIE --------------------------------------------------->
        //--GET METHOD 
        public List<Technologie> getTechnologie()
        {
            List<Technologie> ListTechnologie = new List<Technologie>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM technologie;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ListTechnologie.Add(
                  new Technologie(
                       reader.GetInt32(0),
                        reader.GetString(1)
                       ));
            }
            schliessen();
            return ListTechnologie;
        }

        //--SAVE TECHNOLOGIE METHOD                                        
        public void saveTechnologie(Technologie Tech)
        {
            try
            {
                oeffnen();

                using (MySqlCommand checkTechName = new MySqlCommand("SELECT COUNT(*) FROM technologie WHERE Tech_name = @TechName", con))
                {
                    checkTechName.Parameters.AddWithValue("@TechName", Tech.Tech_name);
                    long count = (long)checkTechName.ExecuteScalar();

                    if (count > 1) ////originally: if (count > 0)
                    {
                        MessageBox.Show("This tech_name has already been entered.");
                        return;
                    }
                }

                // If the tech_name does not exist, proceed with the insert
                using (MySqlCommand com = new MySqlCommand("INSERT INTO technologie VALUES (NULL, @TechName);", con))
                {
                    com.Parameters.AddWithValue("@TechName", Tech.Tech_name);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Technology added successfully.");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                schliessen();
            }
        }

        //--DELETE TECHNOLOGIE  
        public void delTechnologie(int tech_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM technologie WHERE tech_id = @TechId;", con);
            com.Parameters.AddWithValue("@TechId", tech_id);

            com.ExecuteNonQuery();

            schliessen();
        }

        //--GetDetailsForListboxMethod
        public List<(string Tech_name, string Seitjahr, string Nachname, string Vorname)> GetMitarbeiterForTech(int techId)
        {
            List<(string Tech_name, string Seitjahr, string Nachname, string Vorname)> result =
                new List<(string Tech_name, string Seitjahr, string Nachname, string Vorname)>();

            oeffnen(); 

            string query = @"
            SELECT t.tech_name, mt.seitjahr, m.ma_nachname, m.ma_vorname
            FROM ma_tech mt
            INNER JOIN technologie t ON mt.tech_id = t.tech_id
            INNER JOIN mitarbeiter m ON mt.ma_id = m.ma_id
            WHERE mt.tech_id = @TechId;
            ";         

            MySqlCommand cmd = new MySqlCommand(query, con); 
            cmd.Parameters.AddWithValue("@TechId", techId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tech_name = reader.GetString("tech_name");
                string seitjahr = reader.GetString("seitjahr");              
                string nachname = reader.GetString("ma_nachname");
                string vorname = reader.GetString("ma_vorname");
                result.Add((tech_name, seitjahr, nachname, vorname));
            }

            schliessen(); 

            return result;
        }

        //------------------------------------------------------------------|TECHNOLOGIE end









        //MITARBEITER --------------------------------------------------->
        //--GET METHOD 
        public List<Mitarbeiter> getMitarbeiter()
        {
            List<Mitarbeiter> ListMitar = new List<Mitarbeiter>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM mitarbeiter;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ListMitar.Add(
                  new Mitarbeiter(
                       reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)



                       ));
            }
            schliessen();
            return ListMitar;
        }

        //--SAVE MITARBEITER METHOD                                        
        public void saveMitarbeiter(Mitarbeiter Mitarb)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("INSERT INTO mitarbeiter VALUES (NULL,  @Ma_Nachname, @Ma_Vorname, " +
                                                "@Ma_Gebjahr, @Ma_FirmaRolle, @Ma_Schwerpunkte);", con);

            com.Parameters.AddWithValue("@Ma_Nachname", Mitarb.Ma_Nachname1);
            com.Parameters.AddWithValue("@Ma_Vorname", Mitarb.Ma_Vorname1);
            com.Parameters.AddWithValue("@Ma_Gebjahr", Mitarb.Ma_Gebjahr1);
            com.Parameters.AddWithValue("@Ma_FirmaRolle", Mitarb.Firma_Rolle1);
            com.Parameters.AddWithValue("@Ma_Schwerpunkte", Mitarb.Schwerpunkte1);


            com.ExecuteNonQuery();

            schliessen();
        }

        //--DELETE MITARBEITER 
        public void delMitarbeiter(int Ma_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM mitarbeiter WHERE ma_id = @Ma_id;", con);
            com.Parameters.AddWithValue("@Ma_id", Ma_id);

            com.ExecuteNonQuery();

            schliessen();
        }
        
        //------------------------------------------------------------------|MITARBEITER end









        //AUSBILDUNGEN --------------------------------------------------->
        //--GET METHOD 
        public List<Ausbildungen> getAusbildungen()
        {
            List<Ausbildungen> ListAusbildungen = new List<Ausbildungen>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM ausbildungen;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ListAusbildungen.Add(
                  new Ausbildungen(
                       reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)


                       ));
            }
            schliessen();
            return ListAusbildungen;
        }

        //--SAVE AUSBILDUNGEN METHOD                                        
        public void saveAusbildungen(Ausbildungen Ausb)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("INSERT INTO ausbildungen VALUES (NULL, @Ausb_name, @Ausb_Institut, @Ausb_Jahr);", con);

            com.Parameters.AddWithValue("@Ausb_name", Ausb.Ausb_name1);
            com.Parameters.AddWithValue("@Ausb_Institut", Ausb.Ausb_institut1);
            com.Parameters.AddWithValue("@Ausb_Jahr", Ausb.Ausb_jahr1);

            com.ExecuteNonQuery();

            schliessen();
        }

        //--DELETE AUSBILDUNGEN 
        public void delAusbildungen(int Ausb_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM ausbildungen WHERE ausb_id = @Ausb_id;", con);
            com.Parameters.AddWithValue("@Ausb_id", Ausb_id);

            com.ExecuteNonQuery();

            schliessen();
        }

        //-----------------------------------------------------------------|AUSBILDUNGEN end








        //KOMPETENZ -------------------------------------------------------->
        //--GET METHOD 
        public List<Kompetenz> getKompetenz()
        {
            List<Kompetenz> ListKomp = new List<Kompetenz>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM kompetenz;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListKomp.Add(
                  new Kompetenz(
                       reader.GetInt32(0),
                        reader.GetInt32(1)

                       ));


            }
            schliessen();
            return ListKomp;
        }

        //--SAVE KOMPETENZ METHOD
        public void saveKompetenz(Kompetenz Komp)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("INSERT INTO kompetenz VALUES (NULL, @KompLevel);", con);
            com.Parameters.AddWithValue("@KompLevel", Komp.Komp_level);

            com.ExecuteNonQuery();

            schliessen();
        }
        //--DELETE KOMPETENZ  
        public void delKompetenz(int komp_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM kompetenz WHERE komp_id = @Komp_id;", con);
            com.Parameters.AddWithValue("@Komp_id", komp_id);
            com.ExecuteNonQuery();

            schliessen();
        }
        
        //------------------------------------------------------------------|KOMPETENZ end









        //SPRACHE ------------------------------------------------------->
        //--GET METHOD 
        public List<Sprache> getSprache()
        {
            List<Sprache> ListSprache = new List<Sprache>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM Sprache;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListSprache.Add(
                  new Sprache(
                       reader.GetInt32(0),
                       reader.GetString(1)


                       ));


            }
            schliessen();
            return ListSprache;
        }

        //--SAVE SPRACHE METHOD
        public void saveSprache(Sprache Sprach)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("INSERT INTO Sprache VALUES (NULL, @SpracheName);", con);
            com.Parameters.AddWithValue("@SpracheName", Sprach.Sprache_name1);


            com.ExecuteNonQuery();

            schliessen();
        }
        //--DELETE SPRACHE  
        public void delSprache(int Sprache_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM Sprache WHERE Sprache_id = @Sprache_id;", con);
            com.Parameters.AddWithValue("@Sprache_id", Sprache_id);
            com.ExecuteNonQuery();

            schliessen();
        }
        //---------------------------------------------------------------|SPRACHE END


        //SPRACHE KOMPETENZ ----------------------------------------------->
        //--GET METHOD 
        public List<Sprache_Kompetenz> getSpracheKompetenz()
        {
            List<Sprache_Kompetenz> ListSprachKomp = new List<Sprache_Kompetenz>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM sprache_kompetenz;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListSprachKomp.Add(
                  new Sprache_Kompetenz(
                       reader.GetInt32(0),
                        reader.GetString(1)

                       ));


            }
            schliessen();
            return ListSprachKomp;
        }

        //--SAVE KOMPETENZ METHOD
        public void saveSpracheKompetenz(Sprache_Kompetenz SprachKomp)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("INSERT INTO sprache_kompetenz VALUES (NULL, @Sprach_komp);", con);
            com.Parameters.AddWithValue("@Sprach_komp", SprachKomp.Sprach_komp);

            com.ExecuteNonQuery();

            schliessen();
        }
        //-----------------------------------------------------------------|SPRACHE KOMPETENZ end









        //MITARBEITER_TECH ------------------------------------------------------>
        //--GET METHOD 
        public List<Mitarb_Tech> getMitarbTech()
        {
            List<Mitarb_Tech> ListMitartech = new List<Mitarb_Tech>();

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM ma_tech;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListMitartech.Add(
                  new Mitarb_Tech(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetString(5)

                       )); ;


            }
            schliessen();
            return ListMitartech;
        }

        //--SAVE MITARBEITER_TECH METHOD
        public void saveMitarbTech(Mitarb_Tech matec)
        {
            try
            {

                oeffnen();

                MySqlCommand com = new MySqlCommand("INSERT INTO ma_tech VALUES (NULL, @Ma_id, @Tech_id, @Komp_id, @SeitJahr, @Tech_name );", con);
                com.Parameters.AddWithValue("@Ma_id", matec.Ma_id);
                com.Parameters.AddWithValue("@Tech_id", matec.Tech_id);
                com.Parameters.AddWithValue("@Komp_id", matec.Komp_id);
                com.Parameters.AddWithValue("@SeitJahr", matec.Seit_jahr);
                com.Parameters.AddWithValue("@Tech_name", matec.Tech_name);

                com.ExecuteNonQuery();
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Doppelter Eintrag: Diese Kombination existiert bereits.");
                }
                else
                {
                    
                    throw;
                }
            }
            schliessen();
        }
        //--DELETE MITARBEITER_TECH 
        public void delMitarbTech(int ma_tech_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM ma_tech WHERE ma_tech_id = @MaTech_id;", con);
            com.Parameters.AddWithValue("@MaTech_id", ma_tech_id);
            com.ExecuteNonQuery();

            schliessen();
        }

        public List<(string Tech_name, string seitjahr, int komp_id)> GetTechForMitarbeiter(int mitarbeiterId)
        {
            List<(string Tech_name, string seitjahr, int komp_id)> result = new List<(string Tech_name, string seitjahr, int komp_id)>();

            oeffnen(); // Open connection

            string query = @"
            SELECT tech_name, seitjahr, komp_id
            FROM ma_tech
            WHERE ma_id = @MitarbeiterId;
            ";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tech_name = reader.GetString("tech_name"); 
                string seitjahr = reader.GetString("seitjahr");
                int komp_id = reader.GetInt32("komp_id"); 
                result.Add((tech_name, seitjahr, komp_id));
            }

            schliessen(); // Close connection

            return result;
        }

      //----------------------------------------------------------------------------------------------------------|MA_TECH END







        //MITARBEITER_PROJEKT -------------------------------------------------------->
        //--GET METHOD 
       
        public List<Mitarb_Projekt> getMitarbProj()
        {
            List<Mitarb_Projekt> ListMitarProj = new List<Mitarb_Projekt>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM ma_projekt;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListMitarProj.Add(
                  new Mitarb_Projekt(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),                        
                        reader.GetString(6),
                        reader.GetString(7)
                       ));


            }
            schliessen();
            return ListMitarProj;
        }

        //--SAVE MITARBEITER_PROJEKT METHOD
        public void saveMitarbProj(Mitarb_Projekt maproj)
        {
            try
            {


                oeffnen();

                MySqlCommand com = new MySqlCommand("INSERT INTO ma_projekt VALUES (NULL, @Ma_id, @Proj_id, @Ma_Rolle, @Start_date, @End_date, @Proj_name, @Taetigkeiten );", con);
                com.Parameters.AddWithValue("@Ma_id", maproj.Ma_id);
                com.Parameters.AddWithValue("@Proj_id", maproj.Proj_id);
                com.Parameters.AddWithValue("@Ma_Rolle", maproj.Ma_rolle);
                com.Parameters.AddWithValue("@Start_date", maproj.Start_date);
                com.Parameters.AddWithValue("@End_date", maproj.End_date);                
                com.Parameters.AddWithValue("@Proj_name", maproj.Proj_name);
                com.Parameters.AddWithValue("@Taetigkeiten", maproj.Taetigkeiten);

                com.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Check if the exception is related to a duplicate key violation
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Doppelter Eintrag: Diese Kombination existiert bereits.");
                }
                else
                {
                    
                    throw;
                }
            }



            schliessen();
        }                                                                             
        //--DELETE MITARBEITER_PROJEKT                                                  
        public void delMitarbProj(int ma_proj_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM ma_projekt WHERE ma_proj_id = @MaProj_id;", con);
            com.Parameters.AddWithValue("@MaProj_id", ma_proj_id);
            com.ExecuteNonQuery();

            schliessen();
        }

        //--GetDetailsForListboxMethod - MA Projekt - 
        public List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date, 
            string End_date)> GetProjektForMitarbeiter(int mitarbeiterId)
        {
            List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date,string End_date)> result = 
                new List<(string Proj_name, string Ma_rolle, string Taetigkeiten, string Start_date, string End_date)>();

            oeffnen(); 

            string query = @"
            SELECT proj_name, ma_rolle, taetigkeiten, start_date, end_date
            FROM ma_projekt
            WHERE ma_id = @MitarbeiterId;
            ";

            MySqlCommand cmd = new MySqlCommand(query, con); 
            cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string projName = reader.GetString("proj_name");
                string maRolle = reader.GetString("ma_rolle");
                string taetigkeiten = reader.GetString("taetigkeiten");
                string startDate = reader.GetString("start_date");
                string endDate = reader.GetString("end_date");
                result.Add((projName, maRolle, taetigkeiten, startDate, endDate));
            }

            schliessen(); 

            return result;
        }

        //--------------------------------------------------------------------------------------------------------|MA_PROJEKT END








        //MITARBEITER_AUSBILDUNG -------------------------------------------------------->
        //--GET METHOD 
        public List<Mitarbeiter_Ausbildung> getMitarAusb()
        {
            List<Mitarbeiter_Ausbildung> ListMitarAusb = new List<Mitarbeiter_Ausbildung>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM ma_ausbildung;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListMitarAusb.Add(
                  new Mitarbeiter_Ausbildung(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3)

                       ));


            }
            schliessen();
            return ListMitarAusb;
        }

        //--SAVE MITARBEITER_AUSBILDUNG METHOD
        public void saveMitarAusb(Mitarbeiter_Ausbildung ma_ausb)
        {
            try
            {
                oeffnen();

                MySqlCommand com = new MySqlCommand("INSERT INTO ma_ausbildung VALUES (NULL, @Ma_id, @Ausb_id, @Ausb_name  );", con);
                com.Parameters.AddWithValue("@Ma_id", ma_ausb.Ma_id);
                com.Parameters.AddWithValue("@Ausb_id", ma_ausb.Ausb_id);
                com.Parameters.AddWithValue("@Ausb_name", ma_ausb.Ausb_name);


                com.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Check if the exception is related to a duplicate key violation
                if (ex.Number == 1062)
                {
                    // Display a message box for duplicate key violation
                    MessageBox.Show("Doppelter Eintrag: Diese Kombination existiert bereits.");
                }
                else
                {
                    // Handle other exceptions or rethrow the exception
                    throw;
                }
            }



            schliessen();
        }

        //--DELETE MITARBEITER_AUSBILDUNG 
        public void delMitarbAusb(int ma_ausb_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM ma_ausbildung WHERE ma_ausb_id = @Ma_ausb_id;", con);
            com.Parameters.AddWithValue("@Ma_ausb_id", ma_ausb_id);
            com.ExecuteNonQuery();

            schliessen();


        }

        //--GetDetailsForListboxMethod
        public List<string> GetAusbildungenForMitarbeiter(int mitarbeiterId)
        {
            List<string> result = new List<string>();

            oeffnen(); 

            string query = @"
        SELECT aus.Ausb_name
        FROM ma_ausbildung maas
        INNER JOIN ausbildungen aus ON maas.Ausb_id = aus.Ausb_id
        WHERE maas.Ma_id = @MitarbeiterId;
    ";

            using (MySqlCommand cmd = new MySqlCommand(query, con)) 
            {
                cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string AusbName = reader.GetString("Ausb_name");
                        result.Add(AusbName); 
                    }
                }
            }

            schliessen(); 

            return result;
        }
        //--------------------------------------------------------------------------------------------------|MA_AUSB END










        //MITARBEITER_SPRACHE -------------------------------------------------------->
        //--GET METHOD 
        public List<Mitarbeiter_Sprache> getMitarSprache()
        {
            List<Mitarbeiter_Sprache> ListMitarSprache = new List<Mitarbeiter_Sprache>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM ma_sprache;";

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ListMitarSprache.Add(
                  new Mitarbeiter_Sprache(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetString(4)

                       ));


            }
            schliessen();
            return ListMitarSprache;
        }

        //--SAVE MITARBEITER_SPRACHE METHOD
        public void saveMitarSprache(Mitarbeiter_Sprache ma_sprach)
        {
            try
            {
                oeffnen();

                MySqlCommand com = new MySqlCommand("INSERT INTO ma_sprache VALUES (NULL, @Ma_id, @Sprache_id, @Sprache_name, @Sprach_komp   );", con);
                com.Parameters.AddWithValue("@Ma_id", ma_sprach.Ma_id);
                com.Parameters.AddWithValue("@Sprache_id", ma_sprach.Sprache_id);                
                com.Parameters.AddWithValue("@Sprache_name", ma_sprach.Sprache_name);
                com.Parameters.AddWithValue("@Sprach_komp", ma_sprach.Sprach_komp);

                com.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Check if the exception is related to a duplicate key violation
                if (ex.Number == 1062)
                {
                    // Display a message box for duplicate key violation
                    MessageBox.Show("Doppelter Eintrag: Diese Kombination existiert bereits.");
                }
                else
                {
                    // Handle other exceptions or rethrow the exception
                    throw;
                }
            }



            schliessen();
        }

        //--DELETE MITARBEITER_SPRACHE 
        public void delMitarSprache(int ma_sprache_id)
        {

            oeffnen();

            MySqlCommand com = new MySqlCommand("DELETE FROM ma_sprache WHERE ma_sprache_id = @Ma_sprache_id;", con);
            com.Parameters.AddWithValue("@Ma_sprache_id", ma_sprache_id);
            com.ExecuteNonQuery();

            schliessen();


        }
       
        //--GetDetailsForListboxMethod
        public List<(string Sprache_name, string Sprach_komp)> GetSpracheForMitarbeiter(int mitarbeiterId)
        {
            List<(string Sprache_name, string Sprach_komp)> result = new List<(string Sprache_name, string Sprach_komp)>();

            oeffnen(); 

            string query = @"
    SELECT Sprache_name, Sprach_komp
    FROM ma_sprache
    WHERE ma_id = @MitarbeiterId;
    ";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string spracheName = reader.GetString("Sprache_name");
                string sprachKomp = reader.GetString("Sprach_komp");
                result.Add((spracheName, sprachKomp));
            }

            schliessen(); 

            return result;
        }

        //------------------------------------------------------------------------------------------------------|MA_SPRACHE END































    }


}






























//NOTES:

/* 
 * com.Parameters.AddWithValue is a method used to add a parameter to the command's parameters collection.
 * 
 * @ProjId is the name of the parameter, matching the placeholder used in the SQL command text.
   - proj_id is the variable that holds the value to be assigned to the @ProjId parameter. 
   - This is where the actual value used in the SQL operation is specified.
   - This method safely binds the value of proj_id to the @ProjId placeholder within the SQL command. 
   - By doing so, it prevents the value from being interpreted as SQL code, which is a key defense against SQL injection attacks.

How It Protects Against SQL Injection:
- Separation of SQL and Data: 
    - The critical aspect of this approach is that it keeps data 
    (the value of proj_id) separate from the SQL code, making it impossible for an attacker to inject malicious SQL through user input.

- Safe Parameter Handling: 
    - The database driver ensures that whatever value proj_id has,  
      it will be treated purely as data to compare against proj_id in the database, not as part of the SQL command to be executed. 

    - Even if proj_id contains potentially harmful SQL code, 
     input is treated strictly as data and not executable code, 
     so if sql code is entered the database will not execute it as part of the SQL statement.






 */



//----------------- DATABASE TABLES --------------------------------------------------------------------------------- 
/* 



 C:\> xampp\mysql\bin\mysql -u root -p

create database ASQA_PROJEKT;
use database asqa_projekt;

MariaDB [asqa_projekt]> show tables;
+------------------------+
| Tables_in_asqa_projekt |
+------------------------+
| ausbildungen           |
| kompetenz              |
| ma_ausbildung          |
| ma_projekt             |
| ma_sprache             |
| ma_tech                |
| mitarbeiter            |
| projekten              |
| sprache                |
| sprache_kompetenz      |
| technologie            |
+------------------------+---------------------------------------------------------------------------


create table projekten 
( proj_id integer primary key auto_increment,
     proj_name varchar (50));

ALTER TABLE projekten
    ADD CONSTRAINT unique_projekt UNIQUE (proj_name);

MariaDB [asqa_projekt]> desc projekten;
+-----------+-------------+------+-----+---------+----------------+
| Field     | Type        | Null | Key | Default | Extra          |
+-----------+-------------+------+-----+---------+----------------+
| proj_id   | int(11)     | NO   | PRI | NULL    | auto_increment |
| proj_name | varchar(50) | YES  |     | NULL    |                |
+-----------+-------------+------+-----+---------+----------------+--------------------------------------






create table technologie 
( tech_id integer primary key auto_increment,
     tech_name varchar (50));

ALTER TABLE technologie
    ADD CONSTRAINT unique_tech UNIQUE (tech_name);

MariaDB [asqa_projekt]> desc technologie;
+-----------+-------------+------+-----+---------+----------------+
| Field     | Type        | Null | Key | Default | Extra          |
+-----------+-------------+------+-----+---------+----------------+
| tech_id   | int(11)     | NO   | PRI | NULL    | auto_increment |
| tech_name | varchar(50) | YES  |     | NULL    |                |
+-----------+-------------+------+-----+---------+----------------+--------------------------------------






create table mitarbeiter 
( ma_id integer primary key auto_increment,
     ma_nachname varchar (50),
     ma_vorname varchar (50),
     ma_gebjahr varchar (50),
  ma_firmarolle varchar (50),
 ma_schwerpunkte varchar (250),
 ma_komminikation varchar (250));

ALTER TABLE mitarbeiter DROP COLUMN ma_komminikation;
ALTER TABLE mitarbeiter ADD komm_id int(11) ;


alter table mitarbeiter drop column komm_id;

+-----------------+--------------+------+-----+---------+----------------+
| Field           | Type         | Null | Key | Default | Extra          |
+-----------------+--------------+------+-----+---------+----------------+
| ma_id           | int(11)      | NO   | PRI | NULL    | auto_increment |
| ma_nachname     | varchar(50)  | YES  |     | NULL    |                |
| ma_vorname      | varchar(50)  | YES  |     | NULL    |                |
| ma_gebjahr      | varchar(50)  | YES  |     | NULL    |                |
| ma_firmarolle   | varchar(50)  | YES  |     | NULL    |                |
| ma_schwerpunkte | varchar(250) | YES  |     | NULL    |                |
+-----------------+--------------+------+-----+---------+----------------+-----------------------------------







create table kompetenz 
( komp_id integer primary key auto_increment,
     kompetenz int (2));

ALTER TABLE kompetenz DROP COLUMN kompetenz;
ALTER TABLE kompetenz ADD komp_level INT(2);

INSERT INTO kompetenz (komp_level) VALUES (1), (2), (3), (4), (5);

+------------+---------+------+-----+---------+----------------+
| Field      | Type    | Null | Key | Default | Extra          |
+------------+---------+------+-----+---------+----------------+
| komp_id    | int(11) | NO   | PRI | NULL    | auto_increment |
| komp_level | int(2)  | YES  |     | NULL    |                |
+------------+---------+------+-----+---------+----------------+-------------------------------------------






create table sprache
( komm_id integer primary key auto_increment,
 Sprache_name varchar (50));
 
ALTER TABLE sprache CHANGE COLUMN komm_id sprache_id INT;
ALTER TABLE sprache
    ADD CONSTRAINT unique_sprache UNIQUE (sprache_name);

UPDATE sprache
SET sprache_name = Niederlandisch
WHERE komm_id = 1;
+------------+----------------+
| sprache_id | Sprache_name   |
+------------+----------------+
|          1 | Niederländisch |
|          2 | Deutsch        |
|          3 | English        |
|          4 | Französisch    |
+------------+----------------+-------------------------------------------------------------------------


create table ausbildungen ( ausb_id integer primary key auto_increment, 
ausb_name varchar (50), 
aus_jahr date, 
ausb_institut varchar (150) );


ALTER TABLE ausbildungen 
MODIFY COLUMN aus_jahr VARCHAR(4);
+---------------+--------------+------+-----+---------+----------------+
| Field         | Type         | Null | Key | Default | Extra          |
+---------------+--------------+------+-----+---------+----------------+
| ausb_id       | int(11)      | NO   | PRI | NULL    | auto_increment |
| ausb_name     | varchar(50)  | YES  |     | NULL    |                |
| aus_jahr      | varchar(4)   | YES  |     | NULL    |                |
| ausb_institut | varchar(150) | YES  |     | NULL    |                |
+---------------+--------------+------+-----+---------+----------------+---------------------------------------

UPDATE Ausbildungen
SET ausb_name = 'BSc CS', ausb_institut = 'TU Berlin', aus_jahr = '2010'
WHERE ausb_id = 1;

UPDATE Ausbildungen
SET ausb_name = 'BSc Bioinformatcs', ausb_institut = 'Humbolt Berlin', aus_jahr = '2013'
WHERE ausb_id = 2;

UPDATE Ausbildungen
SET ausb_name = 'Fachinformatik Anwendungsentwicklung', ausb_institut = 'IHK Berlin', aus_jahr = '2000'
WHERE ausb_id = 3;

UPDATE Ausbildungen
SET ausb_name = 'BA Social Science', ausb_institut = 'FU Berlin', aus_jahr = '1999'
WHERE ausb_id = 4;

UPDATE Ausbildungen
SET ausb_name = 'Msc CS', ausb_institut = 'TU Berlin', aus_jahr = '1980'
WHERE ausb_id = 5;
+---------+--------------------------------------+----------+----------------+
| ausb_id | ausb_name                            | aus_jahr | ausb_institut  |
+---------+--------------------------------------+----------+----------------+
|       1 | BSc CS                               | 2010     | TU Berlin      |
|       2 | BSc Bioinformatcs                    | 2013     | Humbolt Berlin |
|       3 | Fachinformatik Anwendungsentwicklung | 2000     | IHK Berlin     |
|       4 | BA Social Science                    | 1999     | FU Berlin      |
|       5 | Msc CS                               | 1980     | TU Berlin      |
+---------+--------------------------------------+----------+----------------+-----------------------------------








------------------------------    MA_TABLES    -------------------------------------------------------------------------------------------------------------------------------------------->

CREATE TABLE ma_projekt (
ma_proj_id INT PRIMARY KEY auto_increment,
ma_id INT,
proj_id INT,
ma_rolle varchar(50),
FOREIGN KEY (ma_id) REFERENCES mitarbeiter(ma_id),
FOREIGN KEY (proj_id) REFERENCES projekten(proj_id)
);

ALTER TABLE ma_projekt
     ADD COLUMN start_date DATE,
     ADD COLUMN end_date DATE,
     ADD COLUMN bis_heute TINYINT(1);

ALTER TABLE Ma_projekt
ADD CONSTRAINT unique_ma_proj UNIQUE (ma_id, proj_id, ma_rolle, start_date, end_date);

ALTER TABLE ma_projekt
         ADD COLUMN proj_name varchar(50); 
ALTER TABLE ma_projekt
         ADD COLUMN taetigkeiten varchar(150);

ALTER TABLE ma_projekt 
MODIFY COLUMN start_date VARCHAR(50);
ALTER TABLE ma_projekt 
MODIFY COLUMN end_date VARCHAR(50);
ALTER TABLE ma_projekt DROP COLUMN bis_heute;


 desc ma_projekt;
+--------------+--------------+------+-----+---------+----------------+
| Field        | Type         | Null | Key | Default | Extra          |
+--------------+--------------+------+-----+---------+----------------+
| ma_proj_id   | int(11)      | NO   | PRI | NULL    | auto_increment |
| ma_id        | int(11)      | YES  | MUL | NULL    |                |
| proj_id      | int(11)      | YES  | MUL | NULL    |                |
| ma_rolle     | varchar(50)  | YES  |     | NULL    |                |
| start_date   | varchar(50)  | YES  |     | NULL    |                |
| end_date     | varchar(50)  | YES  |     | NULL    |                |
| proj_name    | varchar(50)  | YES  |     | NULL    |                |
| taetigkeiten | varchar(150) | YES  |     | NULL    |                |
+--------------+--------------+------+-----+---------+----------------+----------------------------------------







 * MariaDB [asqa_projekt]> CREATE TABLE ma_tech (
         ma_tech_id INT PRIMARY KEY auto_increment,
         ma_id INT,
         tech_id INT,
         komp_id INT,
    
         FOREIGN KEY (ma_id) REFERENCES mitarbeiter(ma_id),
         FOREIGN KEY (tech_id) REFERENCES technologie(tech_id),
         FOREIGN KEY (komp_id) REFERENCES kompetenz(komp_id)
         );

ALTER TABLE ma_tech
    ADD CONSTRAINT unique_mitarskill UNIQUE (ma_id, tech_id, komp_id);
 
ALTER TABLE ma_tech
     ADD COLUMN seitjahr varchar(4);

ALTER TABLE ma_tech
         ADD COLUMN tech_name varchar(50);

MariaDB [asqa_projekt]> desc ma_tech;
+------------+---------+------+-----+---------+----------------+
| Field      | Type    | Null | Key | Default | Extra          |
+------------+---------+------+-----+---------+----------------+
| ma_tech_id | int(11) | NO   | PRI | NULL    | auto_increment |
| ma_id      | int(11) | YES  | MUL | NULL    |                |
| tech_id    | int(11) | YES  | MUL | NULL    |                |
| komp_id    | int(11) | YES  | MUL | NULL    |   
| seitjahr   |varchar(4)| YES |     | NULL    |                |
+------------+---------+------+-----+---------+----------------+----------------------------------------------
   









 CREATE TABLE Ma_Ausbildung (
    ma_ausb_id INT AUTO_INCREMENT PRIMARY KEY,
    ma_id INT NOT NULL,
    ausb_id INT NOT NULL,
    FOREIGN KEY (ma_id) REFERENCES Mitarbeiter(ma_id),
    FOREIGN KEY (ausb_id) REFERENCES Ausbildungen(ausb_id),
    UNIQUE (ma_id, ausb_id) -- optional constraint to avoid duplicate associations
);
  
ALTER TABLE ma_ausbildung
    ->      ADD COLUMN ausb_name varchar(50);

 desc ma_ausbildung;
+------------+-------------+------+-----+---------+----------------+
| Field      | Type        | Null | Key | Default | Extra          |
+------------+-------------+------+-----+---------+----------------+
| ma_ausb_id | int(11)     | NO   | PRI | NULL    | auto_increment |
| ma_id      | int(11)     | NO   | MUL | NULL    |                |
| ausb_id    | int(11)     | NO   | MUL | NULL    |                |
| ausb_name  | varchar(50) | YES  |     | NULL    |                |
+------------+-------------+------+-----+---------+----------------+-------------------------------------------









 CREATE TABLE Ma_Sprache(
    ma_sprache_id INT AUTO_INCREMENT PRIMARY KEY,
    ma_id INT ,
    sprache_id INT ,    
    Sprache_name varchar (50) ,
    Sprach_komp varchar (50),
    FOREIGN KEY (ma_id) REFERENCES Mitarbeiter(ma_id),
    FOREIGN KEY (sprache_id) REFERENCES sprache(sprache_id),
   
    UNIQUE (ma_id, sprache_id,Sprach_komp ) 
);

ALTER TABLE ma_sprache DROP COLUMN komp_id;
ALTER TABLE ma_sprache ADD sprach_komp varchar(50);

desc ma_sprache;
+---------------+-------------+------+-----+---------+----------------+
| Field         | Type        | Null | Key | Default | Extra          |
+---------------+-------------+------+-----+---------+----------------+
| ma_sprache_id | int(11)     | NO   | PRI | NULL    | auto_increment |
| ma_id         | int(11)     | YES  | MUL | NULL    |                |
| sprache_id    | int(11)     | YES  | MUL | NULL    |                |
| Sprache_name  | varchar(50) | YES  |     | NULL    |                |
| Sprach_komp   | varchar(50) | YES  |     | NULL    |                |
+---------------+-------------+------+-----+---------+----------------+---------------------------------------












create table sprache_kompetenz 
( sprachkomp_id integer primary key auto_increment,
     sprach_komp varchar (50));
+---------------+-------------+------+-----+---------+----------------+
| Field         | Type        | Null | Key | Default | Extra          |
+---------------+-------------+------+-----+---------+----------------+
| sprachkomp_id | int(11)     | NO   | PRI | NULL    | auto_increment |
| sprach_komp   | varchar(50) | YES  |     | NULL    |                |
+---------------+-------------+------+-----+---------+----------------+
INSERT INTO sprache_kompetenz (sprach_komp) VALUES ('Muttersprache'), ('Gut'), ('Grundlegend/Basic');

+---------------+-------------------+
| sprachkomp_id | sprach_komp       |
+---------------+-------------------+
|             1 | Muttersprache     |
|             2 | Gut               |
|             3 | Grundlegend/Basic |
+---------------+-------------------+------------------------------------------------------------------------







--- TO DO -----

> Git/ Version Control connection


> Connection of MA_Tech  
> Connection of MA_Sprache
> Connection of MA_Projekten

> change the kompetenz of sprache to words,,,muttersprache, gut , basic


> Funktionality that the listboxes only shows the selected ma details


> Front Page Profile Functionality
> Front Page Profile Design
 -- cb should be empty with wording/ placeholder: "please select Mitarbeiter"
 -- coloouzr scheme
 -- dynamic boxes for projects and skills




> Documentation and Presentation Start

SQL COMMANDS:



INSERT INTO sprache_kompetenz (sprach_komp) VALUES ('Muttersprache'), ('Gut'), ('Grundlegend/Basic');

ALTER TABLE ma_sprache DROP COLUMN komp_id;
ALTER TABLE ma_sprache ADD sprach_komp varchar(50);

ALTER TABLE ausbildungen 
MODIFY COLUMN aus_jahr VARCHAR(4);





----------------------------------DATABASE SELECT QUERIES--------------------------------------------------------------------------
step1 --in database

         public List<string> GetAusbildungenForMitarbeiter(int mitarbeiterId)
        {
            List<string> result = new List<string>();

            oeffnen(); 

            string query = @"
        SELECT aus.Ausb_name
        FROM ma_ausbildung maas
        INNER JOIN ausbildungen aus ON maas.Ausb_id = aus.Ausb_id
        WHERE maas.Ma_id = @MitarbeiterId;
    ";

            using (MySqlCommand cmd = new MySqlCommand(query, con)) // Assuming 'con' is your MySqlConnection object
            {
                cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string AusbName = reader.GetString("Ausb_name");
                        result.Add(AusbName); // Correctly add each Ausbildung name to the result list
                    }
                }
            }

            schliessen(); // Assuming this closes the database connection

            return result;


step 2- inf form
            lbMaAusb.Items.Clear();
              
                var ausbildungen = db.GetAusbildungenForMitarbeiter(selectedMitarbeiter.Ma_id);

                foreach (var (Ausb_name) in ausbildungen)
                {
                    lbMaAusb.Items.Add($"{Ausb_name}");
                }
------------------------------------------------------------------------------------------------------------------------------------

public List<(string Tech_name, string seitjahr, int komp_id)> GetTechForMitarbeiter(int mitarbeiterId)
{
    List<(string Tech_name, string seitjahr, int komp_id)> result = new List<(string Tech_name, string seitjahr, int komp_id)>();

    oeffnen(); // Open connection

    // Assuming the view 'v_mitarbeiter_tech' is already created and includes a way to filter by 'Ma_id' or 'mitarbeiterId'
    string query = @"
SELECT tech_name, seitjahr, komp_id
FROM v_mitarbeiter_tech
WHERE ma_id = @MitarbeiterId;
";

    MySqlCommand cmd = new MySqlCommand(query, con);
    cmd.Parameters.AddWithValue("@MitarbeiterId", mitarbeiterId);

    MySqlDataReader reader = cmd.ExecuteReader();

    while (reader.Read())
    {
        string tech_name = reader.GetString("tech_name"); // Ensure column names match those in your database
        string seitjahr = reader.GetString("seitjahr");
        int komp_id = reader.GetInt32("komp_id"); // Assuming 'komp_id' is stored as an int
        result.Add((tech_name, seitjahr, komp_id));
    }

    schliessen(); // Close connection

    return result;
}





         
































































 */

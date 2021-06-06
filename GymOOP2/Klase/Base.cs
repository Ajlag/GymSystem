using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymOOP2.Klase
{
    class Base
    {
        private static string connectionString = @"data source =DESKTOP-II5F5UR; initial catalog = Teretana; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework & quot;";
        private static SqlConnection connect = new SqlConnection(connectionString);

        public static void DodajClana(string tbIme, string tbPrezime, string tbbrTelefona, string tbAdresa, string tbemail, string tbJMBG, string pol, DateTime dtpdatumup,DateTime uplataClanarine, string DodelaTrenera, string Clanarina, string Grupa)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand(" INSERT INTO clan( Ime,Prezime,brTelefona,adresa,email,JMBG,pol,datumUpisa,UplataClanarine,DodelaTrenera,Clanarina,Zauzet,Grupa) values('" + tbIme + "','" + tbPrezime + "','" + tbbrTelefona + "','" + tbAdresa + "','" + tbemail + "','" + tbJMBG + "','" + pol + "','" + dtpdatumup + "','"+ uplataClanarine + "','" + DodelaTrenera + "','" + Clanarina + "','" + "NE" + "','" + Grupa + "');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static void azuriranjeClanova(string tbbrTelefona, string tbAdresa, string tbemail, string tbJMBG, string dtpdatumup, string Clanarina)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE clan SET  brTelefona='" + tbbrTelefona + "',adresa='" + tbAdresa + "',email='" + tbemail + "' , datumUpisa='" + dtpdatumup + "',Clanarina='" + Clanarina + "' WHERE JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static void brisanjeClanova(string tbJMBG, string tbIme, string tbPrezime)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("DELETE FROM Prisustvo where IDClana='"+tbJMBG+"';DELETE FROM clan where JMBG='" + tbJMBG + "' and  Ime='" + tbIme + "' and Prezime='" + tbPrezime + "' and JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }


        public static List<clan> PrikaziSveClanove()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<clan> lista2 = vezasaBazom.clans.ToList();
            return lista2;
        }

        public static DataTable radniciBox(clan o)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From clan;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }

        private static bool proveraKorisnikaZaReset(korisnik k)
        {
            connect.Open();
            string sql = "SELECT * FROM korisnik WHERE KorisnickoIme = @KorisnickoIme AND Lozinka = @Lozinka";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@KorisnickoIme", k.KorisnickoIme);
            cmd.Parameters.AddWithValue("@Lozinka", k.Lozinka);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        public static bool resetLozinku(korisnik k, string novasifra)
        {
            if (proveraKorisnikaZaReset(k))
            {
                string sql = "UPDATE korisnik SET [Lozinka] = @Lozinka WHERE [KorisnickoIme] = @KorisnickoIme";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add("@Lozinka", SqlDbType.Char).Value = novasifra;
                cmd.Parameters.Add("@KorisnickoIme", SqlDbType.Char).Value = k.KorisnickoIme;

                connect.Open();

                int rows = cmd.ExecuteNonQuery();

                connect.Close();

                if (rows > 0)
                    return true;
                return false;
            }
            else return false;
        }


        public static List<string> prikaziImezaGrupu()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();


            foreach (var cl in lista2)
            {
                if (cl.Grupa == "DA" && cl.Zauzet == "NE" && cl.DodelaTrenera == "DA")
                {
                    prikazati = cl.Ime + " " + cl.Prezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }
            }

            return zaPrikaz;
        }

        public static List<string> imezaIndividualni()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var cl in lista2)
            {
                if (cl.Grupa == "NE" && cl.Zauzet == "NE" && cl.DodelaTrenera == "DA")
                {
                    prikazati = cl.Ime + " " + cl.Prezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }
            }
            return zaPrikaz;
        }


        //Da se promene cene prema ID
        public static void Promenicene(int cena1, int cena2, int cena3, int cena4, string poslednjePromene)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Update cenovnik set cena =" + cena1 + " where tip = 'MG';Update cenovnik set cena =" + cena2 + " where tip= 'MI';Update cenovnik set cena =" + cena3 + " where tip= 'GT'; Update cenovnik set cena =" + cena4 + " where tip= 'IT'; Update cenovnik set poslednjePromene='" + poslednjePromene + "';", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }


        //Da se prikazu cene
        public static DataTable selectCene()
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From cenovnik ;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }

        public static List<string> ImenaTrenera()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<korisnik> lista2 = vezasaBazom.korisniks.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var tr in lista2)
            {
                if (tr.tip == "T")
                {
                    prikazati = tr.ImeiPrezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }

            }
            return zaPrikaz;
        }







        public static string PrikazIDC(string ime, string prezime)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.clans.Where(x => x.Ime == ime && x.Prezime == prezime).FirstOrDefault().JMBG;
        }


        public static void PromenaZauzet(String tbJMBG)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE clan SET  Zauzet='DA' WHERE JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static void PromenaZauzetNE(String tbJMBG)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE clan SET  Zauzet='NE' WHERE JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static void ZakaziTermin(String IDClana, String ImeiPrezimeTrenera, DateTime Datum, string Vreme)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into Termin (IDClan,Trener,Datum,Vreme) values('" + IDClana + "','" + ImeiPrezimeTrenera + "','" + Datum + "','" + Vreme + "'); ", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable UlogujKorisnika(korisnik k)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM korisnik WHERE KorisnickoIme = @KorisnickoIme AND Lozinka = @Lozinka";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@KorisnickoIme", k.KorisnickoIme);
            cmd.Parameters.AddWithValue("@Lozinka", k.Lozinka);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();

            return dt;
        }


        public static void DodajOpremu(string NazivOpreme, string opis, String cena)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into Oprema (NazivOpreme,opis,cena) values('" + NazivOpreme + "','" + opis + "','" + cena + "');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static List<Oprema> prikazOpreme()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<Oprema> oprema = vezasaBazom.Opremas.ToList();
            return oprema;
        }


        public static List<Termin> PrikazTermina(String IDClana)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<Termin> lista2 = vezasaBazom.Termins.Where(x => x.IDClan == IDClana).ToList();
            return lista2;
        }

        public static List<clan> PrikazClana(String IDClana)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<clan> lista2 = vezasaBazom.clans.Where(x => x.JMBG == IDClana).ToList();
            return lista2;
        }
        public static DataTable UlazClanova(clan c)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM clan WHERE JMBG = @JMBG";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@JMBG", c.JMBG);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();

            return dt;
        }

        public static List<Prisustvo> PrikazPrisustva()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<Prisustvo> prisustvo = vezasaBazom.Prisustvoes.OrderByDescending(x=>x.IDP).ToList();
            return prisustvo;
        }
        public static string PrikaziJMBGzaMesecnu(string ime, string prezime)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.clans.Where(x => x.Ime == ime && x.Prezime == prezime && x.Clanarina == "Mesecna").FirstOrDefault().JMBG;
        }
        public static string PrikaziJMBGzaDnevnu(string ime, string prezime)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.clans.Where(x => x.Ime == ime && x.Prezime == prezime && x.Clanarina == "Dnevna").FirstOrDefault().JMBG;
        }

        public static List<string> imezaMesecnu()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var cl in lista2)
            {
                if (cl.Clanarina == "Mesecna ")
                {
                    prikazati = cl.Ime + " " + cl.Prezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }
            }
            return zaPrikaz;
        }

        public static List<string> imezaDnevnu()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var cl in lista2)
            {
                if (cl.Clanarina == "Dnevna")
                {
                    prikazati = cl.Ime + " " + cl.Prezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }
            }
            return zaPrikaz;
        }

        public static void produziClanarinu(DateTime datum ,String tbJMBG)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE clan SET  UplataClanarine='"+datum+"' WHERE JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static DateTime PrikaziClanarinu(String JMBG)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.clans.Where(x => x.JMBG == JMBG).FirstOrDefault().UplataClanarine.Value;
        }
        public static String SelektujClanarinu(String JMBG)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.clans.Where(x => x.JMBG == JMBG).FirstOrDefault().Clanarina;
        }

        public static void DodajPrisustvo(string JMBG1, DateTime DatumiVreme1,String Promene1)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into Prisustvo(IDClana,DatumiVreme,Promene) values('" + JMBG1 + "','" + DatumiVreme1+ "','" + Promene1 +"');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable SelectPrisustvo(Prisustvo c)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Prisustvo WHERE IDClana = @IDClana";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IDClana", c.IDClana);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();

            return dt;
        }
        public static string UlaziliIzlaz(String IDClana)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.Prisustvoes.Where(x => x.IDClana == IDClana).OrderByDescending(x=>x.IDP).First().Promene;
        }

        public static void DodajKorisnika(string ImeiPrezime, string KorisnickoIme, string Lozinka, string tip)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand(" INSERT INTO korisnik(ImeiPrezime,KorisnickoIme,Lozinka,tip,potvrda) values('" + ImeiPrezime + "','" + KorisnickoIme + "','" + Lozinka + "','" + tip+"','"+"NE"+"');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static List<korisnik> PrikaziSveRadnike()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<korisnik> lista2 = vezasaBazom.korisniks.Where(x=> x.tip=="R" && x.potvrda=="DA").ToList();
            return lista2;
        }

        public static List<korisnik> PrikaziSveTrenere()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            List<korisnik> lista2 = vezasaBazom.korisniks.Where(x => x.tip == "T" && x.potvrda=="DA").ToList();
            return lista2;
        }

        public static List<string> imeRadnikaZaPotvrdu()
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            string prikazati;
            List<korisnik> lista2 = vezasaBazom.korisniks.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var k in lista2)
            {
                if (k.potvrda=="NE")
                {
                    prikazati = k.ImeiPrezime;
                    zaPrikaz.Add(prikazati);
                }
                else
                {
                    continue;
                }
            }
            return zaPrikaz;
        }

        public static string KorisnickoImeRadnika(string imeiprezime)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.korisniks.Where(x => x.ImeiPrezime == imeiprezime).FirstOrDefault().KorisnickoIme;
        }
        public static string tipKorisnika(string imeiprezime)
        {
            TeretanaEntities vezasaBazom = new TeretanaEntities();
            return vezasaBazom.korisniks.Where(x => x.ImeiPrezime == imeiprezime).FirstOrDefault().tip;
        }

        public static void potvrdiKorisnika(String KorisnickoIme)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE korisnik SET  potvrda='"+"DA"+"' WHERE KorisnickoIme='" + KorisnickoIme + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
    }

}

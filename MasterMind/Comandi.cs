using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MasterMind
{
    internal class Comandi
    {
        public static void SalvaStorico(int[] colori, int r)
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" INSERT INTO storico(colore1,colore2,colore3,colore4, n_riga) VALUES(@c1, @c2, @c3, @c4, @r);");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.AddWithValue("@c1", colori[0]);
                    cmd.Parameters.AddWithValue("@c2", colori[1]);
                    cmd.Parameters.AddWithValue("@c3", colori[2]);
                    cmd.Parameters.AddWithValue("@c4", colori[3]);
                    cmd.Parameters.AddWithValue("@r", r);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public static void ClearStorico()
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SET SQL_SAFE_UPDATES = 0; DELETE FROM storico;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                   cmd.ExecuteNonQuery();
                }

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public static void SalvaPartite(int esito)
        {
            if(esito == 1)
            {
                try
                {
                    // Apertura connessione
                    if (!GestioneMySql.ApriConnessione())
                        throw new Exception("Errore nell'apertura della connessione.");

                    // Query da eseguire
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" UPDATE partite SET vittorie = vittorie + 1 WHERE id=1");

                    using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Chiusura connessione
                    if (!GestioneMySql.ChiudiConnessione())
                        throw new Exception("Errore nella chiusura della connessione.");
                }
                catch (Exception ex)
                {
                    GestioneMySql.ChiudiConnessione();
                    MessageBox.Show("Errore: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    // Apertura connessione
                    if (!GestioneMySql.ApriConnessione())
                        throw new Exception("Errore nell'apertura della connessione.");

                    // Query da eseguire
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE partite SET sconfitte = sconfitte + 1 WHERE id=1;");

                    using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Chiusura connessione
                    if (!GestioneMySql.ChiudiConnessione())
                        throw new Exception("Errore nella chiusura della connessione.");
                }
                catch (Exception ex)
                {
                    GestioneMySql.ChiudiConnessione();
                    MessageBox.Show("Errore: " + ex.Message);
                }
            }
            
        }

        public static int[] Statistiche()
        {
            int[] stat = new int[2];
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT * FROM partite WHERE id = 1;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            stat[0] = dr.GetInt32("vittorie"); 
                            stat[1] = dr.GetInt32("sconfitte");
                        }
                    }
                }

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                MessageBox.Show("Errore: " + ex.Message);
            }
            return stat;
        }
    }
}

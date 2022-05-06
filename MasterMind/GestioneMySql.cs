﻿using System.Data;
using MySql.Data.MySqlClient;

public  class GestioneMySql
{
    public static string StringaConnessione =
        "Data Source=localhost;Database=mastermind;userid=root;password=root;";
    public static MySqlConnection Connessione = new MySqlConnection(StringaConnessione);

    public static bool ApriConnessione()
    {
        try
        {
            if (Connessione.State != ConnectionState.Open)
            {
                Connessione.ConnectionString = GestioneMySql.StringaConnessione;
                Connessione.Open();
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool ChiudiConnessione()
    {
        try
        {
            if (Connessione.State != System.Data.ConnectionState.Closed)
            {
                Connessione.Close();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Le transazioni solo con database di tipo INNODB
    private static MySqlTransaction Transazione = null;

    public static void TransazioneBegin()
    {
        Transazione = Connessione.BeginTransaction();
    }

    public static void TransazioneCommit()
    {
        Transazione.Commit();
    }

    public static void TransazioneRollback()
    {
        Transazione.Rollback();
    }
}

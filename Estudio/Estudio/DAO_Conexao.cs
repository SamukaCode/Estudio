﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class DAO_Conexao
    {
        private static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";database=" + banco + ";password=" + senha +"; SslMode = none");
                // con.Open();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // con.Clone();
            }
            return retorno;
        }

        public static int login(String usuario, String senha)
        {
            int tipo = 0; // 0 quando não encontra

            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("SELECT * FROM Estudio_Login WHERE usuario='" + usuario + "' and senha ='" + senha+"'",con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
    }
}

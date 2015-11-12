using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class DBConexao
    {
        private MySqlConnection conexao;
        private string servidor, baseDados, usuario, senha;

        public DBConexao()
        {
            Iniciar();
        }
        //deine as variaveis de connexao
        private void Iniciar()
        {
            servidor = "localhost";
            baseDados = "game";
            usuario = "root";
            senha = "root";
            string stringConexao = "SERVER="+servidor+";DATABASE="+baseDados+";UID="+usuario+";PASSWORD="+senha+";";

            conexao = new MySqlConnection(stringConexao);//cria uma conexao
        }
        //abre a conexao
        public bool AbrirConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //facha a conexao
        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        ///funçao de inserir
        public bool inserir(string query)
        {
            if(this.AbrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FecharConexao();
                return true;
            }
            return false;
        }
        //seleciona dados
        public MySqlDataReader Select(string query)
        {
            if(this.AbrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                return cmd.ExecuteReader();
            }
            return null;
        }
    }
}

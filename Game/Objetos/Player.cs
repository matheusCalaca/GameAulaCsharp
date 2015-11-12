using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class Player
    {
        string nome= "";
        int id;
        public List<Pontuacao> pontuacoes = new List<Pontuacao>();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public bool Carregar()
        {
            DBConexao conexao = new DBConexao();
            string select = "select pl.Id as IdPlayer, pl.Nome as Nome, po.Data as DataJogo, po.Pontos as Pontos from Players pl inner join Pntuacao po on pl.Id = po.IdPlayers where pl.Nome like '"+nome+"'";

            MySqlDataReader data = conexao.Select(select);
            Pontuacao p;
            pontuacoes = new List<Pontuacao>();

            while (data.Read())
            {
                nome = (string)data["nome"];
                id = (int)data["IdPlayer"];
                p = new Pontuacao();
                p.Data = (DateTime)data["DataJogo"];
                p.Pontos = (long)data["Pontos"];
                pontuacoes.Add(p);
            }

            return true;
        }
    }
}

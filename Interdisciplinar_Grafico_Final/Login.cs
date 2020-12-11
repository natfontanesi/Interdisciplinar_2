using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Interdisciplinar_Grafico_Final
{
    class Login    
    {

        public NpgsqlConnection conn;
        public string connString = @"Host=127.0.0.1;Username=postgres;Password=dkcn09242627;Database=Projeto_Interdisciplinar";
        public NpgsqlCommand cmd;
        public string selecao = null;
        public string tblLogin;
        public string txtUser;
        public string txtSenha;


        public int login(string value,string user,string senha)
        {
            tblLogin = value;
            txtUser = user;
            txtSenha = senha;
            int resultado;
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            selecao = new NewStruct((@"select * from"), tblLogin, "(:_usuario,:_senha)");
            cmd = new NpgsqlCommand(selecao, conn);


            cmd.Parameters.AddWithValue("_usuario", txtUser);
            cmd.Parameters.AddWithValue("_senha", txtSenha);

            resultado = (int)cmd.ExecuteScalar();

            conn.Close();

            return resultado;
        }
    }

    internal struct NewStruct
    {
        public string Item1;
        public string tblLogin;
        public string Item3;

        public NewStruct(string item1, string tblLogin, string item3)
        {
            Item1 = item1;
            this.tblLogin = tblLogin;
            Item3 = item3;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   Item1 == other.Item1 &&
                   tblLogin == other.tblLogin &&
                   Item3 == other.Item3;
        }

        public override int GetHashCode()
        {
            int hashCode = -1727722770;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tblLogin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Item3);
            return hashCode;
        }

        public void Deconstruct(out string item1, out string tblLogin, out string item3)
        {
            item1 = Item1;
            tblLogin = this.tblLogin;
            item3 = Item3;
        }

        public static implicit operator (string, string tblLogin, string)(NewStruct value)
        {
            return (value.Item1, value.tblLogin, value.Item3);
        }

        public static implicit operator NewStruct((string, string tblLogin, string) value)
        {
            return new NewStruct(value.Item1, value.tblLogin, value.Item3);
        }

        public static implicit operator string(NewStruct v)
        {
            throw new NotImplementedException();
        }
    }
}

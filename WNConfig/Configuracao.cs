using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNConfig
{
    public class Configuracao
    {
        //string de conexao
        public string StringDeConexaoBD { get; set; }
        public int DbServerVersionMaior { get; set; }
        public int DbServerVersionMenor { get; set; }
        public int DbServerVersionBuild { get; set; }

        //configuracao de email
        public string EmailHost { get; set; }
        public string EmailPort { get; set; }
        public bool EmailUseSsl { get; set; }
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
    }
}

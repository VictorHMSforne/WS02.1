using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WS02._1.Servico.Modelo;


namespace WS02._1.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string endereco)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, endereco);
            WebClient wb = new WebClient();
            wb.Encoding = Encoding.UTF8; // aqui faz com que os acentos fiquem certos
            string Conteudo = wb.DownloadString(NovoEnderecoURL);
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);
            if(end.cep == null) return null;
            return end;
        }
    }
}

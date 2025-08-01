using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comumusic
{
    class Episodio
    {
        public Episodio(string titulo)
        {
            Titulo = titulo;
        }
        private List<string> convidados = new List<string>();
        public string Titulo { get; }
        public int Ordem { get; set; }
        public string Resumo { get; set; }
        public int Duracao { get; set; }

        public void AdicionarConvidados(string convidado) 
        {
            convidados.Add(convidado);            
        }
    }
}

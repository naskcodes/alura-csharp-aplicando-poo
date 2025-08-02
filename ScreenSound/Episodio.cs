using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comumusic
{
    class Episodio
    {
        //Corrreção: private List<string> convidados = new();
        public Episodio(string titulo)
        {
            Titulo = titulo;
            //Correção: Ordem e Duração também deveriam ter sido criados no construtor e seus setters deveriam ter sido removidos.
        }
        private List<string> convidados = new List<string>();
        public string Titulo { get; }
        public int Ordem { get; set; }
        public string Resumo { get; set; }
        //Corrreção: public string Resumo => $"{Ordem}. {Título} ({Duracao} mins) - {string.Join(", ", convidados)}"
        public int Duracao { get; set; }

        public void AdicionarConvidados(string convidado) 
        {
            convidados.Add(convidado);            
        }
    }
}

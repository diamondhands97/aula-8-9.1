using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aviao
{
    public class Aviao
    {
        private string modelo;
        private float velocidade;
        private float altitude;
        private string marca;



        public void Reduzir()
        {
            Console.WriteLine("reduzir");
        }



        public void Descer()
        {
            Console.WriteLine("descer");
        }



        public void Acelerar()
        {
            Console.WriteLine("acelerar");
        }



        public string Subir()
        {
            return "subir --->";
        }
    }
}

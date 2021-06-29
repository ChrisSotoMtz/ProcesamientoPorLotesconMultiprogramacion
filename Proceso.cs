using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesamiento_por_lotes
{
    class Proceso
    {
       
        public string id { get; set; }
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int  tiempo { get; set; }
        public int tiempoOriginal { get; set; }
        public string tdo { get; set; }
        public int numerolote { get; set; }
        public string operacion { get; set; }
        public string resultado { get; set; }
    }
}

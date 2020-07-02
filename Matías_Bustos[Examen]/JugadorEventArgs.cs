using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matías_Bustos_Examen_
{
    public class JugadorEventArgs:EventArgs
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public bool Lesion { get; set; }
    }
}

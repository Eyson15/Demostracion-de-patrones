using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsConsumidor
    {
        private ClsCola<ClsUsuario> _cola;
        public ClsConsumidor(ClsCola <ClsUsuario> cola)
        {
            _cola = cola;
        }
        public ClsUsuario Consumir()
        {
            ClsUsuario usuario =  _cola.Extraer();
            Thread.Sleep(5000);
            return usuario;
        }
    }
}

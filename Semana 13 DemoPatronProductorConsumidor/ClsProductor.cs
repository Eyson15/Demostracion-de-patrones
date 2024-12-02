using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsProductor
    {
        private ClsCola<ClsUsuario> _cola;
        // EN EL CONRUCTOR SE REALIZA LA INYECCION DE DEPENDENCIAS
        public ClsProductor( ClsCola <ClsUsuario> cola)
        {
            _cola = cola;
        }
        public void Producir (ClsUsuario item)
        {
            _cola.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}

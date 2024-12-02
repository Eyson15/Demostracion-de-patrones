using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsCliente
    {
        private ClsBarra<ClsProducto> _barra;

        public ClsCliente(ClsBarra<ClsProducto> barra)
        {
            _barra = barra;
        }

        public ClsProducto Recoger()
        {
            Thread.Sleep(5000); // Simula el tiempo para recoger
            return _barra.Extraer();
        }
    }

}

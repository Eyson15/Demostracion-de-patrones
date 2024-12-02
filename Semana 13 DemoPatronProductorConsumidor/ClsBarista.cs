using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsBarista
    {
        private ClsBarra<ClsProducto> _barra;

        public ClsBarista(ClsBarra<ClsProducto> barra)
        {
            _barra = barra;
        }

        public void Preparar(ClsProducto producto)
        {
            _barra.Agregar(producto);
            Thread.Sleep(2000); // Simula el tiempo de preparación
        }
    }

}

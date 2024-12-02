using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsBarra<T>
    {
        private Queue<T> barra = new Queue<T>();
        private int capacidadMaxima;
        private object lockObjeto = new object();

        public ClsBarra(int capacidad)
        {
            capacidadMaxima = capacidad;
        }

        public void Agregar(T item)
        {
            lock (lockObjeto)
            {
                while (barra.Count >= capacidadMaxima)
                {
                    Monitor.Wait(lockObjeto);
                }
                barra.Enqueue(item);
                Monitor.Pulse(lockObjeto);
            }
        }

        public T Extraer()
        {
            lock (lockObjeto)
            {
                while (barra.Count == 0)
                {
                    Monitor.Wait(lockObjeto);
                }
                T item = barra.Dequeue();
                Monitor.Pulse(lockObjeto);
                return item;
            }
        }
    }
}

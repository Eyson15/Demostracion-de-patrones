namespace Semana_13_DemoPatronProductorConsumidor
{ // esto es para enviar y extraer cualquier elemento
    public class ClsCola<T> // <T> para colocar un elemento generico
    {
        private int capacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockObjeto = new object();

        public ClsCola(int capacidad)
        {
            capacidadMaxima = capacidad;
        }

        public void Agregar(T item)
        {
            lock (lockObjeto)
            {
                while (cola.Count >= capacidadMaxima)
                {
                    Monitor.Wait(lockObjeto);//wait espera
                }
                cola.Enqueue(item);
                Monitor.Pulse(lockObjeto);
            }
        }
        public T Extraer()
        {
            lock (lockObjeto)
            {
                while (cola.Count == 0)
                {
                    Monitor.Wait(lockObjeto);
                }
                T intem = cola.Dequeue();
                Monitor.Pulse(lockObjeto);
                return intem;
            }
            
        }
    }
}

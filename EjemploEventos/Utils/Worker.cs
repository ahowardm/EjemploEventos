using System;
namespace EjemploEventos.Utils
{
    public class Worker
    {
        // 1. Definir el delegate
        public delegate void WorkerStartedEventHandler(object source, EventArgs args);
        // 2. Definir el evento
        public event WorkerStartedEventHandler WorkerStarted;
        // 3. Lanzar el evento

        public event EventHandler<EventArgs> WorkerFinished;

        public Worker()
        {
        }

        public void Start() {
            OnWorkerStarted();
            Console.WriteLine("Partí trabajando");
        }

        public void Finish()
        {
            OnWorkerFinished();
        }

        // Si hay alguien suscrito, entonces lo gatilla/
        protected virtual void OnWorkerStarted()
        {
            if (WorkerStarted != null)
                WorkerStarted(this, EventArgs.Empty);
        }

        protected virtual void OnWorkerFinished()
        {
            if (WorkerFinished != null)
                WorkerFinished(this, EventArgs.Empty);
        }
    }
}

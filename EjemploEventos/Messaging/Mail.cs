using System;
namespace EjemploEventos.Messaging
{
    public class Mail
    {
        public Mail()
        {
        }

        public void OnWorkerStarted(object source, EventArgs args)
        {
            Console.WriteLine("MAIL: Worker Started");
        }

        public void OnWorkerFinished(object source, EventArgs args)
        {
            Console.WriteLine("MAIL: Worker Finished");
        }
    }
}

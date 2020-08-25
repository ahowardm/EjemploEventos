using System;
namespace EjemploEventos.Messaging
{
    public class SMS
    {
        public SMS()
        {
        }

        public void OnWorkerStarted(object source, EventArgs args)
        {
            Console.WriteLine("SMS: Worker Started");
        }

        public void OnWorkerFinished(object source, EventArgs args)
        {
            Console.WriteLine("SMS: Worker Finished");
        }
    }
}

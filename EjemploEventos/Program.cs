using System;
using System.Threading;
using EjemploEventos.Messaging;
using EjemploEventos.Utils;

namespace EjemploEventos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker();
            Mail mail = new Mail();
            SMS sms = new SMS();

            //worker.WorkerStarted += mail.OnWorkerStarted;
            //worker.WorkerStarted += sms.OnWorkerStarted;

            worker.WorkerFinished += sms.OnWorkerFinished;
            worker.WorkerFinished += mail.OnWorkerFinished;

            worker.Start();
            Thread.Sleep(3000);
            worker.Finish();
        }
    }
}

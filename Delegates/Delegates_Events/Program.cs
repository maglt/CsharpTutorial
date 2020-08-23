using System;
using System.Threading;

namespace Delegates_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kubas kub = new Kubas("finance"); // new instance if kubas class

            kub.KubasBaigeProcesint += MailService.KaiKubasSuprocesina; //add subscriber to event
            kub.KubasBaigeProcesint += ZinutesService.KaiKubasSuprocesina; //add another subscriber to event

            kub.Procesint();

            Console.ReadLine();
        }
    }
}

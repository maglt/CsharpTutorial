using System;
using System.Threading;


namespace Delegates_Events
{
    public class Kubas
    {

        //1- define a delagete
        //2- define an event based on that delegate
        //3- raise the event

        //1
        public delegate void KubasEventHandler(object source, EventArgs args);

        //2
        public event KubasEventHandler KubasBaigeProcesint;



        public string Pavadinimas { get; set; }

        public Kubas(string Pavadinimas)
        {
            this.Pavadinimas = Pavadinimas;
        }

        public void Procesint()
        {
            Console.WriteLine("loadina....");
            Thread.Sleep(3000);
            Console.WriteLine("Kubas Procesinas");
            Thread.Sleep(3000);
            OnProcessed(); //notify all the subscribers
        }


        public virtual void OnProcessed() //event publisher methodas
        {
            KubasBaigeProcesint?.Invoke(this, EventArgs.Empty); // check if there are any cubscibers if not null, pass current object with no additional data

        }
    }
}

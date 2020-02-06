using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverPattern
{
     class ConcreteSubject:MTV
    {
        bool MTVguncellendimi;

        public bool MTVguncellendi
        {
            get { return MTVguncellendimi; }
            set
            {
                if (value == true)
                {
                    Notify();
                    MTVguncellendimi = value;
                }
                else
                    MTVguncellendimi = value;
            }
        }
        List<Observer> Gozlemciler;
    public ConcreteSubject()
    {
        this.Gozlemciler = new List<Observer>();
    }
    
    public void Subscribe(Observer observer)
    {
        Gozlemciler.Add(observer);
    }
   
    public void AboneCikar(Observer observer)
    {
        Gozlemciler.Remove(observer);
    }
    
    public void Notify()
    {
        Gozlemciler.ForEach(g =>
        {
            g.Update();
        });
    }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163301060_Odev6
{

    /// <summary>
    /// Originator - Ayarlarımızın tutulduğu sınıfımız. 
    /// </summary>

    using System;
    using System.Collections.Generic;

    namespace ConsoleApplication18
    {
        public class Memento<T>
        {
            private readonly T _state;

            public Memento(T state)
            {
                _state = state;
            }

            public T State
            {
                get { return _state; }
            }
        }

        public class Originator<T>
        {
            public T State { get; set; }

            public Memento<T> SetState()
            {
                return new Memento<T>(State);
            }

            public void GetState(Memento<T> memento)
            {
                State = memento.State;
            }
        }

        public class CareTaker<T>
        {
            private readonly List<Memento<T>> _udemyList;

            public CareTaker()
            {
                _udemyList = new List<Memento<T>>();
            }

            public void Add(Memento<T> state)
            {
                _udemyList.Add(state);
            }

            public Memento<T> this[int index]
            {
                get { return _udemyList[index]; }
            }
        }

        public class Udemy
        {
            public string DersNo { get; set; }
            public string DersAdi { get; set; }

            public override string ToString()
            {
                return string.Format("{0} :{1}", DersNo, DersAdi);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var originator = new Originator<Udemy>();
                var careTaker = new CareTaker<Udemy>();

                originator.State = new Udemy
                {
                    DersNo = "01",
                    DersAdi = "Gerekli Kurulumlar"
                };

                careTaker.Add(originator.SetState());

                originator.State = new Udemy
                {
                    DersNo = "29",
                    DersAdi = "Çember Tespiti"
                };

                careTaker.Add(originator.SetState());

                originator.GetState(careTaker[0]);

                Console.WriteLine(originator.State);

            }
        }
    
}
}


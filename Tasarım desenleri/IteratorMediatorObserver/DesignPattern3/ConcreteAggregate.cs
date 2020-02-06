using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern3
{
    struct Entegreler
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Gorev { get; set; }
    }
    class EntegreAggregate : IAggregate
    {
        List<Entegreler> EntegreListesi = new List<Entegreler>();
        public void Add(Entegreler Model) => EntegreListesi.Add(Model);
        public Entegreler GetItem(int index) => EntegreListesi[index];
        public int Count { get => EntegreListesi.Count; }
        public IIterator CreateIterator() => new EntegreIterator(this);
    }
}

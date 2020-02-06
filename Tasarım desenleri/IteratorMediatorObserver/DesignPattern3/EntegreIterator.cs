using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern3
{
    class EntegreIterator : IIterator
    {
        EntegreAggregate aggregate;
        int currentindex;
        public EntegreIterator(EntegreAggregate aggregate) => this.aggregate = aggregate;
        public Entegreler CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public Entegreler NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return new Entegreler();
        }
    }
}

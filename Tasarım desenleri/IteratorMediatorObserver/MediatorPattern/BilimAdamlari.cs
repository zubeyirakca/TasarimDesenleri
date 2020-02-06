using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class BilimAdamlari : IDrLouiseBanks
    {
        private List<Uzayli> _MesajListe = new List<Uzayli>();
        public void MesajKayit(Uzayli _mesaj)
        {
            _MesajListe.Add(_mesaj);
            _mesaj.Arabulucu = this;
        }
        public void GorusIzniCevap(string MesajNo)
        {
            bool izin = true;
            if (_MesajListe.Where(u => u.MesajIzni == true).Count() > 0)
                izin = false;
            _MesajListe.Where(u => u.GorusmeNo == MesajNo).Single().SetGorusIzni(izin);
        }
    }
}

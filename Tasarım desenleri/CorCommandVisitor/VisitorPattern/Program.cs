using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface IFifaVisitor
    {
        void Visit(Fifa94 game);
        void Visit(Fifa20 game);
    }

    class EfektliSut : IFifaVisitor
    {
        public void Visit(Fifa94 tel)
        {
            Console.WriteLine("Fifa94'te şut efekti bulunmakta.");
        }

        public void Visit(Fifa20 tel)
        {
            Console.WriteLine("Fifa20 de şut çektikten sonra efekt gözükmemektedir");
        }
    }

    class OnlineMod : IFifaVisitor
    {
        public void Visit(Fifa94 tel)
        {
            Console.WriteLine("Fifa94'te online bir şekilde maç yapılamaz");
        }

        public void Visit(Fifa20 tel)
        {
            Console.WriteLine("Fifa20 de online mod mevcuttur");
        }
    }


    interface IFifa
    {
        void Mac(string No);
        void ModuKullan(IFifaVisitor t);
    }


    class Fifa94 : IFifa
    {
        public void Mac(string No)
        {
            Console.WriteLine("Fifa94 " + No + " modu bulunuyor...");
        }


        public void ModuKullan(IFifaVisitor t)
        {
            t.Visit(this);
        }
    }

    class Fifa20 : IFifa
    {
        public void Mac(string Mod)
        {
            Console.WriteLine("Fifa20 " + Mod + " modu bulunuyor...");
        }

        public void ModuKullan(IFifaVisitor t)
        {
            t.Visit(this);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            IFifa Fifa94oyunu = new Fifa94();
            IFifa Fifa20oyunu = new Fifa20();

            Fifa94oyunu.Mac("Turnuva");
            Fifa20oyunu.Mac("Turnuva");


            IFifaVisitor EfektliSutKullan = new EfektliSut();
            Fifa94oyunu.ModuKullan(EfektliSutKullan);
            Fifa20oyunu.ModuKullan(EfektliSutKullan);


            IFifaVisitor OnlineModKullan = new OnlineMod();

            Fifa94oyunu.ModuKullan(OnlineModKullan);
            Fifa20oyunu.ModuKullan(OnlineModKullan);

            Console.ReadKey();
        }
    }
}


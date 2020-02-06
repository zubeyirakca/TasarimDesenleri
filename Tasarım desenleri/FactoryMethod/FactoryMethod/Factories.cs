using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public enum Yakitlar
    { Benzin, Dizel, LPG } //seçeneklerimizi girdik

    public abstract class Product // ana sınıfımızı oluşturduk
    { public abstract void Sec();}

    public class ConcreteProduct1 : Product // ana sınıfın bir benzerini oluşturduk.
    { public override void Sec()
        { Console.WriteLine("Bu araç benzinlidir."); } }

    public class ConcreteProduct2 : Product // ana sınıfın bir benzerini oluşturduk.
    { public override void Sec()
        { Console.WriteLine("Bu araç dizeldir."); } }


    public class ConcreteProduct3 : Product // ana sınıfın bir benzerini oluşturduk.
    { public override void Sec()
        { Console.WriteLine("Bu araç LPG'lidir."); } }


                public class Creator     {
                    public Product FactoryMethod(Yakitlar yakit) // yakit nesnesini oluşturduk.
                {
                    Product product = null;
                    switch (yakit)
            { 
                                case Yakitlar.Benzin:                     
                                product = new ConcreteProduct1(); 
                                break;
                                case Yakitlar.Dizel:
                                product = new ConcreteProduct2();
                                break;
                                case Yakitlar.LPG:                     
                                product = new ConcreteProduct3();
                                break;
                            default: break;
                        }
                        return product;
                    }
                }
              
        }


using System;

namespace chain_of_res_sample
{
    public abstract class ErkekKuaforu
    {
        protected ErkekKuaforu _SonrakiHandler;
        public ErkekKuaforu SonrakiHandler { set { _SonrakiHandler = value; } }

        public abstract void Tras(string filePath);
    }

    public class KuaforAli : ErkekKuaforu
    {
        public override void Tras(string filePath)
        {
            
            if (filePath.StartsWith("İlk"))
                Console.WriteLine("{0} traş için koltuğa oturdu", filePath);
            else
            {
             
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Tras(filePath);
            }
        }
    }

    public class KuaforIsmet : ErkekKuaforu
    {
        public override void Tras(string filePath)
        {
         
            if (filePath.StartsWith("İkinci"))
                Console.WriteLine("{0} traş için koltuğa oturdu", filePath);
            else
            {
              
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Tras(filePath);
            }
        }
    }

    public class KuaforEyup : ErkekKuaforu
    {
        public override void Tras(string filePath)
        {
      
            if (filePath.StartsWith("Üçüncü"))
                Console.WriteLine("{0} traş için koltuğa oturdu", filePath);
            else 
                Console.WriteLine("{0} için boş kuaför kalmadı", filePath);

        }
    }
}
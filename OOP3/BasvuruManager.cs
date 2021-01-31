using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Başvuru bilgilerini değerlendirme 
            // 

            krediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_Uygulaması
{
    public class Ogrenci
    {
        private int ogrNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Ogrenci(int _ogrNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrNo = _ogrNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }

        public void ogrenciBilgileri()
        {
            Console.WriteLine("Öğrenci Numarası : " + ogrNo);
            Console.WriteLine("Öğrenci İsmi : " + isim);
            Console.WriteLine("Öğrenci Soyismi : " + soyisim);
            Console.WriteLine("Öğrenci Vize 1 : " + vize1);
            Console.WriteLine("Öğrenci Vize 2 : " + vize2);
            Console.WriteLine("Öğrenci Final : " + final);
            Console.WriteLine("Öğrenci Okul İsmi : " + okulismi);
        }

        public double ogrenciNotu()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okulu : " + okulismi);
        }
    }
}

using System;

 namespace siniflar{

    class Program{

        static void Main(string [] args){
            Console.WriteLine("merhaba");
            Calisan calisan1= new Calisan();
            calisan1.Ad="aysa";
            calisan1.Soyad="kara";
            calisan1.No= 23542568;
            calisan1.Departman="insan kaynaklari";

            calisan1.CalisanBilgileri();

            Calisan calisan2= new Calisan();
            calisan2.Ad="adı";
            calisan2.Soyad="soyadi";
            calisan2.No=15648951;
            calisan2.Departman="Bilgi islem";
            calisan2.CalisanBilgileri();


        }
    }

    class Calisan{

        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri(){
           
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Soyadi {0}", Soyad);
            Console.WriteLine("Calisan numarasi: {0}", No);
            Console.WriteLine("Calisan Departmani {0}", Departman);
            
        }
    }
 }
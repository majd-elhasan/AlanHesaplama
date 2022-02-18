using System;
namespace AlanHesaplama
{
    public static class Yamuk{
        public static void function()
        {
            double AltTaban = 0;
            double UstTaban = 0;
            double Yukseklik = 0;
            double OrtaTaban = 0;
            double Alan = 0;

            string Alan_s = "";
            string Yukseklik_s = "";

            MainClass.Property_ls = new (){"Alt Taban, üst Taban ve yükseklik","Orta taban ve yükseklik"};
            
            
            MainClass.TryInput_property();
            
            switch(MainClass.input)
            {
                case 1:
                    Console.WriteLine("yamuğun üst taban uzunluğunu giriniz.");
                    UstTaban = MainClass.doubleConverter();
                    Console.WriteLine("yamuğun alt taban uzunluğunu giriniz.");
                    AltTaban = MainClass.doubleConverter();
                    Console.WriteLine("yamuğun yüksekliğini giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;

                case 2:
                    Console.WriteLine("yamuğun orta taban uzunluğunu giriniz.");
                    OrtaTaban = MainClass.doubleConverter();
                    Console.WriteLine("yamuğun yüksekliğini giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan},{"Yükseklik",Yukseklik}};
            MainClass.TryInput_ToCalculate();

            if (UstTaban > 0 && AltTaban > 0 && Yukseklik > 0){
                Alan = (UstTaban + AltTaban) * Yukseklik / 2 ;
            }
            if (OrtaTaban > 0 && Yukseklik > 0){
                Alan = OrtaTaban * Yukseklik;
            }
            Yukseklik_s = MainClass.GetRidOfZeros(Yukseklik);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            switch(MainClass.input)
            {
                case 1:
                    Console.Write("Yükseklik  :  ");
                    Console.WriteLine(Yukseklik_s); 
                break;

                case 2:
                    Console.Write("Alan  :  ");
                    Console.WriteLine(Alan_s);    
                break;
            }
        }
    }
}
using System;
namespace AlanHesaplama
{
    public static class Daire{
        public static void function()
        {
            double Yaricap = 0;
            double Alan = 0;
            double Cevre = 0;

            string Yaricap_s = "";
            string Alan_s = "";
            string Cevre_s = "";

            MainClass.Property_ls = new (){"Yarıçap", "Alan", "Çevre"};
            
            
            MainClass.TryInput_property();
            
            switch(MainClass.input)
            {
                case 1:
                    Console.WriteLine("Daire'nin yarıçapını giriniz.");
                    Yaricap = MainClass.doubleConverter();
                break;

                case 2:
                    Console.WriteLine("Daire'nin alanını giriniz.");
                    Alan = MainClass.doubleConverter();
                break;

                case 3:
                    Console.WriteLine("Daire'nin çevresini giriniz.");
                    Cevre = MainClass.doubleConverter();
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Yarıçap",Yaricap}, {"Alan",Alan}, {"Çevre",Cevre}};
            MainClass.TryInput_ToCalculate();
            if(Yaricap > 0 ){                  
                Alan = Math.PI*Yaricap*Yaricap;    // Alan'ın hesaplanması
                Cevre = 2*Math.PI*Yaricap;         // Çevre'nin hesaplanması
                }
            else if (Cevre > 0){
                Yaricap = Cevre/(2*Math.PI);              // Yarıçap'ın hesaplanması
                Alan = Math.PI*Yaricap*Yaricap;    // Alan'ın hesaplanması
            }
            else if (Alan > 0){
                Yaricap =  Math.Sqrt( Alan/Math.PI );     // Yarıçap'ın hesaplanması
                Cevre = 2*Math.PI*Yaricap;        // Çevre'nin hesaplanması
            }

            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            Cevre_s = MainClass.GetRidOfZeros(Cevre);

            switch(MainClass.input)
            {
                case 1:
                    Console.Write("Yarıçap  :  ");
                    Console.WriteLine(Yaricap); 
                break;

                case 2:
                    Console.Write("Alan  :  ");
                    Console.WriteLine(Alan);    
                break;

                case 3:
                    Console.Write("Çevre  :  ");
                    Console.WriteLine(Cevre); 
                break;
            }

        }
    }
}
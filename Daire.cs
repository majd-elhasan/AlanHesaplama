using System;
namespace AlanHesaplama
{
    public static class Daire{
        public static List<double> Result_ls= new List<double>();
        public static double Yaricap = 0;
        public static double Alan = 0;
        public static double Cevre = 0;
        public static void Quick_function()
        {
            MainClass.Property_ls = new (){"Yarıçap", "Alan", "Çevre"};
            
            MainClass.TryInput_property();
            MainClass.set_KeyName = MainClass.Property_ls[MainClass.input-1];
            
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
            Result_ls = new List<double>(){Alan,Cevre};

        }

        public static void function()
        {
            Quick_function();
            
            string Yaricap_s = "";
            string Alan_s = "";
            string Cevre_s = "";

            MainClass.ToCalculate_ls = new (){{"Yarıçap",Yaricap}, {"Alan",Alan}, {"Çevre",Cevre}};
            MainClass.TryInput_ToCalculate();
            
            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            Cevre_s = MainClass.GetRidOfZeros(Cevre);

            switch(MainClass.input)
            {
                case 1:
                    Console.Write("Yarıçap  :  ");
                    Console.WriteLine(Yaricap_s); 
                break;

                case 2:
                    Console.Write("Alan  :  ");
                    Console.WriteLine(Alan_s);    
                break;

                case 3:
                    Console.Write("Çevre  :  ");
                    Console.WriteLine(Cevre_s); 
                break;
            }

        }
    }
}
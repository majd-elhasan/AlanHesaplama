using System;
namespace AlanHesaplama
{
    public static class Kare {
        public static List<double> Result_ls= new List<double>(){};
        public static double Kenar = 0;
        public static double Alan = 0;
        public static double Cevre = 0;
        public static double Kosegen = 0;
        public static void Quick_function(){

            MainClass.Property_ls = new List<string>(){"Kenar","Köşegen","Alan","Çevre"};

            MainClass.TryInput_property();

            MainClass.set_KeyName = MainClass.Property_ls[MainClass.input-1];
            
            
            switch(MainClass.input)
            {
                case 1:
                    Console.WriteLine("Kenar uzunluğunu giriniz.");
                    Kenar = MainClass.doubleConverter();
                break;

                case 2:
                    Console.WriteLine("Köşegen uzunluğunu giriniz.");
                    Kosegen = MainClass.doubleConverter();
                break;

                case 3:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                break;

                case 4:
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                break;
            }

            if (Kenar > 0){
                Alan = Kenar*Kenar;
                Cevre = 4* Kenar;
                Kosegen = Kenar * Math.Sqrt(2);
            }
            else if (Kosegen > 0){
                Kenar = Kosegen/Math.Sqrt(2);
                Alan = Kenar*Kenar;
                Cevre = 4* Kenar;
            }
            else if (Alan > 0){
                Kenar = Math.Sqrt(Alan);
                Kosegen = Kenar * Math.Sqrt(2);
                Cevre = 4* Kenar;
            }
            else if (Cevre > 0){
                Kenar = Cevre/4;
                Kosegen = Kenar * Math.Sqrt(2);
                Alan = Kenar*Kenar;
            }
            Result_ls= new List<double>(){Alan,Cevre};
        }
        public static void function()
        {
            Quick_function();
            
            string Kenar_s = "";
            string Alan_s = "";
            string Cevre_s = "";
            string Kosegen_s = "";

            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"Kenar",Kenar}, {"Köşegen",Kosegen}};
            MainClass.TryInput_ToCalculate();
           
            Kenar_s = MainClass.GetRidOfZeros(Kenar);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            Cevre_s = MainClass.GetRidOfZeros(Cevre);
            Kosegen_s = MainClass.GetRidOfZeros(Kosegen);

            switch(MainClass.input)
            {
                case 1:
                    Console.Write("Alan  :  ");
                    Console.WriteLine(Alan_s);    
                break;

                case 2:
                    Console.Write("Çevre  :  ");
                    Console.WriteLine(Cevre_s); 
                break;

                case 3:
                    Console.Write("Kenar  :  ");
                    Console.WriteLine(Kenar_s);    
                break;

                case 4:
                    Console.Write("Köşegen  :  ");
                    Console.WriteLine(Kosegen_s); 
                break;
            }
            
        }
    }
}
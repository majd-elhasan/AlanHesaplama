using System;
namespace AlanHesaplama
{
    public static class Besgen{
        public static List<double> Result_ls= new List<double>();
        public static double Yaricap = 0;
        public static double Kenar = 0;
        public static double Yukseklik = 0;
        public static double Kosegen = 0;
        public static double Cevre = 0;
        public static double Alan = 0;
        public static void  Quick_function()
        {
            MainClass.Property_ls = new List<string>(){"Kenar","Köşegen","Yükseklik (iç yarıçap)","Yarıçap","Alan"};
            MainClass.TryInput_property();

            MainClass.set_KeyName = MainClass.Property_ls[MainClass.input-1];
            

            switch (MainClass.input)
            {
                case 1 :
                    Console.WriteLine("Beşgenin kenar uzunluğunu giriniz.");
                    Kenar = MainClass.doubleConverter();
                break;

                case 2 :
                    Console.WriteLine("Beşgenin köşegen uzunluğunu giriniz.");
                    Kosegen = MainClass.doubleConverter();
                break;

                case 3 :
                    Console.WriteLine("Beşgenin yüksekliğini giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;
                case 4 :
                    Console.WriteLine("Beşgenin Yarıçapını giriniz.");
                    Yaricap = MainClass.doubleConverter();
                break;
                case 5 :
                    Console.WriteLine("Beşgenin alanını giriniz.");
                    Alan = MainClass.doubleConverter();
                break;
            }
             if(Yaricap > 0){
                Kenar = Yaricap * (2 * Math.Sin((2/5)*Math.PI));
                Alan = 5* Kenar* Kenar /(4 * Math.Tan((2/5)*Math.PI));
                Cevre = 5*Kenar;
                Kosegen = Math.Sin(3 * Math.PI /10)*2*Kenar;
                Yukseklik = (2*Alan) / Cevre;
                
            }
            else if(Kenar > 0){
                Alan = 5* Kenar* Kenar /(4 * Math.Tan((2/5)*Math.PI));
                Cevre = 5*Kenar;
                Kosegen = Math.Sin(3 * Math.PI /10)*2*Kenar;
                Yukseklik = (2*Alan) / Cevre;
                Yaricap = Kenar/(2 * Math.Sin((2/5)*Math.PI));
            }
            else  if(Kosegen > 0){
                Kenar = Kosegen /(Math.Sin(3 * Math.PI /10)*2);
                Cevre = 5*Kenar;
                Alan = 5* Kenar* Kenar /(4 * Math.Tan((2/5)*Math.PI));        //Alan = Kenar * Yukseklik * (5/2);
                Yukseklik = (2*Alan) / Cevre;
                Yaricap = Kenar/(2 * Math.Sin((2/5)*Math.PI));
            }
            else if (Alan > 0){
                Kenar =  Math.Sqrt((Alan* 4 * Math.Tan((2/5)*Math.PI))/5);
                Cevre = 5*Kenar;
                Kosegen =  Math.Sin(3 * Math.PI /10)*2*Kenar;
                Yukseklik = (2*Alan) / Cevre;
                Yaricap = Kenar/(2 * Math.Sin((2/5)*Math.PI));
            }
            else if (Cevre > 0){
                Kenar = Cevre /5;
                Kosegen =  Math.Sin(3 * Math.PI /10)*2*Kenar;
                Alan = 5* Kenar* Kenar /(4 * Math.Tan((2/5)*Math.PI));
                Yukseklik = (2*Alan) / Cevre;
                Yaricap = Kenar/(2 * Math.Sin((2/5)*Math.PI));
            }
            Result_ls = new List<double>(){Alan,Cevre};
        }
        public static void function()
        {
            Quick_function();
            string Yaricap_s ="";
            string Kenar_s="";
            string Yukseklik_s ="";
            string Kosegen_s = "";
            string Cevre_s = "";
            string Alan_s = "";
            
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"Kenar",Kenar},{"Köşegen",Kosegen},
            {"Yükseklik (iç yarıçap)",Yukseklik},{"Yarıçap",Yaricap}};
            MainClass.TryInput_ToCalculate();

           
            Kenar_s = MainClass.GetRidOfZeros(Kenar);
            Yukseklik_s = MainClass.GetRidOfZeros(Yukseklik);
            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Kosegen_s = MainClass.GetRidOfZeros(Kosegen);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            Cevre_s = MainClass.GetRidOfZeros(Cevre);

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
                case 5:
                    Console.Write("Yükseklik (iç yarıçap)  :  ");
                    Console.WriteLine(Yukseklik_s); 
                break;
                case 6:
                    Console.Write("Yarıçap  :  ");
                    Console.WriteLine(Yaricap_s); 
                break;
            }
        }
    }
}
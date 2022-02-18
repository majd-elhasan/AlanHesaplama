using System;
namespace AlanHesaplama{
    public static class Yedigen{
        public static List<double> function()
        {
            double Yaricap = 0;
            double Kenar = 0;
            double Yukseklik = 0;
            double Kisa_Kosegen = 0;  
            double Uzun_Kosegen = 0;  
            double Cevre = 0;
            double Alan = 0;

            string Yaricap_s ="";
            string Yukseklik_s ="";
            string Kenar_s="";
            string Kisa_Kosegen_s = "";
            string Uzun_Kosegen_s = "";
            string Cevre_s = "";
            string Alan_s = "";

            MainClass.Property_ls = new List<string>(){"Kenar","Kısa köşegen","Uzun köşegen","Yükseklik (iç yarıçap)","Yarıçap","Alan"};
            MainClass.TryInput_property();

            switch (MainClass.input)
            {
                case 1 :
                    Console.WriteLine("Yedigenin kenar uzunluğunu giriniz.");
                    Kenar = MainClass.doubleConverter();
                break;

                case 2 :
                    Console.WriteLine("Yedigenin Kısa köşegen uzunluğunu giriniz.");
                    Kisa_Kosegen = MainClass.doubleConverter();
                break;

                case 3 :
                    Console.WriteLine("Yedigenin Uzun köşegen uzunluğunu giriniz.");
                    Uzun_Kosegen = MainClass.doubleConverter();
                break;

                case 4 :
                    Console.WriteLine("Yedigenin yüksekliğini (iç yarıçapını) giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;
                case 5 :
                    Console.WriteLine("Yedigenin Yarıçapını giriniz.");
                    Yaricap = MainClass.doubleConverter();
                break;
                case 6 :
                    Console.WriteLine("Yedigenin alanını giriniz.");
                    Alan = MainClass.doubleConverter();
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"Kenar",Kenar},{"Kısa köşegen",Kisa_Kosegen},{"Uzun köşegen",Uzun_Kosegen},
            {"Yükseklik (iç yarıçap)",Yukseklik},{"Yarıçap",Yaricap}};
            MainClass.TryInput_ToCalculate();
            if (Kenar > 0){
                Yukseklik = Kenar *  Math.Tan(5 *Math.PI /14) /2;
                Kisa_Kosegen = 2* Kenar *Math.Sin(5 *Math.PI /14);  
                Uzun_Kosegen = 2*Math.Sin(5 *Math.PI /7)*Kenar + Kenar;
                Cevre = 7*Kenar;
                Yaricap = Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);
                Alan =7 * Kenar * Kenar *  Math.Tan(5 *Math.PI /14) /4;
                
                    // 7* Yukseklik*Yukseklik / Math.Tan(5 *Math.PI /14);
                    // alan = kenar sayısı(n) * yukseklik * kenar /2
            }
            else if (Alan > 0){
                Kenar = Math.Sqrt(4* Alan/(7*Math.Tan(5 *Math.PI /14)));
                Kisa_Kosegen = 2* Kenar *Math.Sin(5 *Math.PI /14);  
                Uzun_Kosegen =2*Math.Sin(5 *Math.PI /7)*Kenar + Kenar;
                Yukseklik =  Kenar *  Math.Tan(5 *Math.PI /14) /2;     // Kenar/(2* Math.Tan(Math.PI /6));
                Cevre = 7*Kenar;
                Yaricap = Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);
            }
            else if (Yaricap > 0){
                Alan = (5/2)* Yaricap*Yaricap * Math.Sin((2/5)*Math.PI);
                Kenar = 2* Math.Sqrt(Yaricap*Yaricap - Yukseklik * Yukseklik);
                Kisa_Kosegen =  2* Kenar *Math.Sin(5 *Math.PI /14);
                Uzun_Kosegen =2*Math.Sin(5 *Math.PI /7)*Kenar + Kenar;
                Yukseklik =  Kenar *  Math.Tan(5 *Math.PI /14) /2;
                Cevre = 7*Kenar;
            }
            else if (Kisa_Kosegen>0){
                Kenar = Kisa_Kosegen/(2 *Math.Sin(5 *Math.PI /14));
                Alan =7 * Kenar * Kenar *  Math.Tan(5 *Math.PI /14) /4;
                Uzun_Kosegen = 2*Math.Sin(5 *Math.PI /7)*Kenar + Kenar;
                Yukseklik = Kenar *  Math.Tan(5 *Math.PI /14) /2;
                Cevre = 7*Kenar;
                Yaricap = Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);
            }
            else if(Uzun_Kosegen > 0){
                Kenar = Uzun_Kosegen / (2*Math.Sin(5 *Math.PI /14)+1);
                Alan = 7 * Kenar * Kenar *  Math.Tan(5 *Math.PI /14) /4;
                Kisa_Kosegen = 2* Kenar *Math.Sin(5 *Math.PI /14);
                Yukseklik =  Kenar *  Math.Tan(5 *Math.PI /14) /2;
                Cevre = 7*Kenar;
                Yaricap = Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);
            }
            else if (Yukseklik > 0){
                Kenar = 2* Yukseklik / Math.Tan(5 *Math.PI /14); // yukseklik / (kenar/2) = tan(theta/2) ;        theta = 5*180/7
                Alan =7* Yukseklik*Yukseklik / Math.Tan(5 *Math.PI /14);
                Kisa_Kosegen = 2* Kenar *Math.Sin(5 *Math.PI /14);       // sin(th/2) = kisa_k /(2*Kenar)
                Uzun_Kosegen = 2*Math.Sin(5 *Math.PI /7)*Kenar + Kenar;
                Cevre = 7*Kenar;
                Yaricap = Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);
            }
            Kenar_s = MainClass.GetRidOfZeros(Kenar);
            Yukseklik_s = MainClass.GetRidOfZeros(Yukseklik);
            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Kisa_Kosegen_s =MainClass.GetRidOfZeros(Kisa_Kosegen);
            Uzun_Kosegen_s = MainClass.GetRidOfZeros(Uzun_Kosegen);
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
                    Console.Write("Kısa Köşegen  :  ");
                    Console.WriteLine(Kisa_Kosegen_s); 
                break;
                case 5:
                    Console.Write("Uzun Köşegen  :  ");
                    Console.WriteLine(Uzun_Kosegen_s); 
                break;
                case 6:
                    Console.Write("Yükseklik (iç yarıçap)  :  ");
                    Console.WriteLine(Yukseklik_s); 
                break;
                case 7:
                    Console.Write("Yarıçap  :  ");
                    Console.WriteLine(Yaricap_s); 
                break;
            }
            List<double> Result_ls= new List<double>(){Alan,Cevre};
            return Result_ls;

        }
    }
}
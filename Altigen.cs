using System;
namespace AlanHesaplama{
    public static class Altigen{
        public static List<double> function()
        {
            double Yaricap = 0;
            double Kenar = 0;
            double Yukseklik = 0;
            double Kisa_Kosegen = 0;  // Kenar * Math.sqrt(3);
            double Uzun_Kosegen = 0;  // 2 * Kenar
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
                    Console.WriteLine("Altıgenin kenar uzunluğunu giriniz.");
                    Kenar = MainClass.doubleConverter();
                break;

                case 2 :
                    Console.WriteLine("Altıgenin Kısa köşegen uzunluğunu giriniz.");
                    Kisa_Kosegen = MainClass.doubleConverter();
                break;

                case 3 :
                    Console.WriteLine("Altıgenin Uzun köşegen uzunluğunu giriniz.");
                    Uzun_Kosegen = MainClass.doubleConverter();
                break;

                case 4 :
                    Console.WriteLine("Altıgenin yüksekliğini (iç yarıçapını) giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;
                case 5 :
                    Console.WriteLine("Altıgenin Yarıçapını giriniz.");
                    Yaricap = MainClass.doubleConverter();
                break;
                case 6 :
                    Console.WriteLine("Altıgenin alanını giriniz.");
                    Alan = MainClass.doubleConverter();
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"Kenar",Kenar},{"Kısa köşegen",Kisa_Kosegen},{"Uzun köşegen",Uzun_Kosegen},
            {"Yükseklik (iç yarıçap)",Yukseklik},{"Yarıçap",Yaricap}};
            MainClass.TryInput_ToCalculate();
            if (Kenar > 0){
                Alan =( 3 *Math.Sqrt(3)/2) *Kenar * Kenar;
                Kisa_Kosegen = Kenar * Math.Sqrt(3);
                Uzun_Kosegen = 2 * Kenar;
                Yukseklik =  Kenar * Math.Sqrt(3)/2; 
                Cevre = 6*Kenar;
                Yaricap = Kenar;
            }
            else if (Alan > 0){
                Kenar = Math.Sqrt(Alan/( 3 *Math.Sqrt(3)/2));
                Kisa_Kosegen = Kenar * Math.Sqrt(3);
                Uzun_Kosegen = 2 * Kenar;
                Yukseklik = Kenar * Math.Sqrt(3)/2;           // Kenar/(2* Math.Tan(Math.PI /6));
                Cevre = 6*Kenar;
                Yaricap = Kenar;  // Math.Sqrt(Kenar*Kenar/4+Yukseklik*Yukseklik);

            }
            else if (Yaricap > 0){
                Kenar =Yaricap;
                Alan =( 3 *Math.Sqrt(3)/2) *Kenar * Kenar;
                Kisa_Kosegen = Kenar * Math.Sqrt(3);
                Uzun_Kosegen = 2 * Kenar;
                Yukseklik = Kenar * Math.Sqrt(3)/2; 
                Cevre = 6*Kenar;
            }
            else if (Kisa_Kosegen>0){
                Kenar = Kisa_Kosegen / Math.Sqrt(3);
                Alan =( 3 *Math.Sqrt(3)/2) *Kenar * Kenar;
                Uzun_Kosegen = 2 * Kenar;
                Yukseklik = Kenar * Math.Sqrt(3)/2; 
                Cevre = 6*Kenar;
                Yaricap = Kenar;
            }
            else if(Uzun_Kosegen > 0){
                Kenar = Uzun_Kosegen /2;
                Alan = (3 * Math.Sqrt(3)/2) * Kenar * Kenar;
                Kisa_Kosegen = Kenar * Math.Sqrt(3);
                Yukseklik =  Kenar * Math.Sqrt(3)/2;  
                Cevre = 6*Kenar;
                Yaricap = Kenar;
            }
            else if (Yukseklik > 0){
                Kenar = 2 * Yukseklik / Math.Sqrt(3);
                Alan =( 3 *Math.Sqrt(3)/2) *Kenar * Kenar;
                Kisa_Kosegen = Kenar * Math.Sqrt(3);
                Uzun_Kosegen = 2 * Kenar;
                Cevre = 6*Kenar;
                Yaricap = Kenar;
            }
            Kenar_s = MainClass.GetRidOfZeros(Kenar);
            Yukseklik_s = MainClass.GetRidOfZeros(Yukseklik);
            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Kisa_Kosegen_s = MainClass.GetRidOfZeros(Kisa_Kosegen);
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
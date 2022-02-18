using System;
namespace AlanHesaplama{
    public static class Sekizgen{
        public static List<double> function()
        {
            double Yaricap = 0;
            double Kenar = 0;
            double Yukseklik = 0;
            double Uzun_Kosegen = 0;
            double Cevre = 0;
            double Alan = 0;

            string Yaricap_s ="";
            string Yukseklik_s ="";
            string Kenar_s="";
            string Uzun_Kosegen_s = "";
            string Cevre_s = "";
            string Alan_s = "";

            MainClass.Property_ls = new List<string>(){"Kenar","Uzun köşegen","Yükseklik (iç yarıçap)","Yarıçap","Alan"};
            MainClass.TryInput_property();

            switch (MainClass.input)
            {
                case 1 :
                    Console.WriteLine("Yedigenin kenar uzunluğunu giriniz.");
                    Kenar = MainClass.doubleConverter();
                break;

                case 2 :
                    Console.WriteLine("Yedigenin Uzun köşegen uzunluğunu giriniz.");
                    Uzun_Kosegen = MainClass.doubleConverter();
                break;

                case 3 :
                    Console.WriteLine("Yedigenin yüksekliğini (iç yarıçapını) giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;
                case 4 :
                    Console.WriteLine("Yedigenin Yarıçapını giriniz.");
                    Yaricap = MainClass.doubleConverter();
                break;
                case 5 :
                    Console.WriteLine("Yedigenin alanını giriniz.");
                    Alan = MainClass.doubleConverter();
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"Kenar",Kenar},{"Uzun köşegen",Uzun_Kosegen},
            {"Yükseklik (iç yarıçap)",Yukseklik},{"Yarıçap",Yaricap}};
            MainClass.TryInput_ToCalculate();
            if (Kenar > 0){
               
                Alan = 2*(1+Math.Sqrt(2))*Kenar*Kenar;
                Cevre = 8*Kenar;
                Yaricap = Kenar * Math.Sin(3*Math.PI /8) * Math.Sqrt(2);
                Uzun_Kosegen = 2*Yaricap;
                Yukseklik = Kenar * Math.Sqrt((2*Math.Sin(3*Math.PI/8)*Math.Sin(3*Math.PI/8)-1/4)); // sqrt(r²-(Kenar/2)²)
            }
            else if (Alan > 0){
                Kenar = Math.Sqrt(Alan/2*(1+Math.Sqrt(2)));
                Cevre = 8*Kenar;
                Yaricap = Kenar * Math.Sin(3*Math.PI /8) * Math.Sqrt(2);
                Uzun_Kosegen = 2*Yaricap;
                Yukseklik = Kenar * Math.Sqrt((2*Math.Sin(3*Math.PI/8)*Math.Sin(3*Math.PI/8)-1/4));
            }
            else if (Yaricap > 0){
                Kenar = Yaricap/(Math.Sin(3*Math.PI /8) * Math.Sqrt(2));
                Alan = 2*(1+Math.Sqrt(2))*Kenar*Kenar;
                Cevre = 8*Kenar;
                Uzun_Kosegen = 2*Yaricap;
                Yukseklik = Kenar * Math.Sqrt((2*Math.Sin(3*Math.PI/8)*Math.Sin(3*Math.PI/8)-1/4));
            }
            else if(Uzun_Kosegen > 0){
                Yaricap = Uzun_Kosegen/2;
                Kenar = Yaricap/(Math.Sin(3*Math.PI /8) * Math.Sqrt(2));
                Alan = 2*(1+Math.Sqrt(2))*Kenar*Kenar;
                Cevre = 8*Kenar;
                Yukseklik = Kenar * Math.Sqrt((2*Math.Sin(3*Math.PI/8)*Math.Sin(3*Math.PI/8)-1/4));
            }
            else if (Yukseklik > 0){
                Kenar = Yukseklik /(Math.Sqrt((2*Math.Sin(3*Math.PI/8)*Math.Sin(3*Math.PI/8)-1/4)));
            }
            Kenar_s =MainClass. GetRidOfZeros(Kenar);
            Yukseklik_s = MainClass.GetRidOfZeros(Yukseklik);
            Yaricap_s = MainClass.GetRidOfZeros(Yaricap);
            Uzun_Kosegen_s = MainClass.GetRidOfZeros(Uzun_Kosegen);
            Alan_s =MainClass. GetRidOfZeros(Alan);
            Cevre_s =MainClass. GetRidOfZeros(Cevre);

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
                    Console.Write("Uzun Köşegen  :  ");
                    Console.WriteLine(Uzun_Kosegen_s); 
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
            List<double> Result_ls= new List<double>(){Alan,Cevre};
            return Result_ls;
        }
    }
}
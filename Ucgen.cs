using System;
namespace AlanHesaplama
{
    public static class Ucgen
    {
        public static List<double> function()
        {
            
            double Taban = 0;
            double Yukseklik = 0;
            double A = 0;   // büyük harf ile gösterilen açı , küçük harfle gösterilen ise kenar uzunluğudur.
            double B = 0;
            double C = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double Cevre = 0;
            double Alan = 0;


            string Alan_s = "";
            string Cevre_s = "";

            MainClass.Property_ls = new List<string>(){"Taban Ve Yükseklik","Kenar uzunlukları","iki kenar ile aralarındaki açı","iki kenar ile birinin karşındaki açı"
            ,"iki açı ile aralarındaki kenar","iki açı ile birinin karşısındaki kenar"};

             MainClass.TryInput_property();
            
            switch(MainClass.input)
            {
                case 1:
                    Console.WriteLine("Üçgen'in Taban uzunluğunu giriniz.");
                    Taban = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in Yüksekliğini giriniz.");
                    Yukseklik = MainClass.doubleConverter();
                break;

                case 2:
                    Console.WriteLine("Üçgen'in 1. kenar uzunluğunu giriniz.");
                    a = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in 2. kenar uzunluğunu giriniz.");
                    b = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in 3. kenar uzunluğunu giriniz.");
                    c = MainClass.doubleConverter();

                break;

                case 3:
                // a² = b² + c² - 2bc cos(A)
                    Console.WriteLine("Üçgen'in açı ölçüsünü giriniz.");
                    A = MainClass.doubleConverter()*180/Math.PI;
                    Console.WriteLine("Üçgen'in 1. kenar uzunluğunu giriniz.");
                    b = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in 2. kenar uzunluğunu giriniz.");
                    c = MainClass.doubleConverter();
                    
                break;

                 case 4:
                 // 
                    Console.WriteLine("Üçgen'in açı ölçüsünü giriniz.");
                    A = MainClass.doubleConverter()*180/Math.PI;
                    Console.WriteLine("Üçgen'in girdiğiniz açının karşısındaki kenar uzunluğunu giriniz.");
                    a = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in 2. kenar uzunluğunu giriniz.");
                    b = MainClass.doubleConverter();

                break;

                case 5:
                    Console.WriteLine("Üçgen'in 1. açı ölçüsünü giriniz.");
                    A = MainClass.doubleConverter()*180/Math.PI;
                    Console.WriteLine("Üçgen'in 2. açı ölçüsünü giriniz.");
                    B = MainClass.doubleConverter()*180/Math.PI;
                    Console.WriteLine("Üçgen'in kenar uzunluğunu giriniz.");
                    c = MainClass.doubleConverter();
                break;

                case 6:
                    Console.WriteLine("Üçgen'in kenar uzunluğunu giriniz.");
                    a = MainClass.doubleConverter();
                    Console.WriteLine("Üçgen'in girdiğiniz kenarın karşısındaki açı ölçüsünü giriniz.");
                    A = MainClass.doubleConverter()*180/Math.PI;
                    Console.WriteLine("Üçgen'in 2. açı ölçüsünü giriniz.");
                    B = MainClass.doubleConverter()*180/Math.PI;
                break;
            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre}};
            MainClass.TryInput_ToCalculate();

            if (Taban > 0 && Yukseklik > 0){Alan = Taban*Yukseklik/2;}
            else if (a > 0 && b > 0 && c > 0 ){
                Cevre = a + b + c; 
                }
            // a² = b² + c² - 2bc cos(A)
            else if (A > 0 && b > 0 && c > 0){
                a = Math.Sqrt(b*b + c*c - 2*b*c * Math.Cos(A));
                Cevre = a + b + c;
            }
            else if (A > 0 && a > 0 && b > 0){
                double ratio = Math.Sin(A)/a;
                // ratio = sin(B)/b
                //sin(B) = ratio *b
                B = Math.Asin(ratio * b);
                C = 180 - A - B;
                c = Math.Sqrt(b*b + a*a - 2*b*a * Math.Cos(C));
                Cevre = a + b + c; 
            }
            else if (A > 0 && B > 0 && c > 0){
                C = 180 - A - B;
                double ratio = Math.Sin(C)/c;
                a = Math.Sin(A)/ratio;
                b = Math.Sin(B)/ratio;
                Cevre = a + b + c;

            }
            else if (a > 0 && A > 0 && B > 0){
                C = 180 - A - B;
                double ratio = Math.Sin(A)/a;
                b = Math.Sin(B)/ratio;
                c = Math.Sin(C)/ratio;
                Cevre = a + b + c;
            }
            else if (Cevre > 0 ){Alan = Math.Sqrt((Cevre/2)*((Cevre/2)-a)*((Cevre/2)-b)*((Cevre/2)-c));}


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
            }
            List<double> Result_ls= new List<double>(){Alan,Cevre};
            return Result_ls;

        }
    }
}
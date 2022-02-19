using System;
namespace AlanHesaplama{
    public static class Kure{
        public static void function()
        {
            double Kure_yaricapi = 0;
            double Yuzey_alani = 0;  
            double Hacim = 0; 
                //string
            string Yuzey_alani_s = "";
            string Hacim_s = "";

            Console.WriteLine("Kürenin yarıçapını giriniz.");
            Kure_yaricapi = MainClass.doubleConverter();

            MainClass.ToCalculate_ls = new (){{"Prizmanın yüzey alanı",Yuzey_alani},{"prizmanın hacmi",Hacim}};
            MainClass.TryInput_ToCalculate();

            Hacim = 4 * Math.PI * Math.Pow(Kure_yaricapi,3) /3;
            Yuzey_alani = 4 * Math.Pow(Kure_yaricapi,2);

            Yuzey_alani_s = MainClass.GetRidOfZeros(Yuzey_alani);
            Hacim_s = MainClass.GetRidOfZeros(Hacim);

            switch(MainClass.input){
                case 1:
                    Console.Write("Küpün yüzey alanı  :  ");
                    Console.WriteLine(Yuzey_alani_s);    
                break;
                case 2:
                    Console.Write("Küpün hacmi  :  ");
                    Console.WriteLine(Hacim_s);    
                break;
            }
        }
    }
}
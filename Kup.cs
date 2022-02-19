using System;
namespace AlanHesaplama{
    public static class Kup{
        public static void function()
        {
            double Kup_ayriti = 0;
            double Yan_Yuzey_Alani = 0; 
            double Yuzey_alani = 0;  
            double Hacim = 0; 
                //string
            string Yan_Yuzey_Alani_s = "";
            string Yuzey_alani_s = "";
            string Hacim_s = "";

           
            Console.WriteLine("Küpün ayrıtını giriniz.");
            Kup_ayriti = MainClass.doubleConverter();

            MainClass.ToCalculate_ls = new (){{"Prizmanın yan yüzey alanı",Yan_Yuzey_Alani},{"Prizmanın yüzey alanı",Yuzey_alani},{"prizmanın hacmi",Hacim}};
            MainClass.TryInput_ToCalculate();
            Hacim = Math.Pow(Kup_ayriti,3);
            Yuzey_alani =  6* Math.Pow(Kup_ayriti,2);
            Yan_Yuzey_Alani =  4* Math.Pow(Kup_ayriti,2);

            Yan_Yuzey_Alani_s = MainClass.GetRidOfZeros(Yan_Yuzey_Alani);
            Yuzey_alani_s = MainClass.GetRidOfZeros(Yuzey_alani);
            Hacim_s = MainClass.GetRidOfZeros(Hacim);

            switch(MainClass.input){
                case 1:
                    Console.Write("Küpün yan yüzey alanı  :  ");
                    Console.WriteLine(Yan_Yuzey_Alani_s);    
                break;
                case 2:
                    Console.Write("Küpün yüzey alanı  :  ");
                    Console.WriteLine(Yuzey_alani_s);    
                break;
                case 3:
                    Console.Write("Küpün hacmi  :  ");
                    Console.WriteLine(Hacim_s);    
                break;
            }
        }
    }
}
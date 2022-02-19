using System;
namespace AlanHesaplama{
    public static class Koni{
        static double Koni_yuksekligi=0;
        static double Yan_Yuzey_Alani = 0;          
        static double Yuzey_alani = 0; 
        static double Hacim = 0;
        static double Taban_Cevresi = 0;
        static double Taban_Alani = 0;

        public static void function()
        {
            string Koni_yuksekligi_s ="";
            string Yan_Yuzey_Alani_s = "";
            string Yuzey_alani_s = "";
            string Hacim_s = "";

            Console.WriteLine("Taban özellikleri ..");
            Daire.Quick_function();
            Taban_Alani = Daire.Result_ls[0];
            Taban_Cevresi = Daire.Result_ls[1];
            Console.WriteLine("Koninin yüksekliğini giriniz.");
            Koni_yuksekligi = MainClass.doubleConverter();

            MainClass.ToCalculate_ls = new (){{"Koninin yan yüzey alanı",Yan_Yuzey_Alani},{"Koninin yüzey alanı",Yuzey_alani},{"Koninin hacmi",Hacim}};

            MainClass.TryInput_ToCalculate();

            Hacim = Taban_Alani * Koni_yuksekligi /3;
            Yuzey_alani =  Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Koni_yuksekligi),2) )  * Taban_Cevresi / 2 + Taban_Alani;
            //   (yanal yüzey yüksekliği)² = r² + h²          r =2 * taban alanı / taban cevresi
                                        // Yanal yüzey alanı = yanal yüzey yüksekliği * taban cevresi /2
            Yan_Yuzey_Alani =Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Koni_yuksekligi),2) )  * Taban_Cevresi / 2 ;

            Koni_yuksekligi_s = MainClass.GetRidOfZeros(Koni_yuksekligi);
            Yan_Yuzey_Alani_s = MainClass.GetRidOfZeros(Yan_Yuzey_Alani);
            Yuzey_alani_s = MainClass.GetRidOfZeros(Yuzey_alani);
            Hacim_s = MainClass.GetRidOfZeros(Hacim);

            switch(MainClass.input){
                case 1:
                    Console.Write("Koninin yüksekliği  :  ");
                    Console.WriteLine(Koni_yuksekligi_s);    
                break;
                case 2:
                    Console.Write("Koninin yüzey alanı  :  ");
                    Console.WriteLine(Yuzey_alani_s);    
                break;
                case 3:
                    Console.Write("Koninin hacmi  :  ");
                    Console.WriteLine(Hacim_s);    
                break;

            }


        }
    }
}
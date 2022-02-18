using System;
namespace AlanHesaplama{
    public static class Piramit{
        static short input=0;
        static List<string> prism_shapes = new List<string>(){"Üçgen piramit","dörtgen piramit","Beşgen piramit","altıgen piramit","Yedigen piramit","Sekizgen piramit"};
        public static void function()
        {
        /*         r * P/2  = S
                   r : tabanın iç yarıçapı
                   P : tananın çevresi
                   S : tabanın alanı 
        */
            double Prizma_yuksekligi=0;
            double Yan_Yuzey_Alani = 0; //   (yanal yüzey yüksekliği)² = r² + h²          r =2 * taban alanı / taban cevresi
                                        // Yanal yüzey alanı = yanal yüzey yüksekliği * taban cevresi /2
            double Yuzey_alani = 0;  // taban Çevresi *  prizma yüksekliği +  taban alanı
            double Hacim = 0;  // taban alanı * prizma yüksekliği

            // taban 
            double Taban_Cevresi = 0;
            double Taban_Alani = 0;
                //string
            string Prizma_yuksekligi_s ="";
            string Yan_Yuzey_Alani_s = "";
            string Yuzey_alani_s = "";
            string Hacim_s = "";

            piramit_sec(); 
            // geri dödürülen değer dizisi {alan, çevre}
            Console.WriteLine("prizmanın taban özellikleri ...."); 
            switch(input)
            {
                case 1 :    
                      //  Çokgen {alan,cevre}
                    Taban_Alani = Ucgen.function()[0];
                    Taban_Cevresi = Ucgen.function()[1];
                break;
                case 2 :                
                    Taban_Alani = Kare.function()[0];
                    Taban_Cevresi = Kare.function()[1];
                break;
                case 3 :                
                    Taban_Alani = Besgen.function()[0];
                    Taban_Cevresi = Besgen.function()[1];
                break;
                case 4 :                
                    Taban_Alani = Altigen.function()[0];
                    Taban_Cevresi = Altigen.function()[1];
                break;
                case 5 :                
                    Taban_Alani = Yedigen.function()[0];
                    Taban_Cevresi = Yedigen.function()[1];
                break;
                case 6 :                
                    Taban_Alani = Sekizgen.function()[0];
                    Taban_Cevresi = Sekizgen.function()[1];
                break;
            }
            Console.WriteLine("Prizmanın yüksekliğini giriniz.");
            Prizma_yuksekligi = MainClass.doubleConverter();

            MainClass.ToCalculate_ls = new (){{"Prizmanın yan yüzey alanı",Yan_Yuzey_Alani},{"Prizmanın yüzey alanı",Yuzey_alani},{"prizmanın hacmi",Hacim}};

            MainClass.TryInput_ToCalculate();

            Hacim = Taban_Alani * Prizma_yuksekligi /3;
            Yuzey_alani =  Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Prizma_yuksekligi),2) )  * Taban_Cevresi / 2 + Taban_Alani;
            //   (yanal yüzey yüksekliği)² = r² + h²          r =2 * taban alanı / taban cevresi
                                        // Yanal yüzey alanı = yanal yüzey yüksekliği * taban cevresi /2
            Yan_Yuzey_Alani =Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Prizma_yuksekligi),2) )  * Taban_Cevresi / 2 ;

            Prizma_yuksekligi_s = MainClass.GetRidOfZeros(Prizma_yuksekligi);
            Yan_Yuzey_Alani_s = MainClass.GetRidOfZeros(Yan_Yuzey_Alani);
            Yuzey_alani_s = MainClass.GetRidOfZeros(Yuzey_alani);
            Hacim_s = MainClass.GetRidOfZeros(Hacim);

            switch(MainClass.input){
                case 1:
                    Console.Write("Prizma yüksekliği  :  ");
                    Console.WriteLine(Prizma_yuksekligi_s);    
                break;
                case 2:
                    Console.Write("Prizmanın yüzey alanı  :  ");
                    Console.WriteLine(Yuzey_alani_s);    
                break;
                case 3:
                    Console.Write("prizmanın hacmi  :  ");
                    Console.WriteLine(Hacim_s);    
                break;

            }


        }

        public static void piramit_sec(){
            Console.WriteLine("Piramidin taban şeklini seçiniz.");
            for (int i = 0; i < prism_shapes.Count; i++)
            {
                Console.WriteLine(((i+1).ToString()+"_").PadRight(4)+prism_shapes[i]);
            }
            bool checker = Int16.TryParse(Console.ReadLine(), out input);
            if(!checker) {Console.WriteLine("Hatalı tuşlama yaptınız !"); piramit_sec(); }
        }
    }
}
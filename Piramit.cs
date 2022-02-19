using System;
namespace AlanHesaplama{
    public static class Piramit{
        static short input=0;
        static List<string> prism_shapes = new List<string>(){"Üçgen piramit","dikdörtgen piramit","Beşgen piramit","altıgen piramit","Yedigen piramit","Sekizgen piramit"};
        public static void function()
        {
            double Piramit_yuksekligi=0;
            double Yan_Yuzey_Alani = 0; 
            double Yuzey_alani = 0;  
            double Hacim = 0;  

            // taban 
            double Taban_Cevresi = 0;
            double Taban_Alani = 0;
                //string
            string Piramit_yuksekligi_s ="";
            string Yan_Yuzey_Alani_s = "";
            string Yuzey_alani_s = "";
            string Hacim_s = "";

            piramit_sec(); 
            // geri dödürülen değer dizisi {alan, çevre}
            Console.WriteLine("piramidin taban özellikleri ...."); 
            switch(input)       //  Çokgen {alan,cevre}
            {
                case 1 :    
                    Ucgen.Quick_function();
                    Taban_Alani = Ucgen.Result_ls[0];
                    Taban_Cevresi = Ucgen.Result_ls[1];
                break;
                case 2 :   
                    Kare.Quick_function();             
                    Taban_Alani = Kare.Result_ls[0];
                    Taban_Cevresi = Kare.Result_ls[1];
                break;
                case 3 :  
                    Besgen.Quick_function();              
                    Taban_Alani = Besgen.Result_ls[0];
                    Taban_Cevresi = Besgen.Result_ls[1];
                break;
                case 4 :
                    Altigen.Quick_function();
                    Taban_Alani = Altigen.Result_ls[0];
                    Taban_Cevresi = Altigen.Result_ls[1];
                break;
                case 5 :   
                    Yedigen.Quick_function();             
                    Taban_Alani = Yedigen.Result_ls[0];
                    Taban_Cevresi = Yedigen.Result_ls[1];
                break;
                case 6 :                
                    Sekizgen.Quick_function();
                    Taban_Alani = Sekizgen.Result_ls[0];
                    Taban_Cevresi = Sekizgen.Result_ls[1];
                break;
            }
            Console.WriteLine("Piramidin yüksekliğini giriniz.");
            Piramit_yuksekligi = MainClass.doubleConverter();

            MainClass.ToCalculate_ls = new (){{"Piramidin yan yüzey alanı",Yan_Yuzey_Alani},{"Piramidin yüzey alanı",Yuzey_alani},{"Piramidin hacmi",Hacim}};

            MainClass.TryInput_ToCalculate();

            Hacim = Taban_Alani * Piramit_yuksekligi /3;
            Yuzey_alani =  Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Piramit_yuksekligi),2) )  * Taban_Cevresi / 2 + Taban_Alani;
            //   (yanal yüzey yüksekliği)² = r² + h²          r =2 * taban alanı / taban cevresi
                                        // Yanal yüzey alanı = yanal yüzey yüksekliği * taban cevresi /2
            Yan_Yuzey_Alani =Math.Sqrt( Math.Pow((2* Taban_Alani / Taban_Cevresi),2) + Math.Pow((Piramit_yuksekligi),2) )  * Taban_Cevresi / 2 ;

            Piramit_yuksekligi_s = MainClass.GetRidOfZeros(Piramit_yuksekligi);
            Yan_Yuzey_Alani_s = MainClass.GetRidOfZeros(Yan_Yuzey_Alani);
            Yuzey_alani_s = MainClass.GetRidOfZeros(Yuzey_alani);
            Hacim_s = MainClass.GetRidOfZeros(Hacim);

            switch(MainClass.input){
                case 1:
                    Console.Write("Piramidin yan yüzey alanı  :  ");
                    Console.WriteLine(Yan_Yuzey_Alani_s);    
                break;
                case 2:
                    Console.Write("Piramidin yüzey alanı  :  ");
                    Console.WriteLine(Yuzey_alani_s);    
                break;
                case 3:
                    Console.Write("Piramidin hacmi  :  ");
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
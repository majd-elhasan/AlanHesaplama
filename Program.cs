using System;
 namespace AlanHesaplama
 {
     public static class MainClass
     {
         public static string set_KeyName ="";  //  past participle 'set' :)
        public static short input = 0;
        public static List<string> Property_ls = new List<string>();
        public static Dictionary<string,double> ToCalculate_ls = new Dictionary<string, double>();
        public static void TryInput_property()
        {
            Console.WriteLine("Neye göre hesaplamak istediğinizi seçiniz.");
            for (int i = 0; i < Property_ls.Count; i++)
            {
                Console.WriteLine(((i+1).ToString()+"_").PadRight(4)+Property_ls[i]);
            }
            bool checker = Int16.TryParse(Console.ReadLine(), out input);
            if(!checker) {Console.WriteLine("Hatalı tuşlama yaptınız !"); TryInput_property(); }
        }
        public static void TryInput_ToCalculate()
        {
            int  counter = 1;
            Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz.");
            foreach(var item in ToCalculate_ls)
            {
                if(item.Key == set_KeyName){
                    Console.WriteLine("   "+item.Key.PadRight(20) +item.Value + "   olarak girildi" );
                    counter ++;
                    continue;
                }
                Console.WriteLine((counter.ToString()+"_").PadRight(4) + item.Key.PadRight(10));
                counter ++;
            }
            bool checker = Int16.TryParse(Console.ReadLine(), out input);
            
            if(!checker) {Console.WriteLine("Hatalı tuşlama yaptınız !"); TryInput_ToCalculate(); }
            
        }
        public static string GetRidOfZeros(double d)
        {
            string s = "";
            s = d.ToString("F3");
            string _s = "";
            if (s.EndsWith(".000")){
                foreach(char c in s){
                    if (c == '.') break;
                    else _s += c;
                }
                return _s;
            }
            return s;
        }
        public static double doubleConverter()
        {
            double Output = 0;
            string value ="";
            Retry();
            void Retry(){
                value = Console.ReadLine();
                if(value == string.Empty || value is null){
                    Console.WriteLine("hiçbir bir veri girmediniz !");
                    Retry();
                } 
                
                try
                {
                    Output = Convert.ToDouble(value);
                }
                catch{
                    Console.WriteLine("Sayısal bir veri girmelisiniz.");
                    Retry();
                }
            }
        return Output;
        }
        static void Sekil_secici(short value)
            {
                switch (value)
                {
                    case (short)E_sekiller.daire :
                    Daire.function();
                    break;

                    case (short)E_sekiller.kare :
                    Kare.function();
                    break;

                    case (short)E_sekiller.ucgen :
                    Ucgen.function();
                    break;

                    case (short)E_sekiller.dikdortgen :
                    Dikdortgen.function();
                    break;

                    case (short)E_sekiller.yamuk :
                    Yamuk.function();
                    break;

                    case (short)E_sekiller.besgen :
                    Besgen.function();
                    break;

                    case (short)E_sekiller.altigen :
                    Altigen.function();
                    break;

                    case (short)E_sekiller.yedigen :
                    Yedigen.function();
                    break;

                    case (short)E_sekiller.sekizgen :
                    Sekizgen.function();
                    break;


                    case (short)E_sekiller.prizma :
                    Prizma.function();
                    break;

                    case (short)E_sekiller.koni :
                    Koni.function();
                    break;

                    case (short)E_sekiller.kure :
                    Kure.function();
                    break;

                    case (short)E_sekiller.kup :
                    Kup.function();
                    break;
                }
            }
        static void Main(string[] args)
        {
            veri_İşleme();
            void veri_İşleme(){
                input =  ConsoleProcessor.Input();

                bool finder = false;

                foreach (E_sekiller item in Enum.GetValues(typeof(E_sekiller)))
                {
                    if (input ==  (short)item ){finder=true; break;}  // çalışacak kod  Sekil_secici(sekil);
                }
                
                if (!finder){veri_İşleme();}
                Sekil_secici(input); 
            }
        }
        
     }
 }
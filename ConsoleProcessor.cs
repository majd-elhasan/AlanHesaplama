using System;
 namespace AlanHesaplama
 {
     public static class ConsoleProcessor
     {
        public static short Input()
        {
            short input = 0;
            try_input();
            void try_input(){
                Console.WriteLine("seçebileceğiniz şekiller aşağıdaki gibidir. ↓ ");
                Console.WriteLine("lütfen bileşenini hesaplamak istediğiniz şekil numarasını giriniz.");
                int counter = 0;
                foreach(var item in forms.sekiller)
                {
                    Console.Write((forms.sekiller.IndexOf(item)+1).ToString().PadRight(3) + (item).PadRight(27));
                    counter ++;
                    if (counter == 3){Console.WriteLine(); counter =0;}
                }
                // 
                Console.WriteLine();
                bool bool_input = Int16.TryParse(Console.ReadLine(),out input);
                if(!bool_input){ Console.WriteLine("lütfen alanını hesaplamak istediğiniz şekil numarasını giriniz.");
                try_input();}
                }
            return input;
        }

     }
 }
using System;
namespace AlanHesaplama
{
    public static class Dikdortgen
    {
        public static void function()
        {
            double Boy = 0;
            double En = 0;
            double Alan = 0;
            double Cevre = 0;
            double Kosegen = 0;
            double Theta = 0;
            string Boy_s = "";
            string En_s = "";
            string Alan_s = "";
            string Cevre_s = "";
            string Kosegen_s = "";

            MainClass.Property_ls = new List<string>(){"En ile boy","Köşegen uzunluğu ile köşegenlerin kendi aralarındaki yaptığı açı (geniş yada dar fark etmez)(derece)",
            "Alan ile boy","Alan ile En","Alan ile köşegen","Alan ile köşegenlerin kendi aralarındaki yaptığı açı (geniş yada dar fark etmez)(derece)",
            "Çevre ile boy","Çevre ile en","Çevre ile köşegen","Çevre ile köşegenlerin kendi aralarındaki yaptığı açı (geniş yada dar fark etmez)(derece)","Alan ile çevre"};

            MainClass.TryInput_property();
            
            switch(MainClass.input)
            {
                case 1:
                    Console.WriteLine("Eni giriniz.");
                    En = MainClass.doubleConverter();
                    Console.WriteLine("Boyu giriniz.");
                    Boy = MainClass.doubleConverter();
                break;

                case 2:
                    Console.WriteLine("Köşegen uzunluğunu giriniz.");
                    Kosegen = MainClass.doubleConverter();
                    Console.WriteLine("köşegenlerin kendi aralarındaki yaptığı açıyı giriniz.");
                    Theta = MainClass.doubleConverter()*180/Math.PI;
                break;

                case 3:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                    Console.WriteLine("Boyu giriniz.");
                    Boy = MainClass.doubleConverter();
                break;

                case 4:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                    Console.WriteLine("Eni giriniz.");
                    En = MainClass.doubleConverter();
                break;

                case 5:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                    Console.WriteLine("Köşegen uzunluğunu giriniz.");
                    Kosegen = MainClass.doubleConverter();
                break;

                case 6:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                    Console.WriteLine("köşegenlerin kendi aralarındaki yaptığı açıyı giriniz.");
                    Theta = MainClass.doubleConverter()*180/Math.PI;
                break;
                // çevre ile ..
                case 7:
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                    Console.WriteLine("Boyu giriniz.");
                    Boy = MainClass.doubleConverter();
                break;

                case 8:
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                    Console.WriteLine("Eni giriniz.");
                    En = MainClass.doubleConverter();
                break;

                case 9:
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                    Console.WriteLine("Köşegen uzunluğunu giriniz.");
                    Kosegen = MainClass.doubleConverter();
                break;

                case 10:
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                    Console.WriteLine("köşegenlerin kendi aralarındaki yaptığı açıyı giriniz.");
                    Theta = MainClass.doubleConverter()*180/Math.PI;
                break;
                case 11:
                    Console.WriteLine("Alanı giriniz.");
                    Alan = MainClass.doubleConverter();
                    Console.WriteLine("Çevre uzunluğunu giriniz.");
                    Cevre = MainClass.doubleConverter();
                    while (Cevre < 4* Math.Sqrt(Alan) ) 
                    {
                        Console.WriteLine("Çevre uzunluğunu geçersiz  ,yeniden deneyin !");
                        Console.WriteLine("Çevre uzunluğunu giriniz.");
                        Cevre = MainClass.doubleConverter();
                    }
                break;

            }
            MainClass.ToCalculate_ls = new (){{"Alan",Alan}, {"Çevre",Cevre},{"En",En},{"Boy",Boy},{"Köşegen",Kosegen}};
            MainClass.TryInput_ToCalculate();
            if (En > 0 && Boy > 0){
                Alan = En * Boy;
                Cevre = (En + Boy) * 2;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
            else if (Kosegen > 0 && Theta > 0){
                En = Kosegen * Math.Sin(Theta/2);
                Boy = Kosegen * Math.Cos(Theta/2);
                Alan = En * Boy;
                Cevre = (En + Boy) * 2;
            }
            // Alan ile ..
            else if (Alan > 0 && Boy > 0){
                En = Alan / Boy;
                Cevre = (En + Boy) * 2;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
            else if (Alan > 0 && En > 0){
                Boy = Alan / En;
                Cevre = (En + Boy) * 2;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
            else if (Alan > 0 && Kosegen > 0){
                Theta = Math.Asin(Alan *2 /(Kosegen*Kosegen));
                En = Kosegen * Math.Sin(Theta/2);
                Boy = Kosegen * Math.Cos(Theta/2);
                Cevre = (En + Boy) * 2;
            }
            else if (Alan > 0 && Theta > 0){
                Kosegen = Math.Sqrt(Alan *2 /Math.Sin(Theta));
                En = Kosegen * Math.Sin(Theta/2);
                Boy = Kosegen * Math.Cos(Theta/2);
                Cevre = (En + Boy) * 2;
            }
            // Çevre .. ↓
            else if (Cevre > 0 && Boy > 0){
                En = Cevre/2 - Boy;
                Alan = En * Boy;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
            else if (Cevre > 0 && En > 0){
                Boy = Cevre/2 - En;
                Cevre = (En + Boy) * 2;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
           
            else if (Cevre > 0 && Kosegen > 0){
                /*
                    en² + boy² = köşegen²
                    en + boy = cevre /2
                    (en + boy)² = (cevre /2)²
                    en² + boy² + 2 en * boy = cevre² / 4
                    köşegen² + 2 en * boy = cevre² /4
                    en * boy = [ (cevre² /4) - (köşegen²) ] /2       ***
                    Alan = [ (cevre² /4) - (köşegen²) ] /2
                    Theta = Asin[Alan *2 /(Kosegen²)];
                    en = sin(Theta/2) * köşegen
                    boy = cos(Theta/2) * köşegen

                    (en * boy)
                */
                Alan =  ((Cevre * Cevre / 4)-(Kosegen*Kosegen))/ 2;
                Theta = Math.Asin(Alan *2 /(Kosegen*Kosegen));
                En = Kosegen * Math.Sin(Theta/2);
                Boy = Kosegen * Math.Cos(Theta/2);

            }
            else if (Cevre > 0 && Theta > 0){
                /* 
                    en / boy = sin(Theta/2)/cos(Theta/2)  
                    en + boy = cevre /2            her tarafı boy bölelim
                    en / boy + boy/boy =  (cevre /2)/boy

                    sin(Theta/2)/cos(Theta/2) +1 = cevre /(2 * boy)
                    (2 * boy) * [sin(Theta/2)/cos(Theta/2) +1] =  cevre
                    2 * boy = cevre / [sin(Theta/2)/cos(Theta/2) +1]
                    boy = cevre / 2[sin(Theta/2)/cos(Theta/2) +1]

                */
                Boy = Cevre /(2*((Math.Sin(Theta/2)/Math.Cos(Theta/2))+1));
                En = Cevre/2 - Boy;
                Alan = En * Boy;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);

            }
            else if (Cevre > 0 && Alan > 0){
                /* 
                    2 en + 2 boy = cevre
                    en * boy = alan
                    2 en * boy + 2 boy² = cevre * boy
                    2 alan + 2 boy² = cevre * boy
                     2 boy² - cevre * boy + 2 alan = 0
                     delta = cevre² - 16*alan

                     en = (cevre - sqrt(cevre²-16*alan))/4
                     boy = (cevre + sqrt(cevre²-16*alan))/4
                */
               // En = (Cevre - Math.Sqrt(Cevre*Cevre - 16 * Alan))/4;
                Boy = (Cevre + Math.Sqrt(Cevre*Cevre - 16 * Alan))/4;  // şöyle de yaza bilirdik   Boy = Cevre/2 - En;
                En = Cevre/2 - Boy;
                Kosegen = Math.Sqrt(En*En + Boy*Boy);
            }
            // noktadan sonraki fazla rakamlardan kurtuluyoruz :)  ↓
            Boy_s = MainClass.GetRidOfZeros(Boy);
            En_s = MainClass.GetRidOfZeros(En);
            Alan_s = MainClass.GetRidOfZeros(Alan);
            Cevre_s = MainClass.GetRidOfZeros(Cevre);
            Kosegen_s = MainClass.GetRidOfZeros(Kosegen);
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
                    Console.Write("En  :  ");
                    Console.WriteLine(En_s);    
                break;

                case 4:
                    Console.Write("Boy  :  ");
                    Console.WriteLine(Boy_s);    
                break;

                case 5:
                    Console.Write("Köşegen  :  ");
                    Console.WriteLine(Kosegen_s); 
                break;
            }
        }
    }
}
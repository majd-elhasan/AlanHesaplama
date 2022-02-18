using System;
 namespace AlanHesaplama
 {
     public enum E_sekiller{
        ucgen = 1,
        kare ,
        yamuk,
        dikdortgen,
        besgen,
        altigen,
        yedigen,
        sekizgen,
        daire,
        
        
        kup,
        kure,
        prizma,
        koni
     }
     public static class forms
     {
         public static List<string> sekiller = new List<string>(){"Üçgen","Kare","Yamuk", "Dikdörtgen","Beşgen","Altıgen","Yedigen","Sekizgen",  "Daire",  "Küp", "Küre","Prizma", "Koni"};
     }
 }

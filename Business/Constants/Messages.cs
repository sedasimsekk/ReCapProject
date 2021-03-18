using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static classlar newlwnmeden kullanılabilirler.
    //static classın fieldı static olmalıdır.
    //fieldler pascal case yazılır 
    //propertyler küçük harf ile başlardı.
    public static class Messages
    {
        //burada amaç verilen mesajları rahatlıkla kontrol altına alabilmek tek tek değiştirmek yriene burada tek hamle ile değiştirebilmek 
        public static string CarAdded = " Araba Eklendi";
        public static string NameInvalid = "Girilen isim geçersiz";
        public static string CarListed = "Listelendi";
        public static string BrandAdded="Marka Eklendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserPasswordInvalid = "Girilen şifre boyutu yetersiz";
        public static string CustomerAdded="Müşteri Eklendi";
    }
}

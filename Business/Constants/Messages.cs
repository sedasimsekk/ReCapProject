﻿using System;
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
        public static string NotAddedRental = "Arabayı kiralayan kişi teslim etmediği için şuan sizin adınıza kiralanamaz";
        public static string RentalAdded="Araba Kiralandı,Hoşça Kullanın";
        public static string ReturnDateUpdate="Teslim Edildi,Teşekkür Ederiz Tekrar Görüşmek Dileğiyle";
        public static string ReturnDateNotUpdate="Araba Zaten Teslim Edilmiş";
        public static string CarDeleted="Araba Silindi";
        public static string CarUpdated="Araba Bilgileri Başarıyla Güncellendi";
        public static string BrandDeleted="Marka Silindi";
        public static string BrandUpdated="Marka Güncellenmesi Başarıyla Sağlandı";
        public static string ColorDeleted="Renk Silindi";
        public static string ColorUpdated="Renk Güncellenmesi Başarıyla Sağlandı";
        public static string UserDeleted="Kullanıcı Silindi";
        public static string UserUpdated="Kullanıcı Bilgileri Güncellemesi Başarıyla Sağlandı";
        public static string CustomerDeleted="Müşteri Silindi";
        public static string CustomerUpdated="Müşteri Başarıyla Güncellendi";
        public static string RentalDeleted="Araba Kiralama İşlemi Başarıyla Silindi";
    }
}

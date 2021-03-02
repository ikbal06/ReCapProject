using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Listelendi";
        public static string Number = "Fotoğraf sayısı 5ten az olmalı";
        public static string ImageExist = "Araba fotğrafı olmalı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccesfulLogin="Sisteme giriş başarılı";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Access Token başarıyla oluşturuldu";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}

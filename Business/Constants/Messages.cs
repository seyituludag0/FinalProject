using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductDetailDto = "Ürün bilgileri getirildi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Aynı isimden bir ürün var zaten";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkin yok!!!";
        public static string UserRegistered="Kayıt başarılı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists= "Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}

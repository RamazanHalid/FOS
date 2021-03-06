using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductListed = "Urunler listelendi";
        public static string ProductCountOfCategoryError = "Urun category sayisi fazla";
        public static string ProductNameAlreadyExists = "Produt Name already exists!";
        public static string CategoryLimitedExceded = "Category limiti doldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu";


        public static string FoodAdded = "Food added!";
        public static string FoodNotFound = "Food not found!";
        public static string FoodUpdated = "Food updated!";
        public static string FoodDeleted = "Food Deleted!";
        public static string ShippingCartAdded = "Shipping Cart Added!";
        public static string ShippingCartNotFound = "Shipping Cart not found";
        public static string ShippingCartUpdated = "Shipping Cart updated!";
        public static string RestaurantAdded = "Restaurant Added!";
        public static string RestaurantNotFound = "Restaurant not found!";
        public static string RestaurantUpdated = "Restaurant Added!";
        public static string RestaurantDeleted = "Restaurant deleted!";
        public static string FoodListAdded = "Food list added!";
        public static string FoodListNotFound = "Food list not found!";
        public static string FoodListUpdated = "Food list updated!";
        public static string FoodListDeleted = "Food list Deleted";
        public static string StateRules = "Time to closing for pandemic!";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MainTenanceTime = "Bakım zamanı";
        public static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir.";

        public static string ProductNameAlreadyExists = "böyle bi isimde ürün zaten var.";
        public static string CheckIfCategoryLimitExceded = "Kategori limiti aşıldığı için yrni ürün eklenemiyor";
    }
}

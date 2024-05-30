using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Yazilim", Description = "Yazilim dersleri"},
                new Category(){ Name = "Resim", Description = "Resim dersleri"},
                new Category(){ Name = "Bilgisayar Donanimi", Description = "Bilgisayar donanim dersleri"},
                new Category(){ Name = "Beslenme", Description = "Saglikli beslenme dersleri"},
                new Category(){ Name = "Muzik", Description = "Muzik dersleri"}
                new Category(){ Name = "Kitaplar", Description = "Didaktik kitaplar"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler=new List<Product>()
            {
               new Product(){ Name = "Python dersi 1" , Description= " Python dili ile yazılım geliştirme dersi 1   " , Educator = "Mustafa Uzun  " , Price = " 100 " , Time = " 1 saat  " , Quota = "  50     " , IsApproved =true,CategoryId = 1,IsHome = true},
               new Product(){ Name = " Python dersi 2 " , Description= "  Python dili ile yazılım geliştirme dersi 2   " , Educator = " Mustafa Uzun   " , Price = "200" , Time = " 2 saat", Quota = " 50         " , IsApproved =true, CategoryId = 1,IsHome = true},
               new Product(){ Name = " Python dersi 3 " , Description="    Python dili ile yazılım geliştirme dersi 3   " , Educator = "Mustafa Uzun " , Price = "300   " , Time = " 3 saat  " , Quota = "   50       " , IsApproved =true, CategoryId = 1,IsHome = true},
               new Product(){ Name = " Python dersi 4 " , Description="     Python dili ile yazılım geliştirme dersi 4   " , Educator = " Mustafa Uzun   " , Price = "400   " , Time = " 4 saat  " , Quota = "    50      " , IsApproved =true, CategoryId = 1,IsHome = true},
               new Product(){ Name = " Python dersi 5  " , Description="    Python dili ile yazılım geliştirme dersi 5  " , Educator = " Mustafa Uzun  " , Price = " 500  " , Time = "  5 saat " , Quota = "    50    " , IsApproved =true, CategoryId = 1,IsHome = true},

              new Product(){ Name = "  Resim Dersi 1" , Description = "Resim çizme becerilerini geliştirebilme dersi 1     " , Educator = " Mustafa Uzun    " , Price = "20000"  , Time = " 1 saat      " , Quota = , " 520   " , IsApproved =true,CategoryId = 2,IsHome = true},
              new Product(){ Name = "  Resim Dersi 2" , Description = "Resim çizme becerilerini geliştirebilme dersi 2     " , Educator = " Mustafa Uzun    " , Price = "2000"  , Time = " 1 saat      " , Quota = , " 550   " , IsApproved =true,CategoryId = 2,IsHome = true},
              new Product(){ Name = "  Resim Dersi 3" , Description = "Resim çizme becerilerini geliştirebilme dersi 3     " , Educator = " Mustafa Uzun    " , Price = "200"  , Time = " 2 saat " , Quota = , " 320   " , IsApproved =true,CategoryId = 2,IsHome = true},
              new Product(){ Name = "  Resim Dersi 4" , Description = "Resim çizme becerilerini geliştirebilme dersi 4     " , Educator = " Mustafa Uzun    " , Price = "200"  , Time = " 3 saat      " , Quota = , " 210   " , IsApproved =true,CategoryId = 2,IsHome = true},
              new Product(){ Name = "  Resim Dersi 5" , Description = "Resim çizme becerilerini geliştirebilme dersi 5     " , Educator = " Mustafa Uzun    " , Price = "20000"  , Time = " 5 saat      " , Quota = , " 120   " , IsApproved =true,CategoryId = 2,IsHome = true},

               new Product(){ Name = "     aaaa       " , Description "        aaa                                                       " , Educator = "     aa         " , Price = " 1    " , Time = "1        " , Quota = " 2          " , IsApproved =true, CategoryId = 3,IsHome = true},
               new Product(){ Name = "        aa      " , Description "      aaaa                                                        " , Educator = "    a           " , Price = " 1    " , Time = " 1       " , Quota = "  2         " , IsApproved =true, CategoryId = 3,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "      aaaa                                                        " , Educator = "    aaa         " , Price = "  1   " , Time = "  1      " , Quota = "   2        " , IsApproved =true, CategoryId = 3,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "     aaa                                                          " , Educator = "    aa          " , Price = "  1   " , Time = "  1      " , Quota = "     2      " , IsApproved =true, CategoryId = 3,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "     aaa                                                          " , Educator = "     aaa        " , Price = "  1   " , Time = "  1      " , Quota = "      2     " , IsApproved =true, CategoryId = 3,IsHome = true},

               new Product(){ Name = "      aaa       " , Description "      aaaa                                                        " , Educator = "    aa          " , Price = " 11   " , Time = "  1      " , Quota = " 2          " , IsApproved =true, CategoryId = 4,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "   aaa                                                            " , Educator = "     aa         " , Price = "   1  " , Time = "     1   " , Quota = "  22        " , IsApproved =true, CategoryId = 4,IsHome = true},
               new Product(){ Name = "       aaa      " , Description "    aaa                                                           " , Educator = "     aa         " , Price = "    1 " , Time = "   11    " , Quota = "    2       " , IsApproved =true, CategoryId = 4,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "     aaa                                                          " , Educator = "    aa          " , Price = "  1   " , Time = "  1      " , Quota = "     2      " , IsApproved =true, CategoryId = 4,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "     aaa                                                          " , Educator = "    aa          " , Price = "  1   " , Time = " 1       " , Quota = "      2     " , IsApproved =true, CategoryId = 4,IsHome = true},

               new Product(){ Name = "      aaa       " , Description "      aaa                                                         " , Educator = "    a           " , Price = "  1   " , Time = "     1   " , Quota = " 2          " , IsApproved =true, CategoryId = 5,IsHome = true},
               new Product(){ Name = "      aa        " , Description "      aa                                                          " , Educator = "    aa          " , Price = "   1  " , Time = "    1    " , Quota = "  2         " , IsApproved =true, CategoryId = 5,IsHome = true},
               new Product(){ Name = "       aa       " , Description "      aaaa                                                        " , Educator = "   aa           " , Price = " 1    " , Time = "   1     " , Quota = "   22       " , IsApproved =true, CategoryId = 5,IsHome = true},
               new Product(){ Name = "       aaa      " , Description "      aaa                                                         " , Educator = "   aaa          " , Price = "  1   " , Time = "  1      " , Quota = "     2      " , IsApproved =true, CategoryId = 5,IsHome = true},
               new Product(){ Name = "       aaa      " , Description "     aa                                                           " , Educator = "  aa            " , Price = "   1  " , Time = " 1       " , Quota = "     2      " , IsApproved =true, CategoryId = 5,IsHome = true},
               
               new Product(){ Name = "      aaaa      " , Description "         aa                                                       " , Educator = "           aa   " , Price = "1     " , Time = "     1   " , Quota = " 22         " , IsApproved =true, CategoryId = 6,IsHome = true},
               new Product(){ Name = "     aaa        " , Description "         aa                                                       " , Educator = "      aaa       " , Price = " 11   " , Time = "    1    " , Quota = "   2        " , IsApproved =true, CategoryId = 6,IsHome = true},
               new Product(){ Name = "     aa         " , Description "         aaa                                                      " , Educator = "    aaa         " , Price = " 1    " , Time = "   1     " , Quota = "    22      " , IsApproved =true, CategoryId = 6,IsHome = true},
               new Product(){ Name = "      aaa       " , Description "          aaa                                                     " , Educator = "    aaa         " , Price = " 1    " , Time = "  1      " , Quota = "     2      " , IsApproved =true, CategoryId = 6,IsHome = true},
               new Product(){ Name = "       aaa      " , Description "         aaa                                                      " , Educator = "    aaaa        " , Price = " 1    " , Time = " 1       " , Quota = "    2       " , IsApproved =true, CategoryId = 6,IsHome = true},

            };


            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
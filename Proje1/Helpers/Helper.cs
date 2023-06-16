using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Yıldızlar Arası",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 50,
                    picturePath = basePath + "/interstaller.jpeg"
                },
                   new Movie()
                {
                    movieName = "Inception",
                    category = Category.macera,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "/inception.jpg"
                },
                new Movie()
                {
                    movieName = "Iron Man",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "/ironman.jpg"
                },
                new Movie()
                {
                    movieName = "Lucy",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "/lucy.jpg"
                },
                new Movie()
                {
                    movieName = "Yetenekli Bay Cage",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "/massivetalentbycage.jpg"
                },

             new Movie()
                {
                    movieName = "The Last Of Us",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "/thelastofus.jpg"
                },


            };
        }
    }
}

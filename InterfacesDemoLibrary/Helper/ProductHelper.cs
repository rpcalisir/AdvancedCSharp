using InterfacesDemoLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Helper
{
    public class ProductHelper
    {
        public static List<IProduct> AddSampleData()
        {
            List<IProduct> products = new List<IProduct>()
            {
                new PhysicalProduct() { Title = "Basketball Ball"},
                new PhysicalProduct() { Title = "Curved Sword"},
                new PhysicalProduct() { Title = "Big Vase"},
                new DigitalProduct{Title = "Introduction To C# Ebook" },
                new DigitalProduct{ Title = "Head First to Python Ebook"},
                new DigitalProduct{ Title = "Les Miserables Pdf"},
                new DigitalProduct{ Title = "Vogue Magazine"},
                new DigitalProduct{ Title = "Windows 10 Professional License"},
                new DigitalProduct{ Title = "Health Magazine"}
            };
            return products;
        }
    }
}

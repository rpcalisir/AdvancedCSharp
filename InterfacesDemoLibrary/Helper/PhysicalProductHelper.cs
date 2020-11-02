using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Helper
{
    public static class PhysicalProductHelper
    {
        public static List<PhysicalProduct> AddSampleData()
        {
            List<PhysicalProduct> sampleData = new List<PhysicalProduct>();

            sampleData.Add(new PhysicalProduct() {Title = "Baseball Bat" });
            sampleData.Add(new PhysicalProduct() {Title = "Vase" });
            sampleData.Add(new PhysicalProduct() {Title = "Wheel cranck" });

            return sampleData;
        }
    }
}

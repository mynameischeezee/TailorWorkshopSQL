using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TailorWorkshopSQL.DataAccessLayer
{
    public static class InputOutPutSettings
    {

        private static Dictionary<string, List<int>> OptionalAttributes = new Dictionary<string, List<int>>();

        static InputOutPutSettings()
        {
            List<int> CustomerIDs = new List<int>();
            CustomerIDs.Add(6);
            CustomerIDs.Add(7);
            CustomerIDs.Add(8);
            List<int> OrderIDs = new List<int>();
            OrderIDs.Add(3);
            OrderIDs.Add(4);
            List<int> ProductIDs = new List<int>();
            ProductIDs.Add(9);
            List<int> TailorIDs = new List<int>();
            TailorIDs.Add(8);
            TailorIDs.Add(10);
            TailorIDs.Add(11);
            TailorIDs.Add(13);
            List<int> FabricManufacturerIDs = new List<int>();
            FabricManufacturerIDs.Add(3);
            FabricManufacturerIDs.Add(4);
            FabricManufacturerIDs.Add(5);
            FabricManufacturerIDs.Add(6);
            FabricManufacturerIDs.Add(7);
            OptionalAttributes.Add("Customer", CustomerIDs);
            OptionalAttributes.Add("Orders", OrderIDs);
            OptionalAttributes.Add("Product", ProductIDs);
            OptionalAttributes.Add("Tailor", TailorIDs);
            OptionalAttributes.Add("FabricManufacturer", FabricManufacturerIDs);
        }

        public static List<int> OptionalIDs(string tablename)
        {
            if (OptionalAttributes.ContainsKey(tablename))
            {
                return OptionalAttributes[tablename];
            }
            else
            {
                return new List<int>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace COMPortTerminal
{
    class OrderList : List <Order>
    {
        public String[] toStringList()
        {
            String[] s = new String[this.Count];
            int i = Count;
            foreach (Order n in this)
            {
                i = i - 1;
                s[i] = n.ToString();
                
            }
            return s;
        }
        public int getTotalQuantity()
        {
            int quantity = 0;
            foreach (Order n in this)
            {
                quantity = quantity + n.getQuantity();
            }
            return quantity;
        }
        public double getTotalPrice()
        {
            double price = 0;
            foreach (Order n in this)
            {
                price = price + n.getPrice();
            }
            return price;
        }
        public void UpdateFile()
        {
            try
            {
                //get desktop path 
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tables";

                //ensure directory exists, if not create it
                if (!(Directory.Exists(path)))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                path += "\\Table.txt";

                // Determine whether the File exists.
                if (!(File.Exists(path)))
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                }
                //Overwrite with whole list
                StreamWriter sw = new StreamWriter(path,false);
                string size = null;
                foreach (Order n in this)
                {
                    switch (n.getSizeString())
                    {
                        case "Small":
                            size = "S";
                            break;
                        case "Medium":
                            size = "M";
                            break;
                        case "Large":
                            size = "L";
                            break;
                        default:
                            size = "Bad Coding Briano";
                            Console.WriteLine("ERROR: INVALID CARD");
                            break;
                    }
                    sw.Write(n.getQuantity());
                    sw.WriteLine(":" + size);
                }
                sw.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            } 
        }
        public void UpdateFileAdd(Order new_Item)
        {
            try
            {
                //get desktop path 
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tables";

                //ensure directory exists, if not create it
                if (!(Directory.Exists(path)))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                path += "\\Table.txt";

                // Determine whether the File exists.
                if (!(File.Exists(path)))
                {
                   FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                   fs.Close();
                }
                //append to the end of the file with the new item
                StreamWriter sw = new StreamWriter(path,true);
                string size = null;
                switch (new_Item.getSizeString())
                {
                    case "Small":
                        size = "S";
                        break;
                    case "Medium":
                        size = "M";
                        break;
                    case "Large":
                        size = "L";
                        break;
                    default:
                        size = "Bad Coding Briano";
                        Console.WriteLine("ERROR: INVALID CARD");
                        break;
                }
                sw.Write(new_Item.getQuantity());
                sw.WriteLine(":" + size);
                sw.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            } 
        }
    }
}

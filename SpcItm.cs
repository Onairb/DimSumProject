using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMPortTerminal
{
    public class SpcItm
    {
        //private int SpcID;
        private string SpcName;
        private double SpcPrice;
        private string TableNum;

        //constructor
        public SpcItm(string inSpcName, string inSpcPrice)
        {
            SpcName = inSpcName;
            SpcPrice = Convert.ToDouble(inSpcPrice);

        }

        public SpcItm(string inSpcName, string inSpcPrice, string tableNum)
        {
            SpcName = inSpcName;
            SpcPrice = Convert.ToDouble(inSpcPrice);
            TableNum = tableNum;

        }
        //destructor
        ~SpcItm()
        {
            Console.WriteLine("Distorying SpcItem, Good Coding Practice to create Destructor?");
        }

        //returning the information
        public string getSpcName()
        {
            return (SpcName);
        }
        public double getSpcPrice()
        {
            return (SpcPrice);
        }
        public string getTableNum()
        {
            return (TableNum);
        }
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(SpcName);
            sb.Append("\t\t");
            if (SpcPrice != 0)
            {
                sb.Append("$" + SpcPrice.ToString());
                sb.Append(" ea.");
            }
            return sb.ToString();
        }
    }
}

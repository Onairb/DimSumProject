using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace COMPortTerminal
{
    public class SpcList:List<SpcItm>
    {
        public SpcList FileToOrders(string path)
        {
            SpcList newList = new SpcList();

            try
            {
                System.Text.StringBuilder SpcName = new System.Text.StringBuilder();
                System.Text.StringBuilder SpcPrice = new System.Text.StringBuilder();
                //read the file
                StreamReader SR = new StreamReader(path);
                while (SR.Peek() > 0)
                {
                    while ((char)SR.Peek() != ';')
                    {
                        if (SR.Peek() == -1)
                            break;
                        SpcName.Append((char)SR.Read());
                    }
                    if (SR.Peek() == ';')
                        SR.Read();

                    while (SR.Peek() != ';')
                    {
                        if (SR.Peek() == -1)
                            break;
                        SpcPrice.Append((char)SR.Read());
                    }
                    SpcItm Spc = new SpcItm(SpcName.ToString(), SpcPrice.ToString());
                    newList.Add(Spc);
                    SR.ReadLine();

                    SpcName.Clear();
                    SpcPrice.Clear();
                }
                SR.Close();

                return (newList);
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
                return (newList);
            } 
        }

        public void ListToFile(string Path, string tableNum, bool Append)
        {
            StreamWriter SW = new StreamWriter(Path, Append);
                foreach (SpcItm n in this)
                {
                    SW.Write(n.getSpcName());
                    SW.Write(';');
                    SW.Write(n.getSpcPrice());
                    SW.Write(';');
                    SW.WriteLine(tableNum);
                }
             SW.Close();
        }
        
        public SpcList FileToList(string path)
        {
            SpcList newList = new SpcList();

            try
            {
                System.Text.StringBuilder SpcName = new System.Text.StringBuilder();
                System.Text.StringBuilder SpcPrice = new System.Text.StringBuilder();
                //read the file
                StreamReader SR = new StreamReader(path);
                while (SR.Peek() >0)
                {
                    while ((char)SR.Peek() != ';')
                    {
                        if (SR.Peek() == -1)
                            break;
                        SpcName.Append((char)SR.Read());
                    }
                    if (SR.Peek() == ';')
                        SR.Read();
                                       
                        while (SR.Peek() != ((char)13))
                        {
                            if (SR.Peek() == -1)
                                break;
                            SpcPrice.Append((char)SR.Read());
                        }
                        SpcItm Spc = new SpcItm(SpcName.ToString(), SpcPrice.ToString());
                        newList.Add(Spc);
                        SR.ReadLine();
                    
                    SpcName.Clear();
                    SpcPrice.Clear();
                }
                SR.Close();   
                
                return(newList);
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
                return(newList);
            } 
        }

        public String[] toStringList()
        {
            String[] s = new String[this.Count];
            //int i = Count;
            //foreach (SpcItm n in this)
            for(int i=0;i<Count;i++)
            {
                //i = i - 1;
                s[i] = this[i].ToString();

            }
            return s;
        }
    }
}

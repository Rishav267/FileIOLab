using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = null;
            List<String> list = new List<string>();
            try
            {
                read = new StreamReader("C:\\Users\\risha\\OneDrive\\Documents\\names.txt");
                string line;
               
                line = read.ReadLine();
                string[] s = line.Split(',');
                Array.Sort(s);
                //for(int j= 0;j<s.Length; j++)
                //{
                //    Console.WriteLine("{0} {1}", s[j], j + 1);
                //}
                
                Dictionary<string, int> d = new Dictionary<string, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    string x = s[i].Trim('"');
                    char[] b = x.ToCharArray();
                    int val = 0;
                    foreach(char c in b)
                    {
                        val += ((int)c - ((int)'A' - 1));
                    }
                    
                    val = val * (i + 1);
                    //Console.WriteLine("{0} {1}", val, i + 1);
                    d[s[i]] = val;
                }
                int tot = 0;
                foreach(var dt in d)
                {
                    tot += dt.Value;
                }
                Console.WriteLine(tot);


            }
            catch
            {

            }
            finally
            {
                if(read != null)
                {
                    read.Close();
                }
            }
        }
    }
}

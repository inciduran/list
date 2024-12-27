using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class okul
    {
        public string okuladı;
        public List<string> öğrenci = new List<string>();
        public void Oğrencıekle()
        {
            öğrenci.Add("0");

        }
        public void Öğrencilistele()
        {
            foreach (var item in öğrenci)
            {
                Console.WriteLine("item. ad+  item.soyad ");
            }
        }
    }
}
          
            
        



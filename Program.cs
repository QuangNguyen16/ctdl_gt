using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_GT
{
    class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login();

            //l.loginAccount();
            LinkedList<Sach> list = new LinkedList<Sach>();
            ReadList(list);
            PrintList(list);
            WriteList(list);
            PrintList(list);
            
            Console.ReadKey();

        }
        static void WriteList(LinkedList<Sach> l)
        {
            using (StreamWriter sW = new StreamWriter("Sach.txt"))
            {
                sW.WriteLine(l.Count);
                for (LinkedListNode<Sach> p = l.First; p != null; p = p.Next)
                {
                    p.Value.Write(sW);
                }
            }
        }
        static void PrintList(LinkedList<Sach> l)
        {
            for (LinkedListNode<Sach> p = l.First; p != null; p = p.Next)
            {
                p.Value.Print();
            }
            Console.WriteLine("Ds cp  {0} phan tu.", l.Count);
        }
        static void ReadList(LinkedList<Sach> l)
        {
            int n = 0;
            using (StreamReader sR = new StreamReader("Sach.txt"))
            {
                int.TryParse(sR.ReadLine(), out n);
                for (int i = 0; i < n; i++)
                {
                    Sach s = new Sach();
                    s.Read(sR);
                    l.AddLast(s);
                }
            }
        }
        
    }
}






using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class CustomCollection:ICollection

      

    {
        public CustomCollection(int[] d)
        {
            elements = d;

        }
        public void add(int c)
        {
            var elements0= new int[elements.Length+1];
            for (int k=0; k<elements.Length; k++)
            {
                elements0[k] = elements[k];
            }
            elements0[elements0.Length-1] = c;
            elements=elements0;

      
        for (int i = 0;i<elements.Length-1;i++)
            {
                for (int j = 0;j<elements.Length-1;j++)
                {
                    if (elements[j]>elements[j+1])
                    {
                        int x=elements[j];
                        elements[j] =elements[j+1];
                        elements[j+1] =x;

                    }
                }
            }
        }

       

        public int[] elements;

        public int Count
        {
            get { return elements.Length; }
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[9] { 3, 2, 1, 4, 5, 6, 9, 8, 7 };
            var a = new CustomCollection(b);
            for (int i = 0; i < a.elements.Length; i++)
            {
                Console.Write(a.elements[i]);
                Console.Write("     ");
            }
            Console.WriteLine();
            a.add(5);
            for (int i = 0; i < a.elements.Length; i++)
            {
                Console.Write(a.elements[i]);
                Console.Write("     ");
            }

            Console.ReadKey();
        }
        
           
    }
}

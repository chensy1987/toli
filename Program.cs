using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Test tst = new Test();
            tst.SortLiniar(tst.generArr());
        }
    }

    public class Test
    {
        public int[] array { get; set; }

        public Test()
        {
            array = new int[20];
        }
        public int[] generArr()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            return array;
        }

        public void SortLiniar (int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j  =  i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
        }
    }
}

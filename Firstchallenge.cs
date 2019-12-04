using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
    public class Firstchallenge
    {

        public Firstchallenge()
        {

        }

        public static void Showmap()
        {
          
            string[] list = { "rice","beans","yam","semo" };

            Dictionary<int, string> amap = new Dictionary<int, string>();

            for (int k=0; k<list.Length; k++)
            {
                amap.Add(k, list[k]);
            }

            foreach (var item in amap)
            {
                Console.WriteLine(item.Value);
            }
        }

    }
}

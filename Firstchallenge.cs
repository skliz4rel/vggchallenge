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
            Dictionary<string, string> amap = new Dictionary<string, string>();

            amap.Add("1","rice");
            amap.Add("2","beans");
            amap.Add("3","yam");
            amap.Add("4","semo");

            foreach (var item in amap)
            {
                Console.WriteLine(item.Value);
            }
        }

    }
}

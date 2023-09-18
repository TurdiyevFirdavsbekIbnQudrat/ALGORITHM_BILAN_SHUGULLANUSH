using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHM_BILAN_SHUGULLANUSH
{
    public static class ExtensionClass
    {
        public static int[][] AddElement(this int[][] Arrays, int a, int b)
        {
            List<int> ArrayTolist = Arrays[a].ToList<int>();
            var d = ArrayTolist.Append(b);
            Arrays[a] = d.ToArray();
            return Arrays;
        }
        public static int[][] AddElement(this int[][] Arrays, int a)
        {
            int b = Arrays.Length + 1;

            int[][] Ar1 = new int[b][];
            int j = 0;
            foreach (var item in Arrays)
            {
                var i = item.ToList();
                Ar1[j] = i.ToArray();
                j++;
            }
            Ar1[j] = new int[] { a };
            return Ar1;
        }

    }
}

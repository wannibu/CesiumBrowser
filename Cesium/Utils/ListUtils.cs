using System.Collections.Generic;

namespace Cesium.Utils
{
    public static class ListUtils
    {
        public static void Swap<T>(this List<T> list, int indexA, int indexB)
        {
            var temp = list[indexA];
            list.RemoveAt(indexA);
            list.Insert(indexB, temp);
        }
    }
}

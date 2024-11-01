using System.Collections.Generic;
using System.Linq;

namespace UnityConsoleTool.Runtime
{
    public static class Extensions
    {
        // purely for nullable reference type analysis
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class
        {
            return source.Where(x => x != null)!;
        }
    }
}

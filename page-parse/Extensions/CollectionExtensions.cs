using System;
using System.Collections.Generic;

namespace CSGOStats.Infrastructure.PageParse.Extensions
{
    public static class CollectionExtensions
    {
        [Obsolete("Should be replaced with corresponding package call.")]
        public static IEnumerable<T> ToCollection<T>(this T instance)
        {
            yield return instance;
        }
    }
}
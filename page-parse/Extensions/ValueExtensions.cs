using System;

namespace CSGOStats.Infrastructure.PageParse.Extensions
{
    public static class ValueExtensions
    {
        [Obsolete("Should be replaced with corresponding package call.")]
        public static T OfType<T>(this object instance) => (T) instance;
    }
}
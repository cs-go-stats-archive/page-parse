using System;
using CSGOStats.Extensions.Validation;

namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BaseMapValueAttribute : Attribute
    {
        public string MapperCode { get; }

        public BaseMapValueAttribute(string mapperCode)
        {
            MapperCode = mapperCode.NotNull(nameof(mapperCode));
        }
    }
}
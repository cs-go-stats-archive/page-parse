using System;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Mapping.Specific;

namespace CSGOStats.Infrastructure.PageParse.Extraction
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IntegerValueAttribute : BaseMapValueAttribute
    {
        public IntegerValueAttribute() 
            : base(IntegerValueMapper.IntegerValueCode)
        {
        }
    }
}
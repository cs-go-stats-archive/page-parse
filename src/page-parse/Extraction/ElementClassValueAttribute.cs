using System;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Mapping.Specific;

namespace CSGOStats.Infrastructure.PageParse.Extraction
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementClassValueAttribute : BaseMapValueAttribute
    {
        public ElementClassValueAttribute()
            : base(ElementClassMapper.ElementClassValueCode)
        {
        }
    }
}
using System;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Mapping.Specific;

namespace CSGOStats.Infrastructure.PageParse.Extraction
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementTitleValueAttribute : BaseMapValueAttribute
    {
        public ElementTitleValueAttribute()
            : base(ElementTitleMapper.ElementTitleValueCode)
        {
        }
    }
}
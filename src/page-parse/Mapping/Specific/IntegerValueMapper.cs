using CSGOStats.Extensions.Validation;
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    public class IntegerValueMapper : BaseIntegerValueMapper, IValueMapper
    {
        internal const string IntegerValueCode = nameof(IntegerValueMapper);

        public object Map(HtmlNode root) => TryMap(root).NotNull(nameof(root.InnerText));
    }
}
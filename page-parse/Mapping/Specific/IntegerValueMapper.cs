using CSGOStats.Infrastructure.PageParse.Guard;
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    public class IntegerValueMapper : BaseIntegerValueMapper, IValueMapper
    {
        internal const string IntegerValueCode = nameof(IntegerValueMapper);

        public object Map(HtmlNode root) => TryMap(root).ShouldHaveValue(nameof(root.InnerText));
    }
}
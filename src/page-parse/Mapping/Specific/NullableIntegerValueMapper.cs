using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    public class NullableIntegerValueMapper : BaseIntegerValueMapper, IValueMapper
    {
        internal const string NullableIntegerValueCode = nameof(NullableIntegerValueMapper);

        public object Map(HtmlNode root) => TryMap(root);
    }
}
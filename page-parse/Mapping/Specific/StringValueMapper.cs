using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    public class StringValueMapper : IValueMapper
    {
        internal const string StringValueCode = nameof(StringValueMapper);

        public object Map(HtmlNode root) => root.InnerText;
    }
}
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public interface IValueMapper
    {
        object Map(HtmlNode root);
    }
}
using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelLeaf]
    public class BodySubmodel
    {
        [AnchorLinkValue]
        public string Link { get; private set; }

        [ElementTitleValue]
        public string Title { get; private set; }
    }
}
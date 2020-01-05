using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelLeaf]
    public class OptionalContainer2Model
    {
        [OptionalContainer("p"), PlainTextValue]
        public string Text { get; private set; }
    }
}
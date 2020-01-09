using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelLeaf]
    public class OptionalContainerModel
    {
        [RequiredContainer("p"), PlainTextValue]
        public string Text { get; set; }

        [RequiredContainer("span"), IntegerValue]
        public int Number { get; set; }
    }
}
using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;
using CSGOStats.Infrastructure.PageParse.Structure.Markers;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelLeaf]
    public class HeaderModel
    {
        [Collection, RequiredContainer("div/ul[@class = 'numbers']/li"), IntegerValue]
        public WrappedCollection<int> Numbers { get; } = new WrappedCollection<int>();

        [Collection, RequiredContainer("div/ul[@class = 'texts']/li"), PlainTextValue]
        public WrappedCollection<string> Texts { get; } = new WrappedCollection<string>();

        [RequiredContainer("span"), ElementClassValue]
        public string Span { get; private set; }
    }
}
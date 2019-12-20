using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;
using CSGOStats.Infrastructure.PageParse.Structure.Markers;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelRoot, RootContainer("*/body/div[@id = 'root']")]
    public class TestPageModel
    {
        [RequiredContainer("div[@id = 'header']")]
        public HeaderModel Header { get; set; }

        [RequiredContainer("div[@id = 'body']")]
        public BodyModel Body { get; set; }

        [RequiredContainer("div[@id = 'footer']/p"), PlainTextValue]
        public string Footer { get; set; }
    }

    [ModelLeaf]
    public class HeaderModel
    {
        [Collection, RequiredContainer("div/ul[@class = 'numbers']/li"), IntegerValue]
        public WrappedCollection<int> Numbers { get; } = new WrappedCollection<int>();

        [Collection, RequiredContainer("div/ul[@class = 'texts']/li"), PlainTextValue]
        public WrappedCollection<string> Texts { get; } = new WrappedCollection<string>();
    }

    [ModelLeaf]
    public class BodyModel
    {
        [Collection, OptionalContainer("div[@class = 'optional-container']/div")]
        public WrappedCollection<OptionalContainerModel> Containers { get; } = new WrappedCollection<OptionalContainerModel>();
    }

    [ModelLeaf]
    public class OptionalContainerModel
    {
        [RequiredContainer("p"), PlainTextValue]
        public string Text { get; set; }

        [RequiredContainer("span"), IntegerValue]
        public int Number { get; set; }
    }
}
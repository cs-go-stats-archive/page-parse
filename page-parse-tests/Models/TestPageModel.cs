using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;

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
}
using CSGOStats.Infrastructure.PageParse.Extraction;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;
using CSGOStats.Infrastructure.PageParse.Structure.Markers;

namespace CSGOStats.Infrastructure.PageParse.Tests.Models
{
    [ModelLeaf]
    public class BodyModel
    {
        [Collection, OptionalContainer("div[@class = 'optional-container']/div")]
        public WrappedCollection<OptionalContainerModel> Containers { get; } = new WrappedCollection<OptionalContainerModel>();

        [RequiredContainer("a"), AnchorLinkValue]
        public string Link { get; private set; }

        [RequiredContainer("a/img"), ElementTitleValue]
        public string ImageTitle { get; private set; }

        [RequiredContainer("div[@class = 'sub']/a")]
        public BodySubmodel Submodel { get; private set; }

        [Collection, RequiredContainer("div[@class = 'optional-container-2']/div")]
        public WrappedCollection<OptionalContainer2Model> Containers2 { get; } = new WrappedCollection<OptionalContainer2Model>();
    }
}
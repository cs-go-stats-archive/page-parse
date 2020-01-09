using CSGOStats.Extensions.Validation;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;

namespace CSGOStats.Infrastructure.PageParse.Page.Parsing
{
    public class ContainerMetadata
    {
        public string Path { get; }

        public bool IsRequired { get; }

        public ContainerMetadata(string path, bool isRequired)
        {
            Path = path.NotNull(nameof(path));
            IsRequired = isRequired;
        }

        public static ContainerMetadata CreateFrom(BasePropertyContainerAttribute attribute) => attribute == null
            ? null
            : new ContainerMetadata(attribute.Path, attribute.IsRequired);
    }
}
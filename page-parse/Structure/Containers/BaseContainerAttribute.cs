using System;
using CSGOStats.Infrastructure.PageParse.Guard;

namespace CSGOStats.Infrastructure.PageParse.Structure.Containers
{
    public abstract class BaseContainerAttribute : Attribute
    {
        public string Path { get; }

        protected BaseContainerAttribute(string path)
        {
            Path = path.NotNull(nameof(path));
        }
    }
}
using System;

namespace CSGOStats.Infrastructure.PageParse.Structure.Containers
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class RootContainerAttribute : BaseContainerAttribute
    {
        public RootContainerAttribute(string rootPath)
            : base(rootPath)
        {
        }
    }
}
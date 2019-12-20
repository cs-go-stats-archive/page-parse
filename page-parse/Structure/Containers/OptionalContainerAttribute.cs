using System;

namespace CSGOStats.Infrastructure.PageParse.Structure.Containers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class OptionalContainerAttribute : BasePropertyContainerAttribute
    {
        public OptionalContainerAttribute(string path) 
            : base(path, false)
        {
        }
    }
}
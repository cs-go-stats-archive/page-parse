using System;

namespace CSGOStats.Infrastructure.PageParse.Structure.Containers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredContainerAttribute : BasePropertyContainerAttribute
    {
        public RequiredContainerAttribute(string path) 
            : base(path, true)
        {
        }
    }
}
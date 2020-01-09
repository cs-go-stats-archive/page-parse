namespace CSGOStats.Infrastructure.PageParse.Structure.Containers
{
    public abstract class BasePropertyContainerAttribute : BaseContainerAttribute
    {
        public bool IsRequired { get; }

        protected BasePropertyContainerAttribute(string path, bool isRequired) 
            : base(path)
        {
            IsRequired = isRequired;
        }
    }
}
namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    internal class AnchorLinkMapper : ElementAttributeMapper
    {
        internal const string AnchorLinkValueCode = nameof(AnchorLinkMapper);

        public AnchorLinkMapper() 
            : base("href")
        {
        }
    }
}
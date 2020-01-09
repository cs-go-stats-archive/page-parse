namespace CSGOStats.Infrastructure.PageParse.Mapping.Specific
{
    internal class ElementTitleMapper : ElementAttributeMapper
    {
        internal const string ElementTitleValueCode = nameof(ElementTitleMapper);

        public ElementTitleMapper()
            : base("title")
        {
        }
    }
}
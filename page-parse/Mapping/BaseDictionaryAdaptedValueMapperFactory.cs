namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public class BaseDictionaryAdaptedValueMapperFactory : AdaptedValueMapperFactory
    {
        public BaseDictionaryAdaptedValueMapperFactory(
            BaseDictionaryValueMapperFactory initialValueMapperFactory, 
            IValueMapperFactory adaptedValueMapperFactory) 
            : base(initialValueMapperFactory, adaptedValueMapperFactory)
        {
        }
    }
}
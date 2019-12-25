namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public class BaseDictionaryAdaptedValueMapperFactory : AdaptedValueMapperFactory
    {
        public BaseDictionaryAdaptedValueMapperFactory(IValueMapperFactory adaptedValueMapperFactory) 
            : base(new BaseDictionaryValueMapperFactory(), adaptedValueMapperFactory)
        {
        }
    }
}
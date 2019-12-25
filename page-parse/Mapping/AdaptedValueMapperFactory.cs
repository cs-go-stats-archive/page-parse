using CSGOStats.Extensions.Validation;

namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public abstract class AdaptedValueMapperFactory : IValueMapperFactory
    {
        private readonly IValueMapperFactory _initialValueMapperFactory;
        private readonly IValueMapperFactory _adaptedValueMapperFactory;

        protected AdaptedValueMapperFactory(IValueMapperFactory initialValueMapperFactory, IValueMapperFactory adaptedValueMapperFactory)
        {
            _initialValueMapperFactory = initialValueMapperFactory.NotNull(nameof(initialValueMapperFactory));
            _adaptedValueMapperFactory = adaptedValueMapperFactory.NotNull(nameof(adaptedValueMapperFactory));
        }

        public IValueMapper Create(string mapperCode) => 
            CreateSafeFromInitial(mapperCode) ??
            _adaptedValueMapperFactory.Create(mapperCode);

        private IValueMapper CreateSafeFromInitial(string mapperCode)
        {
            try
            {
                return _initialValueMapperFactory.Create(mapperCode);
            }
            catch
            {
                return null;
            }
        }
    }
}
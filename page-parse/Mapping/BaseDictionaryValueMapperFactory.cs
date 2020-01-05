using CSGOStats.Infrastructure.PageParse.Mapping.Specific;

namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public class BaseDictionaryValueMapperFactory : IValueMapperFactory
    {
        public IValueMapper Create(string mapperCode)
        {
            switch (mapperCode)
            {
                case AnchorLinkMapper.AnchorLinkValueCode:
                    return new AnchorLinkMapper();
                case ElementClassMapper.ElementClassValueCode:
                    return new ElementClassMapper();
                case ElementTitleMapper.ElementTitleValueCode:
                    return new ElementTitleMapper();
                case IntegerValueMapper.IntegerValueCode:
                    return new IntegerValueMapper();
                case NullableIntegerValueMapper.NullableIntegerValueCode:
                    return new NullableIntegerValueMapper();
                case StringValueMapper.StringValueCode:
                    return new StringValueMapper();
                default:
                    return null;
            }
        }
    }
}
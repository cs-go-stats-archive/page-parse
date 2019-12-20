namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public interface IValueMapperFactory
    {
        IValueMapper Create(string mapperCode);
    }
}
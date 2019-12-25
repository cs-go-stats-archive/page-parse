using System;
using System.Collections.Generic;
using CSGOStats.Infrastructure.PageParse.Mapping.Specific;
using MapperCode = System.String;

namespace CSGOStats.Infrastructure.PageParse.Mapping
{
    public class BaseDictionaryValueMapperFactory : IValueMapperFactory
    {
        private readonly IDictionary<MapperCode, Func<IValueMapper>> _mappersDictionary = new Dictionary<MapperCode, Func<IValueMapper>>
        {
            [IntegerValueMapper.IntegerValueCode] = () => new IntegerValueMapper(),
            [NullableIntegerValueMapper.NullableIntegerValueCode] = () => new NullableIntegerValueMapper(),
            [StringValueMapper.StringValueCode] = () => new StringValueMapper(),
        };

        public IValueMapper Create(string mapperCode) => _mappersDictionary[mapperCode].Invoke();
    }
}
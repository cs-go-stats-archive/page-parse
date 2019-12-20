using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace CSGOStats.Infrastructure.PageParse.Page
{
    [Serializable]
    public class UnknownPropertyException : Exception
    {
        public UnknownPropertyException(Type objectType, PropertyInfo property)
            : base($"Member '{property.Name}' of type '{objectType.FullName}' doesn't have nor Mapper neither Subtree path declared.")
        {
        }

        protected UnknownPropertyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
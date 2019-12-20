using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSGOStats.Infrastructure.PageParse.Guard;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Structure.Containers;
using CSGOStats.Infrastructure.PageParse.Structure.Markers;
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Page
{
    public static class PageParserExtensions
    {
        public static IEnumerable<PropertyMetadata> GetProperties(this object instance) => 
            instance.GetType().ExtractParseProperties(instance);

        public static (object, IEnumerable<PropertyMetadata>) GetProperties(this WrappedCollection collection)
        {
            var genericType = collection.GetType().GetGenericArguments().Single();
            var instance = genericType.CreateInstance();
            return (instance, genericType.ExtractParseProperties(instance));
        }

        public static IEnumerable<HtmlNode> EnumerateSafe(this IEnumerable<HtmlNode> nodes, PropertyMetadata metadata)
        {
            if (metadata.Container.IsRequired)
            {
                return nodes.NotNull(nameof(nodes));
            }

            return nodes ?? Enumerable.Empty<HtmlNode>();
        }

        public static ActionType GetActionType(this PropertyMetadata property)
        {
            if (property.Container != null && property.MappingCode != null)
            {
                return ActionType.BindMarkupAndExtractValue;
            }

            if (property.Container != null)
            {
                return ActionType.BindMarkup;
            }

            if (property.MappingCode != null)
            {
                return ActionType.ExtractValue;
            }

            return ActionType.Unknown;
        }

        public static object CreateInstance(this Type type) => Activator.CreateInstance(type);

        public static bool IsRoot(this Type type) => type.IsAttributePresented<ModelRootAttribute>();

        public static bool IsLeaf(this Type type) => type.IsAttributePresented<ModelLeafAttribute>();

        public static bool IsCollection(this PropertyInfo property) => property.IsAttributePresented<CollectionAttribute>();

        private static IEnumerable<PropertyMetadata> ExtractParseProperties(this Type type, object instance) => type
            .GetProperties(BindingFlags.Public |
                           BindingFlags.Instance |
                           BindingFlags.GetProperty)
            .Select(x => new PropertyMetadata(
                instance,
                x,
                ContainerMetadata.CreateFrom(x.GetCustomAttribute<BasePropertyContainerAttribute>(false)),
                x.IsAttributePresented<CollectionAttribute>(),
                x.GetCustomAttribute<BaseMapValueAttribute>(false)?.MapperCode))
            .Where(x => x.Container != null || x.MappingCode != null);

        private static bool IsAttributePresented<TAttribute>(this PropertyInfo property)
            where TAttribute : Attribute => property.GetCustomAttribute<TAttribute>(false) != null;

        private static bool IsAttributePresented<TAttribute>(this Type type)
            where TAttribute : Attribute => type.GetCustomAttribute<TAttribute>(false) != null;
    }

    public class PropertyMetadata
    {
        public object Subtree { get; }

        public PropertyInfo Property { get; }

        public ContainerMetadata Container { get; }

        public bool IsCollection { get; }

        public string MappingCode { get; }

        public PropertyMetadata(object subtree, PropertyInfo property, ContainerMetadata container, bool isCollection, string mappingCode)
        {
            Subtree = subtree.NotNull(nameof(subtree));
            Property = property.NotNull(nameof(property));
            Container = container.NotNull(nameof(container));
            IsCollection = isCollection;
            MappingCode = mappingCode;
        }
    }

    public class ContainerMetadata
    {
        public string Path { get; }

        public bool IsRequired { get; }

        public ContainerMetadata(string path, bool isRequired)
        {
            Path = path.NotNull(nameof(path));
            IsRequired = isRequired;
        }

        public static ContainerMetadata CreateFrom(BasePropertyContainerAttribute attribute) => attribute == null
            ? null
            : new ContainerMetadata(attribute.Path, attribute.IsRequired);
    }

    public enum ActionType
    {
        Unknown,
        BindMarkup,
        ExtractValue,
        BindMarkupAndExtractValue // TODO may union of Bind/Extract
    }
}
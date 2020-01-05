using System;
using System.Runtime.Serialization;
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Page.Parsing
{
    [Serializable]
    public class AmbiguousMarkupPath : XPathException
    {
        public AmbiguousMarkupPath(HtmlNode root, string path)
            : base(root, path, $"More than one element found by expression '{path}' when context requires a single entry.")
        {
        }

        protected AmbiguousMarkupPath(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
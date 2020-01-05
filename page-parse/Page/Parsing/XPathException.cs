using System;
using System.Runtime.Serialization;
using HtmlAgilityPack;

namespace CSGOStats.Infrastructure.PageParse.Page.Parsing
{
    [Serializable]
    public abstract class XPathException : Exception
    {
        public HtmlNode Root { get; }

        public string Path { get; }

        protected XPathException(HtmlNode root, string path, string message)
            : base(message)
        {
            Root = root;
            Path = path;
        }

        protected XPathException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
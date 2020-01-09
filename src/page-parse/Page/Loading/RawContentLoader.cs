using System.Threading.Tasks;
using CSGOStats.Extensions.Validation;

namespace CSGOStats.Infrastructure.PageParse.Page.Loading
{
    public class RawContentLoader : IContentLoader
    {
        private readonly string _content;

        public RawContentLoader(string content)
        {
            _content = content.NotNull(nameof(content));
        }

        public Task<string> LoadAsync() => Task.FromResult(_content);
    }
}
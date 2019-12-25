using System.Threading.Tasks;
using CSGOStats.Infrastructure.PageParse.Page.Loading;

namespace CSGOStats.Infrastructure.PageParse.Page.Parsing
{
    public interface IPageParser<T>
        where T : class
    {
        Task<T> ParseAsync(IContentLoader contentLoader);
    }
}
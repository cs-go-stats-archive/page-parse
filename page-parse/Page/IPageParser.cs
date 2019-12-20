using System.Threading.Tasks;

namespace CSGOStats.Infrastructure.PageParse.Page
{
    public interface IPageParser<T>
        where T : class
    {
        Task<T> ParseAsync(string content);
    }
}
using System.Threading.Tasks;

namespace CSGOStats.Infrastructure.PageParse.Page.Loading
{
    public interface IContentLoader
    {
        Task<string> LoadAsync();
    }
}
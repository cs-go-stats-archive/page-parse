using System.IO;
using System.Threading.Tasks;
using CSGOStats.Extensions.Validation;

namespace CSGOStats.Infrastructure.PageParse.Page.Loading
{
    public class FileContentLoader : IContentLoader
    {
        private readonly string _filepath;

        public FileContentLoader(string filepath)
        {
            _filepath = filepath.NotNull(nameof(filepath));
        }

        public async Task<string> LoadAsync()
        {
            await using var fileStream = new FileStream(_filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var reader = new StreamReader(fileStream);
            return await reader.ReadToEndAsync();
        }
    }
}
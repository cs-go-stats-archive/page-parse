using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Page;
using CSGOStats.Infrastructure.PageParse.Tests.Models;
using FluentAssertions;
using Xunit;

namespace CSGOStats.Infrastructure.PageParse.Tests
{
    public class PageParseTests
    {
        [Fact]
        public async Task ParseHtmlTestAsync()
        {
            var parser = CreateTestPageParser();
            var result = await parser.ParseAsync(await GetTestHtml());

            result.Header.Numbers.Should().BeEquivalentTo(1, 2, 3);
            result.Header.Texts.Should().BeEquivalentTo("one", "two", "three");

            result.Body.Containers.Select(x => (x.Number, x.Text)).Should().BeEquivalentTo(Enumerable
                .Range(1, 2)
                .Select(i => (i, $"text {i}")));

            result.Footer.Should().Be("Footer text.");
        }

        // TODO: pass via DI dependency
        private static IPageParser<TestPageModel> CreateTestPageParser() => 
            new PageParser<TestPageModel>(new BaseDictionaryValueMapperFactory());

        private static async Task<string> GetTestHtml()
        {
            await using var fileStream = new FileStream("Pages/TestPage.html", FileMode.Open, FileAccess.Read, FileShare.Read);
            using var reader = new StreamReader(fileStream);
            return await reader.ReadToEndAsync();
        }
    }
}
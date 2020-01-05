using System.Linq;
using System.Threading.Tasks;
using CSGOStats.Infrastructure.PageParse.Mapping;
using CSGOStats.Infrastructure.PageParse.Page.Loading;
using CSGOStats.Infrastructure.PageParse.Page.Parsing;
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
            var result = await parser.ParseAsync(CreateTestPageLoader());

            result.Header.Numbers.Should().BeEquivalentTo(1, 2, 3);
            result.Header.Texts.Should().BeEquivalentTo("one", "two", "three");
            result.Header.Span.Should().Be("test-span");

            result.Body.Containers.Select(x => (x.Number, x.Text)).Should().BeEquivalentTo(Enumerable
                .Range(1, 2)
                .Select(i => (i, $"text {i}")));
            result.Body.Link.Should().Be("https://www.mozilla.org/en-US/");
            result.Body.ImageTitle.Should().Be("Mozilla");
            result.Body.Submodel.Link.Should().Be("https://www.mozilla.org/en-US/");
            result.Body.Submodel.Title.Should().Be("Mozilla");
            result.Body.Containers2.Select(x => x.Text).Should().BeEquivalentTo(new[]
            {
                "Text 1",
                null,
                "Text 3",
            });

            result.Footer.Should().Be("Footer text.");
        }

        // TODO: pass via DI dependency
        private static IPageParser<TestPageModel> CreateTestPageParser() => 
            new PageParser<TestPageModel>(new BaseDictionaryValueMapperFactory());

        private static IContentLoader CreateTestPageLoader() =>
            new FileContentLoader("Pages/TestPage.html");
    }
}
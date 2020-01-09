namespace CSGOStats.Infrastructure.PageParse.Page.Parsing
{
    public enum ActionType
    {
        Unknown,
        BindMarkup,
        ExtractValue,
        BindMarkupAndExtractValue // TODO may union of Bind/Extract
    }
}
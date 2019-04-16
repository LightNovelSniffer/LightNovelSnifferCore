using HtmlAgilityPack;

namespace LightNovelSnifferCore.Web.Parser
{
    public interface IParser
    {
        LnChapter Parse(HtmlDocument doc);
        bool CanParse(string url);
    }
}

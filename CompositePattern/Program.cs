using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.SetStartTag("<html>");
            parentTag.SetEndTag("</html>");
            HtmlTag p1 = new HtmlParentElement("<body>");
            p1.SetStartTag("<body>");
            p1.SetEndTag("</body>");
            parentTag.AddChildTag(p1);
            HtmlTag child1 = new HtmlElement("<P>");
            child1.SetStartTag("<P>");
            child1.SetEndTag("</P>");
            child1.SetTagBody("Testing html tag library");
            p1.AddChildTag(child1);
            child1 = new HtmlElement("<P>");
            child1.SetStartTag("<P>");
            child1.SetEndTag("</P>");
            child1.SetTagBody("Paragraph 2");
            p1.AddChildTag(child1);
            parentTag.GenerateHtml();
        }
    }
}
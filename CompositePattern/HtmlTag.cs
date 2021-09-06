using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class HtmlTag
    {
        public abstract String GetTagName();
        public abstract void SetStartTag(String tag);
        public abstract void SetEndTag(String tag);
        public virtual void SetTagBody(String tagBody)
        {
            throw new NotImplementedException();
        }

        public virtual void AddChildTag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public virtual List<HtmlTag> GetChildren()
        {
            throw new NotImplementedException();
        }
        public abstract void GenerateHtml();
    }
}
using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class HtmlElement : HtmlTag
    {
        private String tagName;
        private String startTag; 
        private String endTag;
        private String tagBody;
     
        public HtmlElement(String tagName){
            this.tagName = tagName;
            this.tagBody = "";
            this.startTag = "";
            this.endTag = "";
        }
        
        public override String GetTagName() {
            return tagName;
        }
        
        public override void SetStartTag(String tag) {
            this.startTag = tag;
        }
        
        public override void SetEndTag(String tag) {
            this.endTag = tag;
        }
        
        public override void SetTagBody(String tagBody){
            this.tagBody = tagBody;
        }

        public override void GenerateHtml() {
            Console.WriteLine(startTag+""+tagBody+""+endTag);
        }
    }
}
using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class HtmlParentElement : HtmlTag
    {
        private String tagName;
        private String startTag; 
        private String endTag;
        private List<HtmlTag>childrenTag;
     
        public HtmlParentElement(String tagName){
            this.tagName = tagName;
            this.startTag = "";
            this.endTag = "";
            this.childrenTag = new List<HtmlTag>();
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

        public override void AddChildTag(HtmlTag htmlTag){
            childrenTag.Add(htmlTag);
        }
        
        public override void RemoveChildTag(HtmlTag htmlTag){
            childrenTag.Remove(htmlTag);
        }
        
        public override List<HtmlTag> GetChildren(){
            return childrenTag;
        }
        
        public override void GenerateHtml() {
            Console.WriteLine(startTag);
            foreach(HtmlTag tag in childrenTag){
                tag.GenerateHtml();
            }
            Console.WriteLine(endTag);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace OutlookClient
{
    public class RulesClient
    {
        public List<Rule> Rules;

        public RulesClient()
        {
            this.Rules = new List<Rule>();
        }

        public void AddRule(IRuleCondition ruleCondition, IRuleAction ruleAction)
        {
            this.Rules.Add(new Rule( ruleCondition, ruleAction ));
        }
        
    }
}
using System;

namespace OutlookClient
{
    public class Rule
    {
        public IRuleCondition RuleCondition;
        public IRuleAction RuleAction;

        public Rule(IRuleCondition ruleCondition, IRuleAction ruleAction)
        {
            this.RuleCondition = ruleCondition;
            this.RuleAction = ruleAction;
        }
        
        public void Execute(IMessage message)
        {
            if (RuleCondition.ValidCondition(message))
            {
                RuleAction.ExecuteAction(message);
            }
        }
    }
}
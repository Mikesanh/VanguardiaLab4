using Lab4.Core.Interfaces;
using Lab4.Core.Models.Movements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.Rules
{
    public partial class RulesBuilder
    {
        private readonly List<BaseRules> _rules = new List<BaseRules>();

        public RulesBuilder()
        {
           
        }

        public IRuleEngine Build()
        {
            _rules.Add(new PawnMovement());
            return new MovementsRuleEngine(_rules);
        }
    }
}

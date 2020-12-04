using Lab4.Core.Models.Movements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.Rules
{
    public partial class RulesBuilder
    {
        public RulesBuilder WithRookRules()
        {
            _rules.Add(new RookMovement());
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using Lab4.Core.Models.Rules;
using System.Text;
using Lab4.Core.Models.Movements;

namespace Lab4.Core.Models.Rules
{
    public partial class RulesBuilder
    {
        public RulesBuilder WithKnightRules()
        {
            _rules.Add(new KnightMovement());
            return this;
        }
    }
}

using System;
using Lab4.Core;
using Lab4.Infrastructure.Serializers;
using Lab4.Infrastructure.Sources;
using Lab4.Core.Rules;
using Newtonsoft.Json.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = new JsonFileGameSource().GetDataFromJson();
            var arrayOfMovements = JArray.Parse(fileContent);
            var gameSerializer = new JsonFileGameSerializer();
            var ruleEngine = new RulesBuilder().WithKnightRules().WithRookRules().Build();
            var gameEngine = new Engine( new PieceFactory(), ruleEngine);
            foreach (var movementData in arrayOfMovements)
            {
                var movement = gameSerializer.SerializeMovement(movementData.ToString());
                gameEngine.ExecuteMovement(movement);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lab4.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab4.Tests
{
    public static class TestDataSource
    {
       
        private const string MovementsFile = @"C:\\Users\\sanch\\source\\repos\\Lab4\\Lab4.Tests\\TestData\\movements.json";
        public static IEnumerable<Movement> GetMovements()
        {
            var data = File.ReadAllText(MovementsFile);
            return JsonConvert.DeserializeObject<IEnumerable<Movement>>(data);
        }

        public static Movement GetMovement(string key)
        {
            var data = File.ReadAllText(MovementsFile);
            var json = JObject.Parse(data);
            var @object = json.Value<JObject>(key);
            return JsonConvert.DeserializeObject<Movement>(@object.ToString());
        }
    }
}

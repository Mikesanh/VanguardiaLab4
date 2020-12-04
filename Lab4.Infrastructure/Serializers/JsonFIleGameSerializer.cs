using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Infrastructure.Serializers
{
    public class JsonFileGameSerializer : IMovementSerializer
    {
        public Movement SerializeMovement(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException();
            }

            return JsonConvert.DeserializeObject<Movement>(data);
        }
    }
}

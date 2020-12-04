using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4.Infrastructure
{
    public class JsonFileSource
    {
        public string GetDataFromJson()
        {
            return File.ReadAllText("ChessGame.json");
        }

    }
}

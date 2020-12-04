using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lab4.Core.Interfaces;


namespace Lab4.Infrastructure.Sources
{
    public class JsonFileGameSource : IChessSource
    {
        public string GetDataFromJson()
        {
            return File.ReadAllText("C:\\Users\\sanch\\source\\repos\\Lab4\\Lab4\\ChessGame.json");
        }

    }
}

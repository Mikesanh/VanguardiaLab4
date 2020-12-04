using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Models;
namespace Lab4.Core.Interfaces
{
    interface IMovements
    {
        void Start();

        void Move(Movement movement);

        void Stop();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Models;

namespace Lab4.Core.Interfaces
{
    public interface IMovementSerializer
    {
        Movement SerializeMovement(string data);
    }
}

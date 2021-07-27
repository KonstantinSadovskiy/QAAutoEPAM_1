﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public interface IFlyable
    {
        void FlyTo(Coordinates newCoordinates);
        double GetFlyTime(Coordinates newCoordinates);
    }
}
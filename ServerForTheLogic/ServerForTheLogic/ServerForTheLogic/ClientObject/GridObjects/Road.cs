﻿


using ServerForTheLogic.ClientObject;
using System;

namespace ServerForTheLogic
{
    /// <summary>
    /// MongoDAL
    /// Team: DB
    /// Road class mapped to Road collection of the database and the "roads" in the simulation.
    /// Author: Stephanie 
    /// Date: 2017 11 08
    /// </summary>
    class Road : GridObject
    {
        public Road(Guid guid, int xPoint, int yPoint) : base(guid, xPoint, yPoint)
        {
        }
    }
}

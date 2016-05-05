﻿using System;
using System.Collections.Generic;

namespace Smartpool.DataAccess
{
    public class DataAccess : IWriteDataAccess, IReadDataAccess
    {
        public IPoolAccess PoolAccess { get; set; }

        public bool CreateChlorineEntry(string poolOwnerEmail, string poolName, int chlorineValue)
        {
            throw new NotImplementedException();
        }

        public bool CreateTemperatureEntry(string poolOwnerEmail, string poolName, int temperatureValue)
        {
            throw new NotImplementedException();
        }

        public Dictionary<DateTime, Temperature> GetRecentChlorineValues(string poolOwnerEmail, string poolName, int howManyToReturns)
        {
            throw new NotImplementedException();
        }

        public Dictionary<DateTime, Temperature> GetRecentTemperatureValues(string poolOwnerEmail, string poolName, int howManyToReturns)
        {
            throw new NotImplementedException();

        }
    }
}
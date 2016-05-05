﻿using System;
using System.Collections.Generic;

namespace Smartpool.DataAccess
{
    public interface IWriteDataAccess
    {
        IPoolAccess PoolAccess { get; set; }
        bool CreateChlorineEntry(string poolOwnerEmail, string poolName, int chlorineValue);
        bool CreateTemperatureEntry(string poolOwnerEmail, string poolName, int temperatureValue);
    }

    public interface IReadDataAccess
    {
        IPoolAccess PoolAccess { get; set; }
        Dictionary<DateTime, Temperature> GetRecentChlorineValues(string poolOwnerEmail, string poolName, int howManyToReturns);
        Dictionary<DateTime, Temperature> GetRecentTemperatureValues(string poolOwnerEmail, string poolName, int howManyToReturns);
    }
}
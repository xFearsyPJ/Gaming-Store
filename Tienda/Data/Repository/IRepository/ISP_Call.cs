﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Data.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null);

        void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null);

        T ExecuteReturnScaler<T>(string procedureName, DynamicParameters param = null);
    }
}

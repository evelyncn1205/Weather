﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Service
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}

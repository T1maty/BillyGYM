using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OA.Service.Exceptions;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BilliGYM.Service.Middleware
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
    }
}

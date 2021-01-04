using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TopLevelWebApi
{
    public class Ping
    {
        public Task RunAsync(HttpContext context)
        {
            return context.Response.WriteAsync("Pong");
        }
    }
}
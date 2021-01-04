using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TopLevelWebApi
{
    public class HelloWorld
    {
        public Task RunAsync(HttpContext context)
        {
            return context.Response.WriteAsync("Hello World");
        }
    }
}
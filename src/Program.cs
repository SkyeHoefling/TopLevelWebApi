using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using TopLevelWebApi;

WebHost.CreateDefaultBuilder()
    .Configure(app =>
    {
        app.UseRouting();
        app.UseEndpoints(endpointBuilder =>
        {
            endpointBuilder.MapGet("/", c => new HelloWorld().RunAsync(c));
            endpointBuilder.MapGet("Ping", c => new Ping().RunAsync(c));
        });
    })
    .Build().Run();

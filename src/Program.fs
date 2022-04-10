open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

#nowarn "20"

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)

    // needed for F# since Razor is C#-specific
    builder.Services.AddRazorPages().AddRazorRuntimeCompilation()

    let app = builder.Build()

    app.UseHttpsRedirection()
       .UseStaticFiles()
       .UseRouting()
       .UseAuthorization()
    app.MapRazorPages()

    app.Run()

    0 // Exit code
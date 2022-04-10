open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

#nowarn "20"

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)
    let app = builder.Build()

    app.MapGet("/", Func<string>(fun () -> "Hello World!"))

    app.Run()

    0 // Exit code
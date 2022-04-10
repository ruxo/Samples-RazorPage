namespace RZ.Sample.RazorPage.Pages

open Microsoft.AspNetCore.Mvc.RazorPages
open Microsoft.Extensions.Logging

type IndexModel(logger: ILogger<IndexModel>) =
    inherit PageModel()

    member _.OnGet() =
        logger.LogInformation("Home page is visited!")
# ASP.NET Razor Page with F# and .NET 6

This is a code sample to show how to use F# with ASP.NET 6 Razor Pages, 
though with _some limitations_.

## Limitations

* CSS Isolation does not work in runtime. Oddly it works while debugging,
  but by working means it just bundles into a CSS file. It does not rewrite
  Razor component anyway.
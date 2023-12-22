// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
return await Bootstrapper
  .Factory
  .CreateDocs(args)
  .RunAsync();
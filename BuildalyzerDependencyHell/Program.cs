// See https://aka.ms/new-console-template for more information

using Buildalyzer;

var manager = new AnalyzerManager();
var analyzer = manager.GetProject(@"..\..\..\BuildalyzerDependencyHell.csproj");
var results = analyzer.Build();

foreach (var result in results)
{
    foreach (var sourceFile in result.SourceFiles)
    {
        Console.WriteLine(sourceFile);
    }
}

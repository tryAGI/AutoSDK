using AutoSDK.Benchmarks;
using BenchmarkDotNet.Running;

if (args.Length > 0 && args[0] == "--profile")
{
    var benchmarks = new DataPrepareBenchmarks();
    benchmarks.Setup();

    var specs = new (string Name, Func<AutoSDK.Models.Data> Run)[]
    {
        ("Petstore", benchmarks.Petstore),
        ("AssemblyAI", benchmarks.AssemblyAI),
        ("Cohere", benchmarks.Cohere),
        ("Vectara", benchmarks.Vectara),
        ("OpenAI", benchmarks.OpenAI),
        ("ElevenLabs", benchmarks.ElevenLabs),
    };

    Console.WriteLine("{0,-14} {1,8} {2,8} {3,8} {4,8} {5,8} {6,8} {7,8}  {8,7}  {9,7}",
        "Spec", "Tree", "Naming", "Resolve", "Filter", "Data", "Classes", "Total", "Schemas", "Filtered");
    Console.WriteLine(new string('-', 110));

    foreach (var (name, run) in specs)
    {
        var data = run();
        var t = data.Times;
        Console.WriteLine("{0,-14} {1,7:F0}ms {2,7:F0}ms {3,7:F0}ms {4,7:F0}ms {5,7:F0}ms {6,7:F0}ms {7,7:F0}ms  {8,7}  {9,7}",
            name,
            t.TraversalTree.TotalMilliseconds,
            t.Naming.TotalMilliseconds,
            t.ResolveReferences.TotalMilliseconds,
            t.Filtering.TotalMilliseconds,
            t.ComputeData.TotalMilliseconds,
            t.ComputeDataClasses.TotalMilliseconds,
            t.Total.TotalMilliseconds,
            data.Schemas.Count,
            data.FilteredSchemas.Count);
    }
}
else
{
    BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}

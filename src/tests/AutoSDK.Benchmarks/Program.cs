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

    // Timing header
    Console.WriteLine("{0,-14} {1,8} {2,8} {3,8} {4,8} {5,8} {6,8} {7,8} {8,8}  {9,7}  {10,7}  {11,8}  {12,5}  {13,5}  {14,5}",
        "Spec", "Parse", "Tree", "Naming", "Resolve", "Filter", "Data", "Classes", "Total", "Schemas", "Filtered", "AllocMB", "Gen0", "Gen1", "Gen2");
    Console.WriteLine(new string('-', 160));

    var allData = new List<(string Name, AutoSDK.Models.Data Data, double AllocMB, int Gen0, int Gen1, int Gen2)>();

    foreach (var (name, run) in specs)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        var gen0Before = GC.CollectionCount(0);
        var gen1Before = GC.CollectionCount(1);
        var gen2Before = GC.CollectionCount(2);
        var allocBefore = GC.GetTotalAllocatedBytes(precise: true);

        var data = run();

        var allocAfter = GC.GetTotalAllocatedBytes(precise: true);
        var allocMB = (allocAfter - allocBefore) / (1024.0 * 1024.0);
        var gen0 = GC.CollectionCount(0) - gen0Before;
        var gen1 = GC.CollectionCount(1) - gen1Before;
        var gen2 = GC.CollectionCount(2) - gen2Before;

        allData.Add((name, data, allocMB, gen0, gen1, gen2));

        var t = data.Times;
        Console.WriteLine("{0,-14} {1,7:F0}ms {2,7:F0}ms {3,7:F0}ms {4,7:F0}ms {5,7:F0}ms {6,7:F0}ms {7,7:F0}ms {8,7:F0}ms  {9,7}  {10,7}  {11,7:F0}MB  {12,5}  {13,5}  {14,5}",
            name,
            t.Parsing.TotalMilliseconds,
            t.TraversalTree.TotalMilliseconds,
            t.Naming.TotalMilliseconds,
            t.ResolveReferences.TotalMilliseconds,
            t.Filtering.TotalMilliseconds,
            t.ComputeData.TotalMilliseconds,
            t.ComputeDataClasses.TotalMilliseconds,
            t.Total.TotalMilliseconds,
            data.Schemas.Count,
            data.FilteredSchemas.Count,
            allocMB,
            gen0,
            gen1,
            gen2);
    }

    // Per-phase allocation breakdown
    Console.WriteLine();
    Console.WriteLine("Per-phase allocation (MB):");
    Console.WriteLine("{0,-14} {1,10} {2,10} {3,10} {4,10} {5,10} {6,10} {7,10}",
        "Spec", "Parse", "Tree", "Naming", "Resolve", "Filter", "Data", "Classes");
    Console.WriteLine(new string('-', 95));
    foreach (var (name, data, _, _, _, _) in allData)
    {
        var t = data.Times;
        Console.WriteLine("{0,-14} {1,9:F1}M {2,9:F1}M {3,9:F1}M {4,9:F1}M {5,9:F1}M {6,9:F1}M {7,9:F1}M",
            name,
            t.AllocParsing / (1024.0 * 1024.0),
            t.AllocTraversalTree / (1024.0 * 1024.0),
            t.AllocNaming / (1024.0 * 1024.0),
            t.AllocResolveReferences / (1024.0 * 1024.0),
            t.AllocFiltering / (1024.0 * 1024.0),
            t.AllocComputeData / (1024.0 * 1024.0),
            t.AllocComputeDataClasses / (1024.0 * 1024.0));
    }
}
else
{
    BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}

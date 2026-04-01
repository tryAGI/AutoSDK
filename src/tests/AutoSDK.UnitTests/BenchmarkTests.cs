using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

/// <summary>
/// Independent benchmark tests — each can be run standalone via --filter for fast verification.
/// Example: dotnet test src/tests/AutoSDK.UnitTests/AutoSDK.UnitTests.csproj -p:RunUnitBenchmarks=true --filter "FullyQualifiedName~BenchmarkTests.Timing_ElevenLabs"
/// Run all: dotnet test src/tests/AutoSDK.UnitTests/AutoSDK.UnitTests.csproj -p:RunUnitBenchmarks=true --filter "TestCategory=Benchmark"
///
/// Baseline (2026-03-21, net10.0, Apple Silicon):
///   ElevenLabs: 587ms / 306MB (11,820 schemas) [was 397MB]
///   OpenAI:     368ms / 148MB  (4,933 schemas) [was 170MB]
///   GitHub:    1497ms / 961MB (42,052 schemas) [was 1086MB]
/// </summary>
[TestClass]
[DoNotParallelize]
public class BenchmarkTests
{
    private static Settings BenchmarkSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
        GenerateJsonSerializerContextTypes = true,
        IgnoreOpenApiErrors = true,
    };

    #region Per-spec timing benchmarks

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_ElevenLabs() => RunTimingBenchmark("elevenlabs.json");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_OpenAI() => RunTimingBenchmark("openai.yaml");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_GitHub() => RunTimingBenchmark("github.yaml");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_Anthropic() => RunTimingBenchmark("anthropic.yaml");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_Mistral() => RunTimingBenchmark("mistral.yaml");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Timing_Cohere() => RunTimingBenchmark("cohere.yaml");

    #endregion

    #region Per-spec allocation benchmarks

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Allocation_ElevenLabs() => RunAllocationBenchmark("elevenlabs.json");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Allocation_OpenAI() => RunAllocationBenchmark("openai.yaml");

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Allocation_GitHub() => RunAllocationBenchmark("github.yaml");

    #endregion

    #region Per-phase benchmarks (isolate hotspots)

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Phase_Parsing()
    {
        var specs = new[] { "elevenlabs.json", "openai.yaml", "github.yaml" };
        Console.WriteLine("=== Parsing Phase Benchmark ===");
        foreach (var spec in specs)
        {
            // Warm up
            PrepareData(spec);
            // Measure
            var data = PrepareData(spec);
            Console.WriteLine($"  {spec,-20} {data.Times.Parsing.TotalMilliseconds,7:F0}ms  {data.Times.AllocParsing / (1024.0 * 1024.0),7:F1}MB");
        }
    }

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Phase_TraversalTree()
    {
        var specs = new[] { "elevenlabs.json", "openai.yaml", "github.yaml" };
        Console.WriteLine("=== TraversalTree Phase Benchmark ===");
        foreach (var spec in specs)
        {
            PrepareData(spec);
            var data = PrepareData(spec);
            Console.WriteLine($"  {spec,-20} {data.Times.TraversalTree.TotalMilliseconds,7:F0}ms  {data.Times.AllocTraversalTree / (1024.0 * 1024.0),7:F1}MB");
        }
    }

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Phase_Naming()
    {
        var specs = new[] { "elevenlabs.json", "openai.yaml", "github.yaml" };
        Console.WriteLine("=== Naming Phase Benchmark ===");
        foreach (var spec in specs)
        {
            PrepareData(spec);
            var data = PrepareData(spec);
            Console.WriteLine($"  {spec,-20} {data.Times.Naming.TotalMilliseconds,7:F0}ms  {data.Times.AllocNaming / (1024.0 * 1024.0),7:F1}MB");
        }
    }

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Phase_ComputeData()
    {
        var specs = new[] { "elevenlabs.json", "openai.yaml", "github.yaml" };
        Console.WriteLine("=== ComputeData Phase Benchmark ===");
        foreach (var spec in specs)
        {
            PrepareData(spec);
            var data = PrepareData(spec);
            Console.WriteLine($"  {spec,-20} {data.Times.ComputeData.TotalMilliseconds,7:F0}ms  {data.Times.AllocComputeData / (1024.0 * 1024.0),7:F1}MB");
        }
    }

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Phase_Filtering()
    {
        var specs = new[] { "elevenlabs.json", "openai.yaml", "github.yaml" };
        Console.WriteLine("=== Filtering Phase Benchmark ===");
        foreach (var spec in specs)
        {
            PrepareData(spec);
            var data = PrepareData(spec);
            Console.WriteLine($"  {spec,-20} {data.Times.Filtering.TotalMilliseconds,7:F0}ms  {data.Times.AllocFiltering / (1024.0 * 1024.0),7:F1}MB");
        }
    }

    #endregion

    #region Multi-iteration stability benchmarks

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Stability_ElevenLabs()
    {
        RunStabilityBenchmark("elevenlabs.json", iterations: 5);
    }

    [TestMethod]
    [TestCategory("Benchmark")]
    public void Stability_OpenAI()
    {
        RunStabilityBenchmark("openai.yaml", iterations: 5);
    }

    #endregion

    #region Helpers

    private static AutoSDK.Models.Data PrepareData(string resourceName)
    {
        var settings = BenchmarkSettings;
        return AutoSDK.Generation.Data.Prepare(((TestSpecCache.GetText(resourceName), settings), GlobalSettings: settings));
    }

    private static void RunTimingBenchmark(string resourceName)
    {
        // Warm up
        PrepareData(resourceName);

        // Measure
        var data = PrepareData(resourceName);
        var t = data.Times;

        Console.WriteLine($"=== {resourceName} Timing (warm) ===");
        Console.WriteLine($"  Parse:   {t.Parsing.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Tree:    {t.TraversalTree.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Naming:  {t.Naming.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Resolve: {t.ResolveReferences.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Filter:  {t.Filtering.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Data:    {t.ComputeData.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Classes: {t.ComputeDataClasses.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  TOTAL:   {t.Total.TotalMilliseconds,7:F0}ms");
        Console.WriteLine($"  Schemas: {data.Schemas.Count}  Filtered: {data.FilteredSchemas.Count}");
        Console.WriteLine($"  Classes: {data.Classes.Length}  Enums: {data.Enums.Length}  Methods: {data.Methods.Length}");
    }

    private static void RunAllocationBenchmark(string resourceName)
    {
        // Warm up
        PrepareData(resourceName);

        // Measure
        var data = PrepareData(resourceName);
        var t = data.Times;

        var totalAllocMB = (t.AllocParsing + t.AllocTraversalTree + t.AllocNaming +
            t.AllocResolveReferences + t.AllocFiltering + t.AllocComputeData +
            t.AllocComputeDataClasses) / (1024.0 * 1024.0);

        Console.WriteLine($"=== {resourceName} Allocations (warm) ===");
        Console.WriteLine($"  Parse:   {t.AllocParsing / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Tree:    {t.AllocTraversalTree / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Naming:  {t.AllocNaming / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Resolve: {t.AllocResolveReferences / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Filter:  {t.AllocFiltering / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Data:    {t.AllocComputeData / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  Classes: {t.AllocComputeDataClasses / (1024.0 * 1024.0),7:F1}MB");
        Console.WriteLine($"  TOTAL:   {totalAllocMB,7:F1}MB");
    }

    private static void RunStabilityBenchmark(string resourceName, int iterations)
    {
        // Warm up
        PrepareData(resourceName);

        var timings = new double[iterations];
        var allocs = new double[iterations];
        for (var i = 0; i < iterations; i++)
        {
            var data = PrepareData(resourceName);
            var t = data.Times;
            timings[i] = t.Total.TotalMilliseconds;
            allocs[i] = (t.AllocParsing + t.AllocTraversalTree + t.AllocNaming +
                t.AllocResolveReferences + t.AllocFiltering + t.AllocComputeData +
                t.AllocComputeDataClasses) / (1024.0 * 1024.0);
        }

        var avgMs = timings.Sum() / iterations;
        var minMs = timings.Min();
        var maxMs = timings.Max();
        var avgMB = allocs.Sum() / iterations;

        Console.WriteLine($"=== {resourceName} Stability ({iterations} iterations) ===");
        for (var i = 0; i < iterations; i++)
        {
            Console.WriteLine($"  Run {i + 1}: {timings[i],7:F0}ms  {allocs[i],7:F1}MB");
        }
        Console.WriteLine($"  Avg:  {avgMs,7:F0}ms  {avgMB,7:F1}MB");
        Console.WriteLine($"  Min:  {minMs,7:F0}ms   Max: {maxMs,7:F0}ms");
    }

    #endregion
}

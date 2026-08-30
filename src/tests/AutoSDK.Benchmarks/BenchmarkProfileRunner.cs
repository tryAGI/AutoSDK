using System.Diagnostics;
using System.Text;
using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.Benchmarks;

internal static class BenchmarkProfileRunner
{
    public static void Run()
    {
        var fixture = new BenchmarkFixture();
        fixture.Setup();

        var profiles = fixture.LargeSpecs
            .Select(specName => ProfileSpec(fixture, specName, iterations: 3))
            .ToArray();

        Console.WriteLine("Split pipeline timing (average of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,8} {2,8} {3,8} {4,8} {5,8} {6,8} {7,8} {8,8} {9,8} {10,8} {11,8} {12,7}",
            "Spec", "Parse", "Tree", "Naming", "Resolve", "Filter", "Core", "Data", "Classes", "C#Other", "Emit", "Total", "Files");
        Console.WriteLine(new string('-', 140));

        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,7:F0}ms {2,7:F0}ms {3,7:F0}ms {4,7:F0}ms {5,7:F0}ms {6,7:F0}ms {7,7:F0}ms {8,7:F0}ms {9,7:F0}ms {10,7:F0}ms {11,7:F0}ms {12,7}",
                profile.Name,
                profile.ParseMs,
                profile.TreeMs,
                profile.NamingMs,
                profile.ResolveMs,
                profile.FilterMs,
                profile.CoreMs,
                profile.ComputeDataMs,
                profile.ComputeDataClassesMs,
                profile.CSharpOtherMs,
                profile.EmitMs,
                profile.TotalMs,
                profile.FileCount);
        }

        Console.WriteLine();
        Console.WriteLine("OpenAPI parsing detail (average of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,10} {2,10} {3,10} {4,10} {5,10} {6,11} {7,11} {8,11} {9,11} {10,11}",
            "Spec", "JSON", "Normalize", "MSReader", "Walker", "Post", "JSON MB", "Norm MB", "Reader MB", "Walker MB", "Post MB");
        Console.WriteLine(new string('-', 135));

        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,9:F1}ms {2,9:F1}ms {3,9:F1}ms {4,9:F1}ms {5,9:F1}ms {6,10:F1} {7,10:F1} {8,10:F1} {9,10:F1} {10,10:F1}",
                profile.Name,
                profile.JsonSyntaxMs,
                profile.CompatibilityNormalizationMs,
                profile.MicrosoftReaderMs,
                profile.CompatibilityWalkerMs,
                profile.PostProcessingMs,
                profile.JsonSyntaxAllocMb,
                profile.CompatibilityNormalizationAllocMb,
                profile.MicrosoftReaderAllocMb,
                profile.CompatibilityWalkerAllocMb,
                profile.PostProcessingAllocMb);
        }

        Console.WriteLine();
        Console.WriteLine("OpenAPI post-processing detail (average of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,10} {2,10} {3,10} {4,10} {5,10} {6,11} {7,11} {8,11} {9,11} {10,11}",
            "Spec", "Setup", "Discrim", "PathParams", "Overrides", "Sanitize", "Setup MB", "Discrim MB", "Path MB", "Over MB", "San MB");
        Console.WriteLine(new string('-', 135));

        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,9:F1}ms {2,9:F1}ms {3,9:F1}ms {4,9:F1}ms {5,9:F1}ms {6,10:F1} {7,10:F1} {8,10:F1} {9,10:F1} {10,10:F1}",
                profile.Name,
                profile.PostSetupAndInjectionMs,
                profile.PostDiscriminatorsMs,
                profile.PostMissingPathParametersMs,
                profile.PostOverridesAndNamingMs,
                profile.PostSchemaSanitizersMs,
                profile.PostSetupAndInjectionAllocMb,
                profile.PostDiscriminatorsAllocMb,
                profile.PostMissingPathParametersAllocMb,
                profile.PostOverridesAndNamingAllocMb,
                profile.PostSchemaSanitizersAllocMb);
        }

        Console.WriteLine();
        Console.WriteLine("Allocations and output (average of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,10} {2,10} {3,10} {4,10} {5,8} {6,8} {7,8} {8,8} {9,8} {10,10}",
            "Spec", "CoreMB", "CSharpMB", "EmitMB", "TotalMB", "Schemas", "Filtered", "Classes", "Enums", "Methods", "SourceMB");
        Console.WriteLine(new string('-', 120));

        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,9:F1} {2,9:F1} {3,9:F1} {4,9:F1} {5,8} {6,8} {7,8} {8,8} {9,8} {10,9:F1}",
                profile.Name,
                profile.CoreAllocMb,
                profile.CSharpAllocMb,
                profile.EmitAllocMb,
                profile.TotalAllocMb,
                profile.SchemaCount,
                profile.FilteredSchemaCount,
                profile.ClassCount,
                profile.EnumCount,
                profile.MethodCount,
                profile.SourceMb);
        }
    }

    private static SpecProfile ProfileSpec(BenchmarkFixture fixture, string specName, int iterations)
    {
        Warmup(fixture, specName);

        var parseMs = 0.0;
        var treeMs = 0.0;
        var namingMs = 0.0;
        var resolveMs = 0.0;
        var filterMs = 0.0;
        var coreMs = 0.0;
        var computeDataMs = 0.0;
        var computeDataClassesMs = 0.0;
        var csharpOtherMs = 0.0;
        var emitMs = 0.0;
        var coreAllocMb = 0.0;
        var csharpAllocMb = 0.0;
        var emitAllocMb = 0.0;
        var jsonSyntaxMs = 0.0;
        var compatibilityNormalizationMs = 0.0;
        var microsoftReaderMs = 0.0;
        var compatibilityWalkerMs = 0.0;
        var postProcessingMs = 0.0;
        var jsonSyntaxAllocMb = 0.0;
        var compatibilityNormalizationAllocMb = 0.0;
        var microsoftReaderAllocMb = 0.0;
        var compatibilityWalkerAllocMb = 0.0;
        var postProcessingAllocMb = 0.0;
        var postSetupAndInjectionMs = 0.0;
        var postDiscriminatorsMs = 0.0;
        var postMissingPathParametersMs = 0.0;
        var postOverridesAndNamingMs = 0.0;
        var postSchemaSanitizersMs = 0.0;
        var postSetupAndInjectionAllocMb = 0.0;
        var postDiscriminatorsAllocMb = 0.0;
        var postMissingPathParametersAllocMb = 0.0;
        var postOverridesAndNamingAllocMb = 0.0;
        var postSchemaSanitizersAllocMb = 0.0;

        var schemaCount = 0;
        var filteredSchemaCount = 0;
        var classCount = 0;
        var enumCount = 0;
        var methodCount = 0;
        var fileCount = 0;
        var sourceMb = 0.0;

        for (var i = 0; i < iterations; i++)
        {
            var coreStage = Measure(() => fixture.PrepareCore(specName));
            var core = coreStage.Result;
            var coreTimes = core.Times;

            parseMs += coreTimes.Parsing.TotalMilliseconds;
            treeMs += coreTimes.TraversalTree.TotalMilliseconds;
            namingMs += coreTimes.Naming.TotalMilliseconds;
            resolveMs += coreTimes.ResolveReferences.TotalMilliseconds;
            filterMs += coreTimes.Filtering.TotalMilliseconds;
            coreMs += coreStage.Elapsed.TotalMilliseconds;
            coreAllocMb += BytesToMb(coreStage.AllocBytes);
            jsonSyntaxMs += coreTimes.OpenApiParsing.JsonSyntax.TotalMilliseconds;
            compatibilityNormalizationMs += coreTimes.OpenApiParsing.CompatibilityNormalization.TotalMilliseconds;
            microsoftReaderMs += coreTimes.OpenApiParsing.MicrosoftReader.TotalMilliseconds;
            compatibilityWalkerMs += coreTimes.OpenApiParsing.CompatibilityWalker.TotalMilliseconds;
            postProcessingMs += coreTimes.OpenApiParsing.PostProcessing.TotalMilliseconds;
            jsonSyntaxAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocJsonSyntax);
            compatibilityNormalizationAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocCompatibilityNormalization);
            microsoftReaderAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocMicrosoftReader);
            compatibilityWalkerAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocCompatibilityWalker);
            postProcessingAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostProcessing);
            postSetupAndInjectionMs += coreTimes.OpenApiParsing.PostSetupAndInjection.TotalMilliseconds;
            postDiscriminatorsMs += coreTimes.OpenApiParsing.PostDiscriminators.TotalMilliseconds;
            postMissingPathParametersMs += coreTimes.OpenApiParsing.PostMissingPathParameters.TotalMilliseconds;
            postOverridesAndNamingMs += coreTimes.OpenApiParsing.PostOverridesAndNaming.TotalMilliseconds;
            postSchemaSanitizersMs += coreTimes.OpenApiParsing.PostSchemaSanitizers.TotalMilliseconds;
            postSetupAndInjectionAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostSetupAndInjection);
            postDiscriminatorsAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostDiscriminators);
            postMissingPathParametersAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostMissingPathParameters);
            postOverridesAndNamingAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostOverridesAndNaming);
            postSchemaSanitizersAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostSchemaSanitizers);

            var enrichStage = Measure(() => CSharpPipeline.Enrich(core));
            var data = enrichStage.Result;
            var enrichTimes = data.Times;

            computeDataMs += enrichTimes.ComputeData.TotalMilliseconds;
            computeDataClassesMs += enrichTimes.ComputeDataClasses.TotalMilliseconds;
            csharpOtherMs += Math.Max(
                0,
                enrichStage.Elapsed.TotalMilliseconds
                - enrichTimes.ComputeData.TotalMilliseconds
                - enrichTimes.ComputeDataClasses.TotalMilliseconds);
            csharpAllocMb += BytesToMb(enrichStage.AllocBytes);

            var emitStage = Measure(() => CSharpPipeline.GenerateFiles(data));
            var files = emitStage.Result;

            emitMs += emitStage.Elapsed.TotalMilliseconds;
            emitAllocMb += BytesToMb(emitStage.AllocBytes);

            schemaCount = data.Schemas.Count;
            filteredSchemaCount = data.FilteredSchemas.Count;
            classCount = data.Classes.Length;
            enumCount = data.Enums.Length;
            methodCount = data.Methods.Length;
            fileCount = files.Count;
            sourceMb = BytesToMb(SumFileBytes(files));
        }

        return new SpecProfile(
            Name: specName,
            ParseMs: parseMs / iterations,
            TreeMs: treeMs / iterations,
            NamingMs: namingMs / iterations,
            ResolveMs: resolveMs / iterations,
            FilterMs: filterMs / iterations,
            CoreMs: coreMs / iterations,
            ComputeDataMs: computeDataMs / iterations,
            ComputeDataClassesMs: computeDataClassesMs / iterations,
            CSharpOtherMs: csharpOtherMs / iterations,
            EmitMs: emitMs / iterations,
            TotalMs: (coreMs + (computeDataMs + computeDataClassesMs + csharpOtherMs) + emitMs) / iterations,
            CoreAllocMb: coreAllocMb / iterations,
            CSharpAllocMb: csharpAllocMb / iterations,
            EmitAllocMb: emitAllocMb / iterations,
            TotalAllocMb: (coreAllocMb + csharpAllocMb + emitAllocMb) / iterations,
            JsonSyntaxMs: jsonSyntaxMs / iterations,
            CompatibilityNormalizationMs: compatibilityNormalizationMs / iterations,
            MicrosoftReaderMs: microsoftReaderMs / iterations,
            CompatibilityWalkerMs: compatibilityWalkerMs / iterations,
            PostProcessingMs: postProcessingMs / iterations,
            JsonSyntaxAllocMb: jsonSyntaxAllocMb / iterations,
            CompatibilityNormalizationAllocMb: compatibilityNormalizationAllocMb / iterations,
            MicrosoftReaderAllocMb: microsoftReaderAllocMb / iterations,
            CompatibilityWalkerAllocMb: compatibilityWalkerAllocMb / iterations,
            PostProcessingAllocMb: postProcessingAllocMb / iterations,
            PostSetupAndInjectionMs: postSetupAndInjectionMs / iterations,
            PostDiscriminatorsMs: postDiscriminatorsMs / iterations,
            PostMissingPathParametersMs: postMissingPathParametersMs / iterations,
            PostOverridesAndNamingMs: postOverridesAndNamingMs / iterations,
            PostSchemaSanitizersMs: postSchemaSanitizersMs / iterations,
            PostSetupAndInjectionAllocMb: postSetupAndInjectionAllocMb / iterations,
            PostDiscriminatorsAllocMb: postDiscriminatorsAllocMb / iterations,
            PostMissingPathParametersAllocMb: postMissingPathParametersAllocMb / iterations,
            PostOverridesAndNamingAllocMb: postOverridesAndNamingAllocMb / iterations,
            PostSchemaSanitizersAllocMb: postSchemaSanitizersAllocMb / iterations,
            SchemaCount: schemaCount,
            FilteredSchemaCount: filteredSchemaCount,
            ClassCount: classCount,
            EnumCount: enumCount,
            MethodCount: methodCount,
            FileCount: fileCount,
            SourceMb: sourceMb);
    }

    private static void Warmup(BenchmarkFixture fixture, string specName)
    {
        var core = fixture.PrepareCore(specName);
        var data = CSharpPipeline.Enrich(core);
        _ = CSharpPipeline.GenerateFiles(data);
    }

    private static Measured<T> Measure<T>(Func<T> action)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        var allocBefore = GC.GetTotalAllocatedBytes(precise: true);
        var stopwatch = Stopwatch.StartNew();
        var result = action();
        stopwatch.Stop();
        var allocAfter = GC.GetTotalAllocatedBytes(precise: true);

        return new Measured<T>(
            Result: result,
            Elapsed: stopwatch.Elapsed,
            AllocBytes: allocAfter - allocBefore);
    }

    private static long SumFileBytes(IReadOnlyList<FileWithName> files)
    {
        long total = 0;
        for (var i = 0; i < files.Count; i++)
        {
            total += Encoding.UTF8.GetByteCount(files[i].Text);
        }

        return total;
    }

    private static double BytesToMb(long bytes)
    {
        return bytes / (1024.0 * 1024.0);
    }

    private readonly record struct Measured<T>(
        T Result,
        TimeSpan Elapsed,
        long AllocBytes);

    private readonly record struct SpecProfile(
        string Name,
        double ParseMs,
        double TreeMs,
        double NamingMs,
        double ResolveMs,
        double FilterMs,
        double CoreMs,
        double ComputeDataMs,
        double ComputeDataClassesMs,
        double CSharpOtherMs,
        double EmitMs,
        double TotalMs,
        double CoreAllocMb,
        double CSharpAllocMb,
        double EmitAllocMb,
        double TotalAllocMb,
        double JsonSyntaxMs,
        double CompatibilityNormalizationMs,
        double MicrosoftReaderMs,
        double CompatibilityWalkerMs,
        double PostProcessingMs,
        double JsonSyntaxAllocMb,
        double CompatibilityNormalizationAllocMb,
        double MicrosoftReaderAllocMb,
        double CompatibilityWalkerAllocMb,
        double PostProcessingAllocMb,
        double PostSetupAndInjectionMs,
        double PostDiscriminatorsMs,
        double PostMissingPathParametersMs,
        double PostOverridesAndNamingMs,
        double PostSchemaSanitizersMs,
        double PostSetupAndInjectionAllocMb,
        double PostDiscriminatorsAllocMb,
        double PostMissingPathParametersAllocMb,
        double PostOverridesAndNamingAllocMb,
        double PostSchemaSanitizersAllocMb,
        int SchemaCount,
        int FilteredSchemaCount,
        int ClassCount,
        int EnumCount,
        int MethodCount,
        int FileCount,
        double SourceMb);
}

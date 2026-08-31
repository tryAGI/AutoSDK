using System.Diagnostics;
using System.Text;
using AutoSDK.Enrichment;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.Naming.Properties;
using AutoSDK.TypeMapping;

namespace AutoSDK.Benchmarks;

internal static class BenchmarkProfileRunner
{
    public static void RunModelNaming()
    {
        var fixture = new BenchmarkFixture();
        fixture.Setup();

        Console.WriteLine("Model naming detail (single diagnostic run):");
        Console.WriteLine("Spec              ClassMs   ClassMB SanitizeMs SanitizeMB CollisionMs CollisionMB  Models");
        Console.WriteLine(new string('-', 105));
        foreach (var specName in fixture.LargeSpecs)
        {
            var classElapsed = TimeSpan.Zero;
            var sanitizeElapsed = TimeSpan.Zero;
            var collisionElapsed = TimeSpan.Zero;
            long classBytes = 0;
            long sanitizeBytes = 0;
            long collisionBytes = 0;
            var modelCount = 0;
            _ = fixture.PrepareCore(specName, schemas =>
            {
                var stopwatch = new Stopwatch();
                for (var index = 0; index < schemas.Count; index++)
                {
                    if (schemas[index].IsModel)
                    {
                        var before = GC.GetAllocatedBytesForCurrentThread();
                        stopwatch.Restart();
                        var className = schemas[index].ComputeClassName();
                        stopwatch.Stop();
                        classElapsed += stopwatch.Elapsed;
                        classBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                        before = GC.GetAllocatedBytesForCurrentThread();
                        stopwatch.Restart();
                        className = CSharpPropertyNameGenerator.SanitizeName(
                            className,
                            schemas[index].Settings.ClsCompliantEnumPrefix,
                            identifierCharacterSet: schemas[index].Settings.IdentifierCharacterSet);
                        schemas[index].ClassName = className;
                        schemas[index].Id = className;
                        stopwatch.Stop();
                        sanitizeElapsed += stopwatch.Elapsed;
                        sanitizeBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                        modelCount++;
                    }
                }

                var collisionBefore = GC.GetAllocatedBytesForCurrentThread();
                stopwatch.Restart();
                ModelNameGenerator.ResolveCollisions(schemas);
                stopwatch.Stop();
                collisionElapsed = stopwatch.Elapsed;
                collisionBytes = GC.GetAllocatedBytesForCurrentThread() - collisionBefore;
            });

            Console.WriteLine(
                "{0,-12} {1,9:F1} {2,9:F1} {3,10:F1} {4,10:F1} {5,11:F1} {6,11:F1} {7,7}",
                specName,
                classElapsed.TotalMilliseconds,
                BytesToMb(classBytes),
                sanitizeElapsed.TotalMilliseconds,
                BytesToMb(sanitizeBytes),
                collisionElapsed.TotalMilliseconds,
                BytesToMb(collisionBytes),
                modelCount);
        }
    }

    public static void RunDataComputation()
    {
        var fixture = new BenchmarkFixture();
        fixture.Setup();

        Console.WriteLine("ComputeData factory allocation detail (single diagnostic run):");
        Console.WriteLine("Spec            TotalMB     TypeMB    ModelMB PropertyMB   ParamMB   AnyOfMB  TypeCalls PropCalls");
        Console.WriteLine(new string('-', 112));

        foreach (var specName in fixture.LargeSpecs)
        {
            var core = fixture.PrepareCore(specName);
            long typeBytes = 0;
            long modelBytes = 0;
            long propertyBytes = 0;
            long parameterBytes = 0;
            long anyOfBytes = 0;
            var typeCalls = 0;
            var propertyCalls = 0;

            ModelData CreateModelData(SchemaContext context)
            {
                var before = GC.GetAllocatedBytesForCurrentThread();
                var result = CSharpModelDataFactory.CreateModelData(context);
                modelBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                return result;
            }

            TypeData CreateTypeData(SchemaContext context)
            {
                var before = GC.GetAllocatedBytesForCurrentThread();
                var result = CSharpTypeMapper.CreateTypeData(context);
                typeBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                typeCalls++;
                return result;
            }

            PropertyData CreatePropertyData(SchemaContext context)
            {
                var before = GC.GetAllocatedBytesForCurrentThread();
                var result = CSharpSchemaDataFactory.CreatePropertyData(context);
                propertyBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                propertyCalls++;
                return result;
            }

            MethodParameter CreateParameterData(SchemaContext context)
            {
                var before = GC.GetAllocatedBytesForCurrentThread();
                var result = CSharpSchemaDataFactory.CreateMethodParameter(context);
                parameterBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                return result;
            }

            AnyOfData CreateAnyOfData(SchemaContext context)
            {
                var before = GC.GetAllocatedBytesForCurrentThread();
                var result = CSharpSchemaDataFactory.CreateAnyOfData(context);
                anyOfBytes += GC.GetAllocatedBytesForCurrentThread() - before;
                return result;
            }

            var measured = Measure(() =>
            {
                var sharedVisited = new HashSet<SchemaContext>();
                foreach (var schema in core.FilteredSchemas)
                {
                    sharedVisited.Clear();
                    schema.ComputeData(
                        CreateModelData,
                        CreateTypeData,
                        static type => type.WithCSharpComputedValues(),
                        CSharpTypeMapper.GetCSharpType,
                        CSharpTypeMapper.GetCSharpNullability,
                        CreatePropertyData,
                        CreateParameterData,
                        CreateAnyOfData,
                        visited: sharedVisited);
                }

                foreach (var schema in core.FilteredSchemas)
                {
                    schema.RecomputeDataIfNeeded(
                        CreateModelData,
                        CreateTypeData,
                        static type => type.WithCSharpComputedValues(),
                        CSharpTypeMapper.GetCSharpType,
                        CSharpTypeMapper.GetCSharpNullability,
                        CreatePropertyData,
                        CreateParameterData,
                        CreateAnyOfData);
                }

                return 0;
            });

            Console.WriteLine(
                "{0,-12} {1,9:F1} {2,10:F1} {3,10:F1} {4,10:F1} {5,9:F1} {6,9:F1} {7,10} {8,9}",
                specName,
                BytesToMb(measured.AllocBytes),
                BytesToMb(typeBytes),
                BytesToMb(modelBytes),
                BytesToMb(propertyBytes),
                BytesToMb(parameterBytes),
                BytesToMb(anyOfBytes),
                typeCalls,
                propertyCalls);

            long propertyNameBytes = 0;
            long defaultValueBytes = 0;
            long exampleBytes = 0;
            long summaryBytes = 0;
            long parameterNameBytes = 0;
            long metadataBytes = 0;
            var distinctPropertyCount = 0;
            foreach (var schema in core.FilteredSchemas)
            {
                if (!schema.IsProperty)
                {
                    continue;
                }
                distinctPropertyCount++;

                var before = GC.GetAllocatedBytesForCurrentThread();
                var name = CSharpPropertyNameGenerator.ComputePropertyName(schema);
                propertyNameBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                before = GC.GetAllocatedBytesForCurrentThread();
                _ = schema.GetDefaultValue();
                defaultValueBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                before = GC.GetAllocatedBytesForCurrentThread();
                var example = schema.Schema.GetLegacyExample()?.GetString();
                if (!string.IsNullOrWhiteSpace(example))
                {
                    _ = example.ClearForXml();
                }
                exampleBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                before = GC.GetAllocatedBytesForCurrentThread();
                _ = schema.Schema.GetSummary();
                summaryBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                before = GC.GetAllocatedBytesForCurrentThread();
                _ = (PropertyData.Default with { Name = name }).WithCSharpParameterName();
                parameterNameBytes += GC.GetAllocatedBytesForCurrentThread() - before;

                before = GC.GetAllocatedBytesForCurrentThread();
                _ = schema.Schema.IsConst();
                _ = schema.Schema.IsDeprecated();
                _ = schema.Settings.ToEmitterSettings();
                _ = schema.Parent?.Schema.Required?.Contains(schema.PropertyName ?? string.Empty);
                metadataBytes += GC.GetAllocatedBytesForCurrentThread() - before;
            }

            Console.WriteLine(
                "  property ops ({0} distinct): name={1:F1} MB default={2:F1} MB example={3:F1} MB summary={4:F1} MB parameter_name={5:F1} MB metadata={6:F1} MB",
                distinctPropertyCount,
                BytesToMb(propertyNameBytes),
                BytesToMb(defaultValueBytes),
                BytesToMb(exampleBytes),
                BytesToMb(summaryBytes),
                BytesToMb(parameterNameBytes),
                BytesToMb(metadataBytes));
        }
    }

    public static void RunMethodRendering()
    {
        var fixture = new BenchmarkFixture();
        fixture.Setup();

        Console.WriteLine("Method rendering detail (median of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,-14} {2,10} {3,12} {4,12}",
            "Spec", "Stage", "Time", "Alloc MB", "Chars");
        Console.WriteLine(new string('-', 68));

        foreach (var specName in fixture.LargeSpecs)
        {
            var data = fixture.PrepareAndEnrich(specName);
            WriteMethodRenderMeasurement(specName, "endpoint", data.Methods, static endpoint => Sources.GenerateEndPoint(endpoint));
            WriteMethodRenderMeasurement(specName, "method", data.Methods, static endpoint => Sources.GenerateMethod(endpoint));
            WriteMethodRenderMeasurement(specName, "path_query", data.Methods, static endpoint => Sources.GeneratePathAndQuery(endpoint));
            WriteMethodRenderMeasurement(specName, "request", data.Methods, static endpoint => Sources.GenerateRequestData(endpoint));
            WriteMethodRenderMeasurement(specName, "response", data.Methods, static endpoint => Sources.GenerateResponse(endpoint));
            WriteMethodRenderMeasurement(specName, "extension", data.Methods, static endpoint => Sources.GenerateExtensionMethod(endpoint));
        }
    }

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
        Console.WriteLine("OpenAPI schema sanitizer detail (average of 3 measured runs):");
        Console.WriteLine(
            "{0,-12} {1,10} {2,10} {3,10} {4,10} {5,11} {6,11} {7,11} {8,11}",
            "Spec", "Fern", "Numeric", "Int64", "Discrim", "Fern MB", "Numeric MB", "Int64 MB", "Discrim MB");
        Console.WriteLine(new string('-', 112));

        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,9:F1}ms {2,9:F1}ms {3,9:F1}ms {4,9:F1}ms {5,10:F1} {6,10:F1} {7,10:F1} {8,10:F1}",
                profile.Name,
                profile.PostFernTypeNormalizationMs,
                profile.PostNumericConstraintSanitizationMs,
                profile.PostLargeIntegerFormatInferenceMs,
                profile.PostDiscriminatorSanitizationMs,
                profile.PostFernTypeNormalizationAllocMb,
                profile.PostNumericConstraintSanitizationAllocMb,
                profile.PostLargeIntegerFormatInferenceAllocMb,
                profile.PostDiscriminatorSanitizationAllocMb);
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

        Console.WriteLine();
        Console.WriteLine("Core pipeline allocation detail (average of 3 measured runs):");
        Console.WriteLine("Spec              ParseMB    TreeMB  NamingMB ResolveMB  FilterMB   OtherMB");
        Console.WriteLine(new string('-', 82));
        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,10:F1} {2,9:F1} {3,9:F1} {4,9:F1} {5,9:F1} {6,9:F1}",
                profile.Name,
                profile.CoreParsingAllocMb,
                profile.CoreTreeAllocMb,
                profile.CoreNamingAllocMb,
                profile.CoreResolveAllocMb,
                profile.CoreFilterAllocMb,
                profile.CoreOtherAllocMb);
        }

        Console.WriteLine();
        Console.WriteLine("C# enrichment allocation detail (average of 3 measured runs):");
        Console.WriteLine("Spec             NamingMB    DataMB ClassesMB   OtherMB");
        Console.WriteLine(new string('-', 70));
        foreach (var profile in profiles)
        {
            Console.WriteLine(
                "{0,-12} {1,9:F1} {2,9:F1} {3,9:F1} {4,9:F1}",
                profile.Name,
                profile.CSharpNamingAllocMb,
                profile.ComputeDataAllocMb,
                profile.ComputeDataClassesAllocMb,
                profile.CSharpOtherAllocMb);
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
        var coreParsingAllocMb = 0.0;
        var coreTreeAllocMb = 0.0;
        var coreNamingAllocMb = 0.0;
        var coreResolveAllocMb = 0.0;
        var coreFilterAllocMb = 0.0;
        var coreOtherAllocMb = 0.0;
        var csharpAllocMb = 0.0;
        var csharpNamingAllocMb = 0.0;
        var computeDataAllocMb = 0.0;
        var computeDataClassesAllocMb = 0.0;
        var csharpOtherAllocMb = 0.0;
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
        var postFernTypeNormalizationMs = 0.0;
        var postNumericConstraintSanitizationMs = 0.0;
        var postLargeIntegerFormatInferenceMs = 0.0;
        var postDiscriminatorSanitizationMs = 0.0;
        var postFernTypeNormalizationAllocMb = 0.0;
        var postNumericConstraintSanitizationAllocMb = 0.0;
        var postLargeIntegerFormatInferenceAllocMb = 0.0;
        var postDiscriminatorSanitizationAllocMb = 0.0;

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
            coreParsingAllocMb += BytesToMb(coreTimes.AllocParsing);
            coreTreeAllocMb += BytesToMb(coreTimes.AllocTraversalTree);
            coreNamingAllocMb += BytesToMb(coreTimes.AllocNaming);
            coreResolveAllocMb += BytesToMb(coreTimes.AllocResolveReferences);
            coreFilterAllocMb += BytesToMb(coreTimes.AllocFiltering + coreTimes.AllocFilterTags);
            coreOtherAllocMb += BytesToMb(Math.Max(
                0,
                coreStage.AllocBytes
                - coreTimes.AllocParsing
                - coreTimes.AllocTraversalTree
                - coreTimes.AllocNaming
                - coreTimes.AllocResolveReferences
                - coreTimes.AllocFiltering
                - coreTimes.AllocFilterTags));
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
            postFernTypeNormalizationMs += coreTimes.OpenApiParsing.PostFernTypeNormalization.TotalMilliseconds;
            postNumericConstraintSanitizationMs += coreTimes.OpenApiParsing.PostNumericConstraintSanitization.TotalMilliseconds;
            postLargeIntegerFormatInferenceMs += coreTimes.OpenApiParsing.PostLargeIntegerFormatInference.TotalMilliseconds;
            postDiscriminatorSanitizationMs += coreTimes.OpenApiParsing.PostDiscriminatorSanitization.TotalMilliseconds;
            postFernTypeNormalizationAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostFernTypeNormalization);
            postNumericConstraintSanitizationAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostNumericConstraintSanitization);
            postLargeIntegerFormatInferenceAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostLargeIntegerFormatInference);
            postDiscriminatorSanitizationAllocMb += BytesToMb(coreTimes.OpenApiParsing.AllocPostDiscriminatorSanitization);

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
            csharpNamingAllocMb += BytesToMb(enrichTimes.AllocNaming);
            computeDataAllocMb += BytesToMb(enrichTimes.AllocComputeData);
            computeDataClassesAllocMb += BytesToMb(enrichTimes.AllocComputeDataClasses);
            csharpOtherAllocMb += BytesToMb(Math.Max(
                0,
                enrichStage.AllocBytes
                - enrichTimes.AllocNaming
                - enrichTimes.AllocComputeData
                - enrichTimes.AllocComputeDataClasses));

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
            CoreParsingAllocMb: coreParsingAllocMb / iterations,
            CoreTreeAllocMb: coreTreeAllocMb / iterations,
            CoreNamingAllocMb: coreNamingAllocMb / iterations,
            CoreResolveAllocMb: coreResolveAllocMb / iterations,
            CoreFilterAllocMb: coreFilterAllocMb / iterations,
            CoreOtherAllocMb: coreOtherAllocMb / iterations,
            CSharpAllocMb: csharpAllocMb / iterations,
            CSharpNamingAllocMb: csharpNamingAllocMb / iterations,
            ComputeDataAllocMb: computeDataAllocMb / iterations,
            ComputeDataClassesAllocMb: computeDataClassesAllocMb / iterations,
            CSharpOtherAllocMb: csharpOtherAllocMb / iterations,
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
            PostFernTypeNormalizationMs: postFernTypeNormalizationMs / iterations,
            PostNumericConstraintSanitizationMs: postNumericConstraintSanitizationMs / iterations,
            PostLargeIntegerFormatInferenceMs: postLargeIntegerFormatInferenceMs / iterations,
            PostDiscriminatorSanitizationMs: postDiscriminatorSanitizationMs / iterations,
            PostFernTypeNormalizationAllocMb: postFernTypeNormalizationAllocMb / iterations,
            PostNumericConstraintSanitizationAllocMb: postNumericConstraintSanitizationAllocMb / iterations,
            PostLargeIntegerFormatInferenceAllocMb: postLargeIntegerFormatInferenceAllocMb / iterations,
            PostDiscriminatorSanitizationAllocMb: postDiscriminatorSanitizationAllocMb / iterations,
            SchemaCount: schemaCount,
            FilteredSchemaCount: filteredSchemaCount,
            ClassCount: classCount,
            EnumCount: enumCount,
            MethodCount: methodCount,
            FileCount: fileCount,
            SourceMb: sourceMb);
    }

    private static void WriteMethodRenderMeasurement(
        string specName,
        string stage,
        EquatableArray<EndPoint> methods,
        Func<EndPoint, string> render)
    {
        _ = RenderAll(methods, render);
        var measurements = new Measured<long>[3];
        for (var iteration = 0; iteration < measurements.Length; iteration++)
        {
            measurements[iteration] = Measure(() => RenderAll(methods, render));
        }

        Array.Sort(measurements, static (left, right) => left.AllocBytes.CompareTo(right.AllocBytes));
        var median = measurements[1];
        Console.WriteLine(
            "{0,-12} {1,-14} {2,9:F1}ms {3,11:F1} {4,12}",
            specName,
            stage,
            median.Elapsed.TotalMilliseconds,
            BytesToMb(median.AllocBytes),
            median.Result);
    }

    private static long RenderAll(
        EquatableArray<EndPoint> methods,
        Func<EndPoint, string> render)
    {
        long characters = 0;
        for (var index = 0; index < methods.Length; index++)
        {
            characters += render(methods[index]).Length;
        }

        return characters;
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
        double CoreParsingAllocMb,
        double CoreTreeAllocMb,
        double CoreNamingAllocMb,
        double CoreResolveAllocMb,
        double CoreFilterAllocMb,
        double CoreOtherAllocMb,
        double CSharpAllocMb,
        double CSharpNamingAllocMb,
        double ComputeDataAllocMb,
        double ComputeDataClassesAllocMb,
        double CSharpOtherAllocMb,
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
        double PostFernTypeNormalizationMs,
        double PostNumericConstraintSanitizationMs,
        double PostLargeIntegerFormatInferenceMs,
        double PostDiscriminatorSanitizationMs,
        double PostFernTypeNormalizationAllocMb,
        double PostNumericConstraintSanitizationAllocMb,
        double PostLargeIntegerFormatInferenceAllocMb,
        double PostDiscriminatorSanitizationAllocMb,
        int SchemaCount,
        int FilteredSchemaCount,
        int ClassCount,
        int EnumCount,
        int MethodCount,
        int FileCount,
        double SourceMb);
}

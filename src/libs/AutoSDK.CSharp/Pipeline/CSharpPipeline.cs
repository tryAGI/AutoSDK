using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Models;

namespace AutoSDK.Generation;

public static class CSharpPipeline
{
    private const int MaxRenderParallelism = 8;

    public static Models.Data PrepareAndEnrich(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        return PrepareAndEnrichWithCoreResult(tuple, cancellationToken).Data;
    }

    public static (Models.Data Data, CorePipelineResult CoreResult) PrepareAndEnrichWithCoreResult(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        var totalTime = System.Diagnostics.Stopwatch.StartNew();
        var coreResult = PrepareCore(tuple, cancellationToken);
        var data = Enrich(coreResult, cancellationToken);
        return (data with
        {
            Times = data.Times with
            {
                Total = totalTime.Elapsed,
            },
        }, coreResult);
    }

    private static CorePipelineResult PrepareCore(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken)
    {
        return CorePipeline.Prepare(
            tuple,
            static (document, settings) => document.GetSchemas((CSharpSettings)settings),
            ApplyModelNaming,
            static text => text.ToClassName(),
            static text => text.ToPropertyName(),
            cancellationToken);
    }

    public static void ApplyModelNaming(IReadOnlyList<SchemaContext> schemas)
    {
        schemas = schemas ?? throw new ArgumentNullException(nameof(schemas));

        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].IsModel)
            {
                _ = ModelNameGenerator.ComputeId(schemas[i]);
            }
        }

        ModelNameGenerator.ResolveCollisions(schemas);
    }

    public static Models.Data PrepareAndEnrich(
        ((string Text, CSharpSettings Settings) Context, CSharpSettings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        return PrepareAndEnrich(
            (
                (tuple.Context.Text, tuple.Context.Settings.ToSettings()),
                tuple.GlobalSettings.ToSettings()
            ),
            cancellationToken);
    }

    public static Models.Data Enrich(
        CorePipelineResult coreResult,
        CancellationToken cancellationToken = default)
    {
        return coreResult.Format switch
        {
            SpecFormat.AsyncApi => AsyncApiData.Enrich(coreResult, cancellationToken),
            _ => Data.Enrich(coreResult, cancellationToken),
        };
    }

    public static IReadOnlyList<FileWithName> GenerateFiles(
        CorePipelineResult coreResult,
        CancellationToken cancellationToken = default)
    {
        return GenerateFiles(Enrich(coreResult, cancellationToken), cancellationToken);
    }

    public static IReadOnlyList<FileWithName> GenerateFiles(
        Models.Data data,
        CancellationToken cancellationToken = default)
    {
        return GenerateFilesCore(data, collectDiagnostics: false, cancellationToken).Files;
    }

    public static CSharpRenderResult GenerateFilesWithDiagnostics(
        Models.Data data,
        CancellationToken cancellationToken = default)
    {
        return GenerateFilesCore(data, collectDiagnostics: true, cancellationToken);
    }

    private static CSharpRenderResult GenerateFilesCore(
        Models.Data data,
        bool collectDiagnostics,
        CancellationToken cancellationToken)
    {
        var settings = data.Converters.Settings;
        var webSocketMessageModels = data.Classes
            .Where(x => data.WebSocketOperations.Any(y => string.Equals(
                y.MessageType.CSharpTypeWithoutNullability,
                x.GlobalClassName,
                StringComparison.Ordinal)))
            .ToDictionary(x => x.GlobalClassName, x => x, StringComparer.Ordinal);

        var files = new List<FileWithName>(
            settings.GenerateModels
                ? data.Enums.Length * 3 + data.Classes.Length * 4 + data.Methods.Length * 2 + 32
                : data.WebSocketClients.Length * 2 + data.WebSocketOperations.Length);
        var phases = collectDiagnostics
            ? new List<CSharpRenderPhase>(12)
            : null;

        void AddPhase(string name, Func<IEnumerable<FileWithName>> generate)
        {
            var allocationStart = collectDiagnostics
                ? GetRenderAllocatedBytes()
                : 0;
            var stopwatch = collectDiagnostics
                ? System.Diagnostics.Stopwatch.StartNew()
                : null;
            var fileCount = 0;
            long characterCount = 0;
            foreach (var file in generate())
            {
                if (file.IsEmpty)
                {
                    continue;
                }

                files.Add(file);
                fileCount++;
                characterCount += file.Text.Length;
            }

            if (phases is null || stopwatch is null)
            {
                return;
            }

            stopwatch.Stop();
            phases.Add(new CSharpRenderPhase(
                name,
                stopwatch.Elapsed,
                GetRenderAllocatedBytes() - allocationStart,
                fileCount,
                characterCount));
        }

        FileWithName[] MeasurePhase(string name, Func<FileWithName[]> generate)
        {
            var allocationStart = collectDiagnostics
                ? GetRenderAllocatedBytes()
                : 0;
            var stopwatch = collectDiagnostics
                ? System.Diagnostics.Stopwatch.StartNew()
                : null;
            var phaseFiles = generate();

            if (phases is null || stopwatch is null)
            {
                return phaseFiles;
            }

            stopwatch.Stop();
            var fileCount = 0;
            long characterCount = 0;
            for (var index = 0; index < phaseFiles.Length; index++)
            {
                if (phaseFiles[index].IsEmpty)
                {
                    continue;
                }

                fileCount++;
                characterCount += phaseFiles[index].Text.Length;
            }

            phases.Add(new CSharpRenderPhase(
                name,
                stopwatch.Elapsed,
                GetRenderAllocatedBytes() - allocationStart,
                fileCount,
                characterCount));
            return phaseFiles;
        }

        if (settings.GenerateCli)
        {
            AddPhase("cli", () => data.Methods
                .SelectMany(x => new[]
                {
                    Sources.Command(x, cancellationToken),
                })
                .Concat(data.Methods
                    .GroupBy(x => x.Tag)
                    .SelectMany(x => new[]
                    {
                        Sources.GroupCommand(x.Key, x.ToImmutableArray(), cancellationToken),
                }))
                .Concat([Sources.MainCommand(data.Tags, cancellationToken)])
                .Concat([Sources.AddCommands(data.Methods, data.Tags, cancellationToken)]));
        }
        else if (settings.GenerateModels)
        {
            var enumFiles = MeasurePhase(
                "enums",
                () => GenerateEnumFiles(data.Enums, cancellationToken));
            for (var index = 0; index < enumFiles.Length; index++)
            {
                AddIfNotEmpty(enumFiles[index]);
            }
            var modelTypeFiles = MeasurePhase(
                "model_types",
                () => GenerateClassTypeFiles(data.Classes, webSocketMessageModels, cancellationToken));
            var modelJsonFiles = MeasurePhase(
                "model_json",
                () => GenerateClassJsonFiles(data.Classes, cancellationToken));
            var modelValidationFiles = MeasurePhase(
                "model_validation",
                () => GenerateClassValidationFiles(data.Classes, cancellationToken));
            for (var index = 0; index < data.Classes.Length; index++)
            {
                AddIfNotEmpty(modelTypeFiles[index * 2]);
                AddIfNotEmpty(modelTypeFiles[(index * 2) + 1]);
                AddIfNotEmpty(modelJsonFiles[index]);
                AddIfNotEmpty(modelValidationFiles[index]);
            }

            var methodImplementationFiles = MeasurePhase(
                "method_implementations",
                () => GenerateMethodImplementationFiles(data.Methods, cancellationToken));
            var methodInterfaceFiles = MeasurePhase(
                "method_interfaces",
                () => GenerateMethodInterfaceFiles(data.Methods, cancellationToken));
            for (var index = 0; index < data.Methods.Length; index++)
            {
                AddIfNotEmpty(methodImplementationFiles[index]);
                AddIfNotEmpty(methodInterfaceFiles[index]);
            }
            AddPhase("clients_auth", () => data.Clients
                        .SelectMany(x => new[]
                        {
                            Sources.Client(x, cancellationToken),
                            Sources.ClientInterface(x, cancellationToken),
                        })
                    .Concat(data.Authorizations
                        .SelectMany(x => new[]
                        {
                            Sources.Authorization(x, cancellationToken),
                            Sources.AuthorizationInterface(x, cancellationToken),
                        }))
                    .Concat([Sources.MainAuthorizationConstructor(data.Authorizations, cancellationToken)])
                    .Concat([Sources.OAuth2SupportTypes(data.Authorizations, cancellationToken)]));
            AddPhase("unions", () => data.AnyOfs
                        .SelectMany(x => new[]
                        {
                            Sources.AnyOf(x, cancellationToken),
                            Sources.AnyOfJsonExtensions(x, cancellationToken),
                            Sources.AnyOfJsonConverter(x, cancellationToken),
                            Sources.AnyOfValidation(x, cancellationToken),
                        }));
            var serializerContextGenerationState = new Sources.JsonSerializerContextGenerationState();
            var serializerContextFile = MeasurePhase(
                "serializer_context",
                () => [Sources.JsonSerializerContext(
                    data.Converters,
                    data.Types,
                    serializerContextGenerationState,
                    cancellationToken)]);
            var serializerContextTypesFile = MeasurePhase(
                "serializer_context_types",
                () => [Sources.JsonSerializerContextTypes(
                    data.Converters,
                    data.Types,
                    serializerContextGenerationState,
                    cancellationToken)]);
            AddIfNotEmpty(serializerContextFile[0]);
            AddIfNotEmpty(serializerContextTypesFile[0]);
            AddPhase("support", () => new[] { Sources.Polyfills(settings, cancellationToken) }
                    .Concat([Sources.Exceptions(settings, cancellationToken)])
                    .Concat([Sources.PathBuilder(settings, cancellationToken)])
                    .Concat(data.Clients.Any(static x => x.UsesServerSelectionSupport) ||
                            data.Methods.Any(static x => x.ClientUsesServerSelectionSupport)
                        ? [Sources.ServerSelectionSupport(settings, cancellationToken)]
                        : [])
                    .Concat([Sources.OptionsSupport(
                        settings,
                        includePollingSupport: data.Methods.Any(static x =>
                            !x.PollingOperations.IsEmpty || x.HasLocationWaitCompanion),
                        cancellationToken: cancellationToken)])
                    .Concat(settings.GenerateDependencyInjection
                        ? data.Clients
                            .Where(static x => x.Id == "MainConstructor")
                            .Take(1)
                            .Select(x => Sources.DependencyInjection(
                                x,
                                includeConfigurationBinding: settings.GenerateConfigurationBinding,
                                cancellationToken: cancellationToken))
                        : [])
                    .Concat(settings.GenerateHttpResilienceExtensions
                        ? [Sources.HttpResilienceExtensions(settings, cancellationToken)]
                        : [])
                    .Concat([Sources.WebhookVerifier(settings, cancellationToken)])
                    .Concat([Sources.DynamicMultipartHelpers(settings, cancellationToken)])
                    .Concat([Sources.MultipartUploadHelpers(settings, cancellationToken)])
                    .Concat([Sources.PolymorphicArrayHelpers(settings, cancellationToken)])
                    .Concat(Sources.PolymorphicArrayClasses(settings, data.Schemas, cancellationToken))
                    .Concat([Sources.PromptTemplateHelpers(settings, cancellationToken)])
                    .Concat([Sources.ObservabilityLifecycleHelpers(settings, cancellationToken)])
                    .Concat([Sources.PredictionWorkflowHelpers(settings, cancellationToken)])
                    .Concat([Sources.EvaluationWorkflowHelpers(settings, cancellationToken)])
                    .Concat([Sources.CloudSigningHelpers(settings, cancellationToken)])
                    .Concat(!data.Authorizations.IsEmpty
                        ? [Sources.SecuritySupport(settings, cancellationToken)]
                        : [])
                    .Concat(data.Methods.Any(static x => x.GenerateResponseWrapper && !x.EnumerableStream) ||
                            settings.GeneratePageableHelpers
                        ? [Sources.HttpResponse(settings, settings.Namespace, cancellationToken)]
                        : [])
                    .Concat(data.Methods.Any(static x => Sources.ShouldGenerateResponseStreamSupport(x))
                        ? [Sources.ResponseStream(data.Converters.Settings, cancellationToken)]
                        : [])
                    .Concat(data.Methods.Any(static x => x.StreamFormat == AutoSDK.Models.StreamFormat.AwsEventStream)
                        ? [Sources.AwsEventStreamSupport(settings, cancellationToken)]
                        : [])
                    .Concat(settings.GeneratePageableHelpers
                        ? [Sources.PageableHelpers(settings, cancellationToken)]
                        : [])
                    .Concat([Sources.UnixTimestampJsonConverter(settings, cancellationToken)]));
            AddPhase("websockets", () => data.WebSocketClients
                        .SelectMany(x => new[]
                        {
                            Sources.WebSocketClient(x, cancellationToken),
                            Sources.WebSocketReceiveMethod(x, cancellationToken),
                        })
                    .Concat(data.WebSocketClients
                        .Where(x => x.QueryParameters.Length > 0 &&
                                    x.Settings.Namespace != settings.Namespace)
                        .Select(x => x.Settings)
                        .Distinct()
                        .Select(x => Sources.PathBuilder(x, cancellationToken)))
                    .Concat(data.WebSocketOperations
                        .Where(x => x.Direction == AutoSDK.Models.WebSocketDirection.Send)
                        .Select(x => Sources.WebSocketSendMethod(
                            x,
                            webSocketMessageModels.TryGetValue(x.MessageType.CSharpTypeWithoutNullability, out var model)
                                ? model
                                : default,
                            cancellationToken))));
        }
        else
        {
            AddPhase("websockets", () => data.WebSocketClients
                .SelectMany(x => new[]
                {
                    Sources.WebSocketClient(x, cancellationToken),
                    Sources.WebSocketReceiveMethod(x, cancellationToken),
                })
                .Concat(data.WebSocketOperations
                    .Where(x => x.Direction == AutoSDK.Models.WebSocketDirection.Send)
                    .Select(x => Sources.WebSocketSendMethod(
                        x,
                        webSocketMessageModels.TryGetValue(x.MessageType.CSharpTypeWithoutNullability, out var model)
                            ? model
                            : default,
                        cancellationToken))));
        }

        return new CSharpRenderResult(
            files.ToArray(),
            phases?.ToArray() ?? []);

        void AddIfNotEmpty(FileWithName file)
        {
            if (!file.IsEmpty)
            {
                files.Add(file);
            }
        }
    }

    private static FileWithName[] GenerateMethodImplementationFiles(
        EquatableArray<EndPoint> methods,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[methods.Length];
        var parallelOptions = new ParallelOptions
        {
            CancellationToken = cancellationToken,
            MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxRenderParallelism),
        };

        Parallel.For(0, methods.Length, parallelOptions, index =>
        {
            var method = methods[index];
            files[index] = Sources.Method(method, cancellationToken);
        });

        return files;
    }

    private static FileWithName[] GenerateEnumFiles(
        EquatableArray<ModelData> enums,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[enums.Length * 3];
        var parallelOptions = CreateRenderParallelOptions(cancellationToken);

        Parallel.For(0, enums.Length, parallelOptions, index =>
        {
            var model = enums[index];
            files[index * 3] = Sources.Enum(model, cancellationToken);
            files[(index * 3) + 1] = Sources.EnumJsonConverter(model, cancellationToken);
            files[(index * 3) + 2] = Sources.EnumNullableJsonConverter(model, cancellationToken);
        });

        return files;
    }

    private static FileWithName[] GenerateMethodInterfaceFiles(
        EquatableArray<EndPoint> methods,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[methods.Length];
        var parallelOptions = CreateRenderParallelOptions(cancellationToken);

        Parallel.For(0, methods.Length, parallelOptions, index =>
        {
            files[index] = Sources.MethodInterface(methods[index], cancellationToken);
        });

        return files;
    }

    private static FileWithName[] GenerateClassTypeFiles(
        EquatableArray<ModelData> classes,
        Dictionary<string, ModelData> webSocketMessageModels,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[classes.Length * 2];
        var parallelOptions = CreateRenderParallelOptions(cancellationToken);

        Parallel.For(0, classes.Length, parallelOptions, index =>
        {
            var model = classes[index];
            files[index * 2] = Sources.Class(model, cancellationToken);
            files[(index * 2) + 1] = webSocketMessageModels.ContainsKey(model.GlobalClassName)
                ? Sources.ClassWebSocketBinaryPayloadHelpers(model, cancellationToken)
                : FileWithName.Empty;
        });

        return files;
    }

    private static FileWithName[] GenerateClassJsonFiles(
        EquatableArray<ModelData> classes,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[classes.Length];
        var parallelOptions = CreateRenderParallelOptions(cancellationToken);

        Parallel.For(0, classes.Length, parallelOptions, index =>
        {
            files[index] = Sources.ClassJsonExtensions(classes[index], cancellationToken);
        });

        return files;
    }

    private static FileWithName[] GenerateClassValidationFiles(
        EquatableArray<ModelData> classes,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[classes.Length];
        var parallelOptions = CreateRenderParallelOptions(cancellationToken);

        Parallel.For(0, classes.Length, parallelOptions, index =>
        {
            files[index] = Sources.ClassValidation(classes[index], cancellationToken);
        });

        return files;
    }

    private static ParallelOptions CreateRenderParallelOptions(CancellationToken cancellationToken)
    {
        return new ParallelOptions
        {
            CancellationToken = cancellationToken,
            MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxRenderParallelism),
        };
    }

    private static long GetRenderAllocatedBytes()
    {
#if NET6_0_OR_GREATER
        return GC.GetTotalAllocatedBytes(precise: true);
#else
        return 0;
#endif
    }
}

public sealed class CSharpRenderPhase
{
    public CSharpRenderPhase(
        string name,
        TimeSpan elapsed,
        long allocatedBytes,
        int fileCount,
        long characterCount)
    {
        Name = name;
        Elapsed = elapsed;
        AllocatedBytes = allocatedBytes;
        FileCount = fileCount;
        CharacterCount = characterCount;
    }

    public string Name { get; }
    public TimeSpan Elapsed { get; }
    public long AllocatedBytes { get; }
    public int FileCount { get; }
    public long CharacterCount { get; }
}

public sealed class CSharpRenderResult
{
    public CSharpRenderResult(
        IReadOnlyList<FileWithName> files,
        IReadOnlyList<CSharpRenderPhase> phases)
    {
        Files = files;
        Phases = phases;
    }

    public IReadOnlyList<FileWithName> Files { get; }
    public IReadOnlyList<CSharpRenderPhase> Phases { get; }
}

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using AutoSDK.Naming.Models;
using AutoSDK.Packaging;

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

        // In split-by-tags mode the models no longer all live in one assembly, so neither can the
        // [JsonSerializable] registrations: each package registers what it owns and chains onto the
        // package it references. Everything a model emits then has to name that same context --
        // including its own ToJson()/FromJson() defaults, which would otherwise point at Core's and
        // throw for a model that moved out of it. Everywhere else this stays one context.
        var modelOwners = settings.SplitByTags
            ? ModelOwnershipResolver.Resolve(data)
            : EmptyOwners;
        if (modelOwners.Count != 0)
        {
            var contextNamesByTag = BuildContextNamesByTag(data);
            data = data with
            {
                Classes = RetargetSerializerContext(data.Classes, modelOwners, contextNamesByTag),
                Enums = RetargetSerializerContext(data.Enums, modelOwners, contextNamesByTag),
                AnyOfs = RetargetSerializerContext(data.AnyOfs, modelOwners, contextNamesByTag),
            };
        }
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
            var clients = modelOwners.Count == 0
                ? data.Clients
                : ApplyPackageSerializerContexts(data, modelOwners);
            AddPhase("clients_auth", () => clients
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
            var serializerContextFiles = MeasurePhase(
                "serializer_context",
                () => modelOwners.Count == 0
                    ? [Sources.JsonSerializerContext(
                        data.Converters,
                        data.Types,
                        serializerContextGenerationState,
                        fallbackResolverExpressions: null,
                        cancellationToken)]
                    : CreatePackageJsonSerializerContexts(data, modelOwners, cancellationToken));
            var serializerContextTypesFile = MeasurePhase(
                "serializer_context_types",
                () => [Sources.JsonSerializerContextTypes(
                    data.Converters,
                    modelOwners.Count == 0 ? data.Types : GetCoreTypes(data, modelOwners),
                    serializerContextGenerationState,
                    cancellationToken)]);
            foreach (var file in serializerContextFiles)
            {
                AddIfNotEmpty(file);
            }
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

    /// <summary>
    /// Maps an owning tag name to the serializer context class its package emits.
    /// </summary>
    private static Dictionary<string, string> BuildContextNamesByTag(Models.Data data)
    {
        var settings = data.Converters.Settings;
        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var tag in data.Tags)
        {
            if (tag.Name is not null)
            {
                result[tag.Name] = GetPackageContextName(settings.Namespace, tag.SafeName);
            }
        }

        return result;
    }

    /// <summary>
    /// Points each model's generated JSON helpers at the context of the package it ships in.
    /// </summary>
    /// <remarks>
    /// <c>ToJson()</c> and <c>FromJson(string)</c> take no context and fall back to the configured
    /// one, which is Core's. A model that moved into a tag package is not registered there, so the
    /// fallback throws at runtime for exactly the models the split moved.
    /// </remarks>
    private static EquatableArray<ModelData> RetargetSerializerContext(
        EquatableArray<ModelData> models,
        IReadOnlyDictionary<string, string> modelOwners,
        IReadOnlyDictionary<string, string> contextNamesByTag)
    {
        return models
            .Select(model => ResolveContextName(model.GlobalClassName, modelOwners, contextNamesByTag) is { } contextName
                ? model with { Settings = model.Settings with { JsonSerializerContext = contextName } }
                : model)
            .ToImmutableArray()
            .AsEquatableArray();
    }

    private static EquatableArray<AnyOfData> RetargetSerializerContext(
        EquatableArray<AnyOfData> anyOfs,
        IReadOnlyDictionary<string, string> modelOwners,
        IReadOnlyDictionary<string, string> contextNamesByTag)
    {
        return anyOfs
            .Select(anyOf => anyOf.IsNamed &&
                    ResolveContextName($"global::{anyOf.Namespace}.{anyOf.Name}", modelOwners, contextNamesByTag) is { } contextName
                ? anyOf with { Settings = anyOf.Settings with { JsonSerializerContext = contextName } }
                : anyOf)
            .ToImmutableArray()
            .AsEquatableArray();
    }

    private static string? ResolveContextName(
        string globalClassName,
        IReadOnlyDictionary<string, string> modelOwners,
        IReadOnlyDictionary<string, string> contextNamesByTag)
    {
        return modelOwners.TryGetValue(globalClassName, out var tagName) &&
               contextNamesByTag.TryGetValue(tagName, out var contextName)
            ? contextName
            : null;
    }

    private static readonly IReadOnlyDictionary<string, string> EmptyOwners =
        new Dictionary<string, string>(StringComparer.Ordinal);

    /// <summary>
    /// The types that stay in the Core package: everything no single tag exclusively owns.
    /// </summary>
    private static EquatableArray<TypeData> GetCoreTypes(
        Models.Data data,
        IReadOnlyDictionary<string, string> modelOwners)
    {
        return data.Types
            .Where(x => ModelOwnershipResolver.ResolveTypeOwner(x.CSharpTypeWithoutNullability, modelOwners) is null)
            .ToImmutableArray()
            .AsEquatableArray();
    }

    /// <summary>
    /// One serializer context per package: Core registers what it keeps, each tag registers what it
    /// took and chains onto Core, and the facade chains all of them so the root client can still
    /// hand one context down to every sub-client.
    /// </summary>
    private static FileWithName[] CreatePackageJsonSerializerContexts(
        Models.Data data,
        IReadOnlyDictionary<string, string> modelOwners,
        CancellationToken cancellationToken)
    {
        var settings = data.Converters.Settings;
        var convertersByTag = ModelOwnershipResolver.ResolveConverters(data, modelOwners);
        var ownedConverters = new HashSet<string>(
            convertersByTag.Values.SelectMany(static x => x),
            StringComparer.Ordinal);

        // A context registers the converters for every type it can be asked to resolve, not just
        // the ones it owns. A chained resolver builds its JsonTypeInfo against the *calling*
        // context's options, so a converter declared only on Core would silently stop applying the
        // moment a tag context resolved a Core type through it.
        var coreConverters = data.Converters.Converters
            .Where(x => !ownedConverters.Contains(x))
            .ToImmutableArray();
        var coreClient = data.Converters with { Converters = coreConverters };
        var files = new List<FileWithName>
        {
            Sources.JsonSerializerContext(
                coreClient,
                GetCoreTypes(data, modelOwners),
                new Sources.JsonSerializerContextGenerationState(),
                // Empty rather than null: Core chains onto nothing, but still needs the shape that
                // publishes a resolver for the tag packages above it.
                fallbackResolverExpressions: [],
                cancellationToken),
        };

        // Types whose type-info name collides family-wide are added to every context that is not
        // Core's. A context registers only its own share and lets System.Text.Json discover the
        // rest implicitly, which is where the collision would otherwise surface as SYSLIB1031;
        // registering both halves lets the context name them apart. Only Core-owned ones, since
        // those are the only types every package in the family can see.
        var collidingTypes = new HashSet<string>(
            Sources.GetCollidingTypeInfoNameTypes(data.Converters, data.Types),
            StringComparer.Ordinal);
        var sharedCollidingTypes = data.Types
            .Where(x => collidingTypes.Contains(x.CSharpTypeWithoutNullability) &&
                        ModelOwnershipResolver.ResolveTypeOwner(x.CSharpTypeWithoutNullability, modelOwners) is null)
            .ToImmutableArray();

        var coreResolver = $"global::{settings.JsonSerializerContext}.TypeInfoResolver";
        var chain = new List<string> { coreResolver };
        foreach (var tag in data.Tags.OrderBy(static x => x.SafeName, StringComparer.Ordinal))
        {
            if (tag.Name is null)
            {
                continue;
            }

            var tagTypes = data.Types
                .Where(x => string.Equals(
                    ModelOwnershipResolver.ResolveTypeOwner(x.CSharpTypeWithoutNullability, modelOwners),
                    tag.Name,
                    StringComparison.Ordinal))
                .ToImmutableArray();
            if (tagTypes.Length == 0)
            {
                continue;
            }

            var contextName = GetPackageContextName(settings.Namespace, tag.SafeName);
            files.Add(Sources.JsonSerializerContext(
                CreatePackageContextClient(
                    data.Converters,
                    tag.SafeName,
                    contextName,
                    convertersByTag.TryGetValue(tag.Name, out var converters)
                        ? coreConverters.AddRange(converters)
                        : coreConverters),
                tagTypes.AddRange(sharedCollidingTypes).AsEquatableArray(),
                new Sources.JsonSerializerContextGenerationState(),
                // Core last: a tag's own registrations must win over the ones it left behind.
                fallbackResolverExpressions: [coreResolver],
                cancellationToken));
            chain.Add($"global::{contextName}.TypeInfoResolver");
        }

        if (chain.Count > 1)
        {
            var rootClassName = settings.ClassName.Replace(".", string.Empty);
            files.Add(Sources.JsonSerializerContext(
                CreatePackageContextClient(
                    data.Converters,
                    rootClassName,
                    GetPackageContextName(settings.Namespace, rootClassName),
                    // The facade resolves through every package, so it registers every converter.
                    data.Converters.Converters),
                sharedCollidingTypes.AsEquatableArray(),
                new Sources.JsonSerializerContextGenerationState(),
                fallbackResolverExpressions: chain,
                cancellationToken));
        }

        return files.ToArray();
    }

    /// <summary>
    /// The context class a package owns, e.g. <c>Fixture.AlbumsSourceGenerationContext</c>.
    /// </summary>
    internal static string GetPackageContextName(string @namespace, string safeName)
    {
        return $"{@namespace}.{safeName}SourceGenerationContext";
    }

    /// <summary>
    /// A stand-in client that carries just what the context emitter reads: the file name, the
    /// context's own fully-qualified name, and the converters that package registers.
    /// </summary>
    private static Client CreatePackageContextClient(
        Client template,
        string safeName,
        string contextName,
        ImmutableArray<string> converters)
    {
        return template with
        {
            FileNameWithoutExtension = $"{template.Settings.Namespace}.{safeName}",
            Settings = template.Settings with { JsonSerializerContext = contextName },
            Converters = converters,
        };
    }

    /// <summary>
    /// Points each client at the context of the package it ships in.
    /// </summary>
    /// <remarks>
    /// A tag client that took models from Core must default to its own context or those models
    /// would not resolve; the root client takes the chained one, which it then hands down to every
    /// sub-client exactly as it does in single-project mode.
    /// </remarks>
    private static EquatableArray<Client> ApplyPackageSerializerContexts(
        Models.Data data,
        IReadOnlyDictionary<string, string> modelOwners)
    {
        var settings = data.Converters.Settings;
        var owningTags = new HashSet<string>(modelOwners.Values, StringComparer.Ordinal);
        var contextByClientClassName = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var tag in data.Tags)
        {
            if (tag.Name is not null && owningTags.Contains(tag.Name))
            {
                contextByClientClassName[CSharpClientNameGenerator.Generate(tag)] =
                    GetPackageContextName(settings.Namespace, tag.SafeName);
            }
        }

        if (contextByClientClassName.Count == 0)
        {
            return data.Clients;
        }

        var rootClassName = settings.ClassName.Replace(".", string.Empty);
        contextByClientClassName[rootClassName] = GetPackageContextName(settings.Namespace, rootClassName);

        return data.Clients
            .Select(client => contextByClientClassName.TryGetValue(client.ClassName, out var contextName)
                ? client with { Settings = client.Settings with { JsonSerializerContext = contextName } }
                : client)
            .ToImmutableArray()
            .AsEquatableArray();
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

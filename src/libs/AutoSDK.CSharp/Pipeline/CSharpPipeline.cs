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
    private const int MaxRenderParallelism = 4;

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
        var settings = data.Converters.Settings;
        var webSocketMessageModels = data.Classes
            .Where(x => data.WebSocketOperations.Any(y => string.Equals(
                y.MessageType.CSharpTypeWithoutNullability,
                x.GlobalClassName,
                StringComparison.Ordinal)))
            .ToDictionary(x => x.GlobalClassName, x => x, StringComparer.Ordinal);

        return settings.GenerateCli
            ? data.Methods
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
                .Concat([Sources.AddCommands(data.Methods, data.Tags, cancellationToken)])
                .Where(x => !x.IsEmpty)
                .ToArray()
            : settings.GenerateModels
                ? data.Enums
                    .SelectMany(x => new[]
                    {
                        Sources.Enum(x, cancellationToken),
                        Sources.EnumJsonConverter(x, cancellationToken),
                        Sources.EnumNullableJsonConverter(x, cancellationToken),
                    })
                    .Concat(GenerateClassFiles(data.Classes, webSocketMessageModels, cancellationToken))
                    .Concat(GenerateMethodFiles(data.Methods, cancellationToken))
                    .Concat(data.Clients
                        .SelectMany(x => new[]
                        {
                            Sources.Client(x, cancellationToken),
                            Sources.ClientInterface(x, cancellationToken),
                        }))
                    .Concat(data.Authorizations
                        .SelectMany(x => new[]
                        {
                            Sources.Authorization(x, cancellationToken),
                            Sources.AuthorizationInterface(x, cancellationToken),
                        }))
                    .Concat([Sources.MainAuthorizationConstructor(data.Authorizations, cancellationToken)])
                    .Concat(data.AnyOfs
                        .SelectMany(x => new[]
                        {
                            Sources.AnyOf(x, cancellationToken),
                            Sources.AnyOfJsonExtensions(x, cancellationToken),
                            Sources.AnyOfJsonConverter(x, cancellationToken),
                            Sources.AnyOfValidation(x, cancellationToken),
                        }))
                    .Concat([Sources.JsonSerializerContext(data.Converters, data.Types, cancellationToken)])
                    .Concat([Sources.JsonSerializerContextTypes(data.Converters, data.Types, cancellationToken)])
                    .Concat([Sources.Polyfills(settings, cancellationToken)])
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
                        ? [Sources.HttpResponse(settings, cancellationToken)]
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
                    .Concat([Sources.UnixTimestampJsonConverter(settings, cancellationToken)])
                    .Concat(data.WebSocketClients
                        .SelectMany(x => new[]
                        {
                            Sources.WebSocketClient(x, cancellationToken),
                            Sources.WebSocketReceiveMethod(x, cancellationToken),
                        }))
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
                            cancellationToken)))
                    .Where(x => !x.IsEmpty)
                    .ToArray()
                : data.WebSocketClients
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
                            cancellationToken)))
                    .Where(x => !x.IsEmpty)
                    .ToArray();
    }

    private static FileWithName[] GenerateMethodFiles(
        EquatableArray<EndPoint> methods,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[methods.Length * 2];
        var parallelOptions = new ParallelOptions
        {
            CancellationToken = cancellationToken,
            MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxRenderParallelism),
        };

        Parallel.For(0, methods.Length, parallelOptions, index =>
        {
            var method = methods[index];
            files[index * 2] = Sources.Method(method, cancellationToken);
            files[(index * 2) + 1] = Sources.MethodInterface(method, cancellationToken);
        });

        return files;
    }

    private static FileWithName[] GenerateClassFiles(
        EquatableArray<ModelData> classes,
        Dictionary<string, ModelData> webSocketMessageModels,
        CancellationToken cancellationToken)
    {
        var files = new FileWithName[classes.Length * 4];
        var parallelOptions = new ParallelOptions
        {
            CancellationToken = cancellationToken,
            MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxRenderParallelism),
        };

        Parallel.For(0, classes.Length, parallelOptions, index =>
        {
            var model = classes[index];
            files[index * 4] = Sources.Class(model, cancellationToken);
            files[(index * 4) + 1] = webSocketMessageModels.ContainsKey(model.GlobalClassName)
                ? Sources.ClassWebSocketBinaryPayloadHelpers(model, cancellationToken)
                : FileWithName.Empty;
            files[(index * 4) + 2] = Sources.ClassJsonExtensions(model, cancellationToken);
            files[(index * 4) + 3] = Sources.ClassValidation(model, cancellationToken);
        });

        return files;
    }
}

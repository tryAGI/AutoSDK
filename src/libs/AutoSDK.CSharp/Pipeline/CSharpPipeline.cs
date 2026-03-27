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
    public static Models.Data PrepareAndEnrich(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        var totalTime = System.Diagnostics.Stopwatch.StartNew();
        var coreResult = CorePipeline.Prepare(
            tuple,
            static (document, settings) => document.GetSchemas((CSharpSettings)settings),
            ApplyModelNaming,
            static text => text.ToClassName(),
            static text => text.ToPropertyName(),
            cancellationToken);

        var data = Enrich(coreResult, cancellationToken);
        return data with
        {
            Times = data.Times with
            {
                Total = totalTime.Elapsed,
            },
        };
    }

    public static void ApplyModelNaming(IReadOnlyList<SchemaContext> schemas)
    {
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

        return settings.GenerateCli
            ? data.Methods
                .SelectMany(x => new[]
                {
                    Sources.Command(x),
                })
                .Concat(data.Methods
                    .GroupBy(x => x.Tag)
                    .SelectMany(x => new[]
                    {
                        Sources.GroupCommand(x.Key, x.ToImmutableArray()),
                    }))
                .Concat([Sources.MainCommand(data.Tags)])
                .Concat([Sources.AddCommands(data.Methods, data.Tags)])
                .Where(x => !x.IsEmpty)
                .ToArray()
            : settings.GenerateModels
                ? data.Enums
                    .SelectMany(x => new[]
                    {
                        Sources.Enum(x),
                        Sources.EnumJsonConverter(x),
                        Sources.EnumNullableJsonConverter(x),
                    })
                    .Concat(data.Classes
                        .SelectMany(x => new[]
                        {
                            Sources.Class(x),
                            Sources.ClassJsonExtensions(x),
                            Sources.ClassValidation(x),
                        }))
                    .Concat(data.Methods
                        .SelectMany(x => new[]
                        {
                            Sources.Method(x),
                            Sources.MethodInterface(x),
                        }))
                    .Concat(data.Clients
                        .SelectMany(x => new[]
                        {
                            Sources.Client(x),
                            Sources.ClientInterface(x),
                        }))
                    .Concat(data.Authorizations
                        .SelectMany(x => new[]
                        {
                            Sources.Authorization(x),
                            Sources.AuthorizationInterface(x),
                        }))
                    .Concat([Sources.MainAuthorizationConstructor(data.Authorizations)])
                    .Concat(data.AnyOfs
                        .SelectMany(x => new[]
                        {
                            Sources.AnyOf(x),
                            Sources.AnyOfJsonExtensions(x),
                            Sources.AnyOfJsonConverter(x),
                            Sources.AnyOfValidation(x),
                        }))
                    .Concat([Sources.JsonSerializerContext(data.Converters, data.Types)])
                    .Concat([Sources.JsonSerializerContextTypes(data.Types)])
                    .Concat([Sources.Polyfills(settings)])
                    .Concat([Sources.Exceptions(settings)])
                    .Concat([Sources.PathBuilder(settings)])
                    .Concat(data.Methods.Any(static x => x.RawStream)
                        ? [Sources.ResponseStream(data.Converters.Settings)]
                        : [])
                    .Concat([Sources.UnixTimestampJsonConverter(settings)])
                    .Concat(data.WebSocketClients
                        .SelectMany(x => new[]
                        {
                            Sources.WebSocketClient(x),
                            Sources.WebSocketReceiveMethod(x),
                        }))
                    .Concat(data.WebSocketClients
                        .Where(x => x.QueryParameters.Length > 0 &&
                                    x.Settings.Namespace != settings.Namespace)
                        .Select(x => x.Settings)
                        .Distinct()
                        .Select(x => Sources.PathBuilder(x)))
                    .Concat(data.WebSocketOperations
                        .Where(x => x.Direction == AutoSDK.Models.WebSocketDirection.Send)
                        .Select(x => Sources.WebSocketSendMethod(x)))
                    .Where(x => !x.IsEmpty)
                    .ToArray()
                : data.WebSocketClients
                    .SelectMany(x => new[]
                    {
                        Sources.WebSocketClient(x),
                        Sources.WebSocketReceiveMethod(x),
                    })
                    .Concat(data.WebSocketOperations
                        .Where(x => x.Direction == AutoSDK.Models.WebSocketDirection.Send)
                        .Select(x => Sources.WebSocketSendMethod(x)))
                    .Where(x => !x.IsEmpty)
                    .ToArray();
    }
}

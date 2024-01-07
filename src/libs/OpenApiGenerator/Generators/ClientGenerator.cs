using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Models;

namespace OpenApiGenerator.Generators;

[Generator]
public class ClientGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "OACG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var settings = context.DetectSettings();
        
        context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase))
            .Combine(settings)
            .SelectAndReportExceptions(PrepareData, context, Id)
            .SelectMany(static (x, _) => x)
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
    }

    private static EquatableArray<EndPoint> PrepareData(
        (AdditionalText text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        if (settings.UseNSwag)
        {
            return ImmutableArray<EndPoint>.Empty;
        }
        
        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
        var includedOperationIds = new HashSet<string>(settings.IncludeOperationIds);
        
        return openApiDocument.Paths.SelectMany(path =>
            path.Value.Operations
                .Where(x =>
                    //includedOperationIds.Count == 0 ||
                    includedOperationIds.Contains(x.Value.OperationId) ||
                    includedOperationIds.Contains(x.Value.OperationId.ToPropertyName()))
                .Select(operation => new EndPoint(
                    Id: operation.Value.OperationId,
                    Namespace: settings.Namespace,
                    ClassName: settings.ClassName)))
            .ToImmutableArray();
    }
    
    private static FileWithName GetSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: Sources.GenerateEndPoint(endPoint, cancellationToken: cancellationToken));
    }

    #endregion
}

using System.Diagnostics.CodeAnalysis;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Helpers;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Models;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class NamingTests
{
    public static SchemaContext[] PrepareModels([StringSyntax("yaml")] string yaml)
    {
        var settings = Settings.Default;
        var openApiDocument = yaml.GetOpenApiDocument();
        var schemaContexts = openApiDocument.GetSchemas(settings);
        
        var models = schemaContexts
            .Where(x => x.IsModel)
            .ToArray();
        foreach (var context in models)
        {
            _ = ModelNameGenerator.ComputeId(context);
        }

        ModelNameGenerator.ResolveCollisions(schemaContexts);
        
        return models;
    }
}
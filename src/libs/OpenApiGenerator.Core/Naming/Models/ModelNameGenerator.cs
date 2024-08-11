using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Naming.Models;

public static class ModelNameGenerator
{
    public static string ComputeId(
        Settings settings,
        SchemaContext? parent = null,
        Hint? hint = null,
        OpenApiOperation? operation = null,
        OpenApiParameter? parameter = null,
        string? propertyName = null,
        string? componentId = null,
        int? index = null)
    {
        if (propertyName != null)
        {
            return propertyName.ToCSharpName(settings, parent);
        }
        if (componentId != null)
        {
            return componentId.ToCSharpName(settings, parent);
        }

        var helper = hint switch
        {
            Hint.ArrayItem => "Item",
            Hint.Request => operation?.OperationId + "Request",
            Hint.Response => operation?.OperationId + "Response",
            Hint.Parameter => operation?.OperationId + "_" + parameter?.Name,
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => $"Variant{(index != null ? $"{index + 1}" : "")}",
            //_ when propertyName != null => propertyName,
            _ => null,
        };
        var id = parent?.Id + helper?.ToCSharpName(settings, parent);
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        return id;
    }
    
    public static string ComputeId(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        if (context.Hint is Hint.ArrayItem)
        {
                
        }
        if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf)
        {
            var anyOfNonBasicTypesCount = context.Parent?.Children
                .Count(x => x.IsEnum || x.IsClass || x is { IsAnyOf: true, IsComponent: true }) ?? 0;
        
            context.Id =
                anyOfNonBasicTypesCount == 1 &&
                context.Parent?.IsComponent != true
                    ? $"{context.Parent?.Parent?.Id}{context.Parent?.Id}"
                    : $"{context.Parent?.Parent?.Id}{context.Id.ToClassName()}";
        }
        else
        {
            context.Id = $"{context.Parent?.Id}{context.Id.ToClassName()}";
        }
        if (context.Hint is Hint.ArrayItem)
        {
                
        }
        
        return context.Id;
    }
    
    public static void ResolveCollisions(IReadOnlyCollection<SchemaContext> contexts)
    {
        foreach (var group in contexts
            .Where(x => !x.IsReference && (x.IsClass || x.IsEnum || x.IsAnyOfLikeStructure))
            .GroupBy(x => x.Id))
        {
            var i = 2;
            foreach (var context in group.Skip(1))
            {
                context.Id += $"{i++}";
            }
        }
    }
}
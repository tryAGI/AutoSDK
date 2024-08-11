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
    
    public static string? ComputeHelperName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        return (context.Hint switch
        {
            Hint.ArrayItem => "Item",
            Hint.Request => context.Operation?.OperationId + "Request",
            Hint.Response => context.Operation?.OperationId + "Response",
            Hint.Parameter => context.Operation?.OperationId + "_" + context.Parameter?.Name,
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => $"Variant{(context.Index != null ? $"{context.Index + 1}" : "")}",
            _ when context.PropertyName != null => context.PropertyName,
            _ => null,
        })?.ToCSharpName(context.Settings, context.Parent);
    }
    
    public static string ComputeClassName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        if (context.ComponentId != null)
        {
            return context.ComponentId.ToCSharpName(context.Settings, context.Parent).ToClassName();
        }

        // NamingConvention.InnerClasses => Parents.IsEmpty ? Name : $"_{Name}",
        var id = context.Parent?.ComputeClassName() + context.ComputeHelperName();
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        var className = id.ToClassName();
        
        // Special case for anyOf/oneOf/allOf with a single non-basic type
        if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
            context.Parent?.Children
                .Count(x => x.IsEnum || x.IsClass || x is { IsAnyOf: true, IsComponent: true }) == 1 &&
            context.Parent?.IsComponent != true)
        {
            className = $"{context.Parent?.ComputeClassName()}";
        }
        
        // Special case for array items with pluralized property name
        if (context.Hint is Hint.ArrayItem &&
            className.EndsWith("sItem", StringComparison.Ordinal))
        {
            className = className[..^5];
        }
        
        return className;
    }
    
    public static string ComputeId(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        context.ClassName = context.ComputeClassName();
        context.Id = context.ClassName;
        
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
using Microsoft.OpenApi;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Naming.Models;

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
            Hint.Discriminator => "Discriminator",
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
            Hint.Discriminator => "Discriminator",
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
        
        // Special case for anyOf/oneOf/allOf with a single Enum type without reference
        else if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
            context.Parent?.Children
                .Count(x => x.IsEnum && x is { IsReference: false }) == 1)
        {
            var variantName = ComputeHelperName(context)!;
            className = className.Substring(0, className.Length - variantName.Length) + "Enum";
        }
        
        // Special case for array items with pluralized property name
        if (context.Hint is Hint.ArrayItem &&
            className.EndsWith("sItem", StringComparison.Ordinal))
        {
            className = className.Substring(0, className.Length - 5);
        }
        
        return className;
    }
    
    public static string ComputeId(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        context.ClassName = CSharpPropertyNameGenerator.SanitizeName(context.ComputeClassName(), context.Settings.ClsCompliantEnumPrefix);
        context.Id = context.ClassName;
        
        return context.Id;
    }
    
    public static void ResolveCollisions(IReadOnlyCollection<SchemaContext> contexts)
    {
        while (true)
        {
            var contextsWithCollision = contexts
                .Where(x => !x.IsReference && (x.IsClass || x.IsEnum || x.IsAnyOfLikeStructure))
                // Sometimes there are still collisions for file names with different casing
                .GroupBy(x => x.Id.ToUpperInvariant())
                .Where(x => x.Count() > 1)
                .ToArray();
            if (contextsWithCollision.Length == 0)
            {
                break;
            }
            
            foreach (var group in contextsWithCollision)
            {
                var i = 2;
                foreach (var context in group.Skip(1))
                {
                    context.Id += $"{i++}";
                }
            }
        }
    }
    
    public static void ResolveCollisions(IReadOnlyCollection<OperationContext> contexts)
    {
        while (true)
        {
            var schemasWithCollision = contexts
                .GroupBy(x => (x.MethodName, x.Tags.FirstOrDefault() ?? string.Empty))
                .Where(x => x.Count() > 1)
                .ToArray();
            if (schemasWithCollision.Length == 0)
            {
                break;
            }
            
            foreach (var group in schemasWithCollision)
            {
                var i = 2;
                foreach (var context in group.Skip(1))
                {
                    context.MethodName += $"{i++}";
                }
            }
        }
    }
}
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
        IOpenApiParameter? parameter = null,
        string? propertyName = null,
        string? componentId = null,
        int? index = null,
        string? title = null)
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
            Hint.Request => string.Concat(operation?.OperationId, "Request"),
            Hint.Response => string.Concat(operation?.OperationId, "Response"),
            Hint.Parameter => string.Concat(operation?.OperationId, "_", parameter?.Name),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf when !string.IsNullOrWhiteSpace(title) => title!.ToClassName(),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => index != null ? string.Concat("Variant", (index + 1).ToString()) : "Variant",
            Hint.Discriminator => "Discriminator",
            //_ when propertyName != null => propertyName,
            _ => null,
        };
        var csharpHelper = helper?.ToCSharpName(settings, parent);
        var id = parent != null && csharpHelper != null
            ? string.Concat(parent.Id, csharpHelper)
            : csharpHelper ?? parent?.Id;
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        return id!;
    }
    
    public static string? ComputeHelperName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return (context.Hint switch
        {
            Hint.ArrayItem => "Item",
            Hint.Request => string.Concat(context.Operation?.OperationId, "Request"),
            Hint.Response => string.Concat(context.Operation?.OperationId, "Response"),
            Hint.Parameter => string.Concat(context.Operation?.OperationId, "_", context.Parameter?.Name),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf when !string.IsNullOrWhiteSpace(context.Schema.Title) => context.Schema.Title!.ToClassName(),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => context.Index != null ? string.Concat("Variant", (context.Index + 1).ToString()) : "Variant",
            Hint.Discriminator => "Discriminator",
            _ when context.PropertyName != null => context.PropertyName,
            _ => null,
        })?.ToCSharpName(context.Settings, context.Parent);
    }
    
    public static string ComputeClassName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        // Return cached result if already computed (avoids full recomputation on repeated calls)
        if (context.CachedComputedClassName != null)
        {
            return context.CachedComputedClassName;
        }

        string className;

        // x-fern-type-name overrides the generated class name (opt-in via UseExtensionNaming)
        if (context.Settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetExtensionStringValue(
                context.Schema.Extensions, "x-fern-type-name", out var fernTypeName) &&
            !string.IsNullOrWhiteSpace(fernTypeName))
        {
            className = fernTypeName.ToClassName();
            context.CachedComputedClassName = className;
            return className;
        }

        if (context.ComponentId != null)
        {
            className = context.ComponentId.ToCSharpName(context.Settings, context.Parent).ToClassName();
            context.CachedComputedClassName = className;
            return className;
        }

        // Use cached ComputeClassName from parent if already computed (avoids recursive recomputation)
        var parentClassName = context.Parent?.ComputeClassName();
        var helperName = context.ComputeHelperName();
        var id = parentClassName + helperName;
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        className = id.ToClassName();

        // Special case for anyOf/oneOf/allOf with a single non-basic type
        if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
            context.Parent?.Children
                .Count(x => x.IsEnum || x.IsClass || x is { IsAnyOf: true, IsComponent: true }) == 1 &&
            context.Parent?.IsComponent != true)
        {
            className = parentClassName ?? string.Empty;
        }

        // Special case for anyOf/oneOf/allOf with a single Enum type without reference
        else if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
            context.Parent?.Children
                .Count(x => x.IsEnum && x is { IsReference: false }) == 1)
        {
            className = className.Substring(0, className.Length - (helperName?.Length ?? 0)) + "Enum";
        }

        // Special case for array items with pluralized property name
        if (context.Hint is Hint.ArrayItem &&
            className.EndsWith("sItem", StringComparison.Ordinal))
        {
            className = className.Substring(0, className.Length - 5);
        }

        context.CachedComputedClassName = className;
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
        // Use dictionary-based grouping to avoid per-iteration LINQ + ToUpperInvariant allocations
        var groups = new Dictionary<string, List<SchemaContext>>(StringComparer.OrdinalIgnoreCase);
        while (true)
        {
            groups.Clear();
            var hasCollisions = false;
            foreach (var context in contexts)
            {
                if (context.IsReference || (!context.IsClass && !context.IsEnum && !context.IsAnyOfLikeStructure))
                {
                    continue;
                }
                if (!groups.TryGetValue(context.Id, out var list))
                {
                    list = [context];
                    groups[context.Id] = list;
                }
                else
                {
                    list.Add(context);
                    hasCollisions = true;
                }
            }
            if (!hasCollisions) break;

            foreach (var group in groups.Values)
            {
                if (group.Count <= 1) continue;
                for (var i = 1; i < group.Count; i++)
                {
                    group[i].Id += $"{i + 1}";
                }
            }
        }
    }

    public static void ResolveCollisions(IReadOnlyCollection<OperationContext> contexts)
    {
        var groups = new Dictionary<(string, string), List<OperationContext>>();
        while (true)
        {
            groups.Clear();
            var hasCollisions = false;
            foreach (var context in contexts)
            {
                var key = (context.MethodName, context.Tags.FirstOrDefault() ?? string.Empty);
                if (!groups.TryGetValue(key, out var list))
                {
                    list = [context];
                    groups[key] = list;
                }
                else
                {
                    list.Add(context);
                    hasCollisions = true;
                }
            }
            if (!hasCollisions) break;

            foreach (var group in groups.Values)
            {
                if (group.Count <= 1) continue;
                for (var i = 1; i < group.Count; i++)
                {
                    group[i].MethodName += $"{i + 1}";
                }
            }
        }
    }
}
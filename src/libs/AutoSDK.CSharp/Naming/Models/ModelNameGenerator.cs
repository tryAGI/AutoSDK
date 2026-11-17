using System.Globalization;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Naming.Properties;
using Microsoft.OpenApi;

namespace AutoSDK.Naming.Models;

public static class ModelNameGenerator
{
    public static string ComputeId(
        SchemaNamingSettings settings,
        SchemaContext? parent = null,
        Hint? hint = null,
        OpenApiOperation? operation = null,
        IOpenApiParameter? parameter = null,
        string? propertyName = null,
        string? componentId = null,
        int? index = null,
        string? title = null,
        string? operationPath = null,
        System.Net.Http.HttpMethod? operationType = null)
    {
        if (propertyName != null)
        {
            return propertyName.ToCSharpName(settings, parent);
        }
        if (componentId != null)
        {
            return CSharpNamespacedTypeNameResolver.GetComponentClassName(componentId, settings);
        }

        var helper = hint switch
        {
            Hint.ArrayItem => "Item",
            Hint.Request => string.Concat(
                GetOperationName(settings, operation)
                    ?? (operationType != null && operationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(operationType.Method, operationPath)
                        : null),
                "Request"),
            Hint.Response => string.Concat(
                GetOperationName(settings, operation)
                    ?? (operationType != null && operationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(operationType.Method, operationPath)
                        : null),
                "Response"),
            Hint.Parameter => string.Concat(
                GetOperationName(settings, operation)
                    ?? (operationType != null && operationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(operationType.Method, operationPath)
                        : null),
                "_", parameter?.Name),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf when !string.IsNullOrWhiteSpace(title) => title!.ToClassName(),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => index != null ? string.Concat("Variant", (index.Value + 1).ToString(CultureInfo.InvariantCulture)) : "Variant",
            Hint.Discriminator => "Discriminator",
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

    public static string ComputeId(
        CSharpSettings settings,
        SchemaContext? parent = null,
        Hint? hint = null,
        OpenApiOperation? operation = null,
        IOpenApiParameter? parameter = null,
        string? propertyName = null,
        string? componentId = null,
        int? index = null,
        string? title = null,
        string? operationPath = null,
        System.Net.Http.HttpMethod? operationType = null)
    {
        return ComputeId(
            settings: settings.ToSchemaNamingSettings(),
            parent: parent,
            hint: hint,
            operation: operation,
            parameter: parameter,
            propertyName: propertyName,
            componentId: componentId,
            index: index,
            title: title,
            operationPath: operationPath,
            operationType: operationType);
    }

    public static string? ComputeHelperName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return (context.Hint switch
        {
            Hint.ArrayItem => "Item",
            Hint.Request => string.Concat(
                GetOperationName(context.Settings.ToSchemaNamingSettings(), context.Operation)
                    ?? (context.OperationType != null && context.OperationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(context.OperationType.Method, context.OperationPath)
                        : null),
                "Request"),
            Hint.Response => string.Concat(
                GetOperationName(context.Settings.ToSchemaNamingSettings(), context.Operation)
                    ?? (context.OperationType != null && context.OperationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(context.OperationType.Method, context.OperationPath)
                        : null),
                "Response"),
            Hint.Parameter => string.Concat(
                GetOperationName(context.Settings.ToSchemaNamingSettings(), context.Operation)
                    ?? (context.OperationType != null && context.OperationPath != null
                        ? MethodAndPathNameHelper.DeriveNameFromMethodAndPath(context.OperationType.Method, context.OperationPath)
                        : null),
                "_", ResolveParameterName(context)),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf when !string.IsNullOrWhiteSpace(context.Schema.Title) => context.Schema.Title!.ToClassName(),
            Hint.AnyOf or Hint.OneOf or Hint.AllOf => context.Index != null ? string.Concat("Variant", (context.Index.Value + 1).ToString(CultureInfo.InvariantCulture)) : "Variant",
            Hint.Discriminator => "Discriminator",
            _ when context.PropertyName != null => ResolvePropertyName(context),
            _ => null,
        })?.ToCSharpName(context.Settings, context.Parent);
    }

    private static string? GetOperationName(SchemaNamingSettings settings, OpenApiOperation? operation)
    {
        var operationId = operation?.OperationId;
        if (!settings.StripRedundantOperationIdTagPrefixes || operationId == null)
        {
            return operationId;
        }

        return OperationIdGenerator.StripRedundantTagPrefix(
            operationId,
            operation!.Tags?.Select(static tag => tag.Name) ?? []);
    }

    public static string ComputeClassName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        if (context.CachedComputedClassName != null)
        {
            return context.CachedComputedClassName;
        }

        string className;

        if (context.Settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetTypeNameOverride(context.Schema.Extensions, out var typeNameOverride) &&
            !string.IsNullOrWhiteSpace(typeNameOverride))
        {
            className = typeNameOverride.ToClassName();
            context.CachedComputedClassName = className;
            return className;
        }

        if (context.ComponentId != null)
        {
            className = CSharpNamespacedTypeNameResolver.GetComponentClassName(context.ComponentId, context.Settings.ToSchemaNamingSettings());
            context.CachedComputedClassName = className;
            return className;
        }

        var parentClassName = context.Parent?.ComputeClassName();
        var helperName = context.ComputeHelperName();
        var id = parentClassName + helperName;
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        className = id.ToClassName();

        if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
            CountNonBasicTypes(context.Parent?.Children) == 1 &&
            context.Parent?.IsComponent != true)
        {
            className = parentClassName ?? string.Empty;
        }
        else if (context.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf &&
                 CountNonRefEnums(context.Parent?.Children) == 1)
        {
            className = className.Substring(0, className.Length - (helperName?.Length ?? 0)) + "Enum";
        }

        if (context.Hint is Hint.ArrayItem &&
            className.EndsWith("sItem", StringComparison.Ordinal))
        {
            className = className.Substring(0, className.Length - 5);
        }

        context.CachedComputedClassName = className;
        return className;
    }

    private static string? ResolvePropertyName(SchemaContext context)
    {
        if (context.Settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetPropertyNameOverride(context.Schema.Extensions, out var propertyNameOverride) &&
            !string.IsNullOrWhiteSpace(propertyNameOverride))
        {
            return propertyNameOverride;
        }

        return context.PropertyName;
    }

    private static string? ResolveParameterName(SchemaContext context)
    {
        if (context.Settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetParameterNameOverride(
                context.Parameter?.Extensions,
                context.Schema.Extensions,
                out var parameterNameOverride) &&
            !string.IsNullOrWhiteSpace(parameterNameOverride))
        {
            return parameterNameOverride;
        }

        return context.Parameter?.Name;
    }

    public static string ComputeId(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        context.ClassName = CSharpPropertyNameGenerator.SanitizeName(
            context.ComputeClassName(),
            context.Settings.ClsCompliantEnumPrefix,
            identifierCharacterSet: context.Settings.IdentifierCharacterSet);
        context.Id = context.ClassName;

        return context.Id;
    }

    public static void ResolveCollisions(IReadOnlyCollection<SchemaContext> contexts)
    {
        contexts = contexts ?? throw new ArgumentNullException(nameof(contexts));
        ApplyStableAnonymousUnionNames(contexts);
        var groups = new Dictionary<string, List<SchemaContext>>(StringComparer.OrdinalIgnoreCase);
        while (true)
        {
            groups.Clear();
            var hasCollisions = false;
            foreach (var context in contexts)
            {
                if (context.IsReference ||
                    // Already settled as a copy of another context, and deliberately keeps its
                    // name. Leaving it in the grouping would keep reporting a collision that is
                    // never resolved, and the loop below would not terminate.
                    context.IsStructuralDuplicate ||
                    context.IsNullableUnionWrapper ||
                    (!context.IsClass && !context.IsEnum && !context.IsAnyOfLikeStructure))
                {
                    continue;
                }
                var groupKey = $"{context.GetGeneratedNamespace()}|{context.Id}";
                if (!groups.TryGetValue(groupKey, out var list))
                {
                    list = [context];
                    groups[groupKey] = list;
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

                // Order the group by something that does not depend on how the contexts were
                // enumerated. Which member keeps the un-suffixed name used to fall out of
                // collection order, and the CLI and the Roslyn generator walk the graph
                // differently - so together.yaml generated `FineTuneEvent2` referencing
                // `FineTuneEventType` in one pipeline and `FineTuneEventType2` in the other, and
                // only one of them compiled. A schema named in `components` wins, and the owner
                // path breaks any remaining tie.
                group.Sort(static (left, right) =>
                {
                    var byComponent = (right.ComponentId != null).CompareTo(left.ComponentId != null);
                    return byComponent != 0
                        ? byComponent
                        : string.CompareOrdinal(
                            GetAnonymousUnionPath(left),
                            GetAnonymousUnionPath(right));
                });

                // Contexts that want the same name AND describe the same shape are not a collision:
                // the spec repeated one inline schema and a fresh context was built per occurrence.
                // Numbering them produced `InvalidTokenErrorBody11` and twenty-odd siblings - 55% of
                // every numbered name in the workspace. They keep the un-suffixed name and are
                // marked so only one model is emitted for them; the number is reserved for contexts
                // that really do describe something different.
                // The canonical member has to be one that actually emits a model, or its copies
                // would resolve to a type nothing defines. together.yaml is the case: the context
                // that sorts first there is filtered out, so pointing `FineTuneEvent2` at its
                // `FineTuneEventType` produced a reference to a type that was never generated.
                //
                // Taking the first member that DOES emit, and moving it to the front so the
                // un-suffixed name goes to a type that exists, was measured and rejected: across
                // the 120 snapshot specs it recovered only 2 of the 112 remaining copies and
                // removed 13 types, while adding 30 numbered names and renaming types in 28 specs.
                // More digits in names is the opposite of the point.
                var canEmit = group[0].IsModel && !group[0].IsFilteredOutModel;

                var number = 2;
                for (var i = 1; i < group.Count; i++)
                {
                    if (canEmit &&
                        OpenApiSchemaStructuralComparer.AreStructurallyEqual(
                            group[0].Schema,
                            group[i].Schema))
                    {
                        group[i].DuplicateOf = group[0];
                        // And it has to answer to the canonical member's name, not its own. The
                        // grouping is case-insensitive, so a duplicate's spelling is only the same
                        // as the canonical's when the collision was exact-case. together.yaml
                        // declares both `FinetuneEvent` and `FineTuneEvent`: their nested
                        // `...EventType` schemas collide, the canonical emits as
                        // `FinetuneEventType`, and a duplicate left holding `FineTuneEventType`
                        // made every reference to it point at a type nothing defines.
                        group[i].Id = group[0].Id;
                        continue;
                    }

                    group[i].DuplicateOf = null;
                    group[i].Id += $"{number}";
                    number++;
                }
            }
        }
    }

    private static bool UsesStableAnonymousUnionName(SchemaContext context) =>
        context.Settings.StableAnonymousUnionNames &&
        context.ComponentId == null &&
        !context.IsReference &&
        !context.IsNullableUnionWrapper &&
        context.IsAnyOfLikeStructure &&
        !(context.Settings.UseExtensionNaming &&
          OpenApiExtensions.TryGetTypeNameOverride(context.Schema.Extensions, out var name) &&
          !string.IsNullOrWhiteSpace(name));

    private static void ApplyStableAnonymousUnionNames(IReadOnlyCollection<SchemaContext> contexts)
    {
        foreach (var context in contexts.Where(UsesStableAnonymousUnionName))
        {
            var segments = new Stack<string>();
            for (var owner = context; owner != null; owner = owner.Parent)
            {
                if (owner.ComponentId != null)
                {
                    segments.Push(owner.ComputeClassName());
                    break;
                }
                if (owner.ComputeHelperName() is { } helper)
                {
                    segments.Push(helper);
                }
            }
            // Keep the full property path: included + Item must not collapse to Include.
            context.Id = CSharpPropertyNameGenerator.SanitizeName(
                string.Concat(segments).ToClassName(), context.Settings.ClsCompliantEnumPrefix,
                identifierCharacterSet: context.Settings.IdentifierCharacterSet);
            // Always include the owner's digest: adding a new path that normalizes to the
            // same C# name must not rename the existing union, either.
            var bytes = global::System.Text.Encoding.UTF8.GetBytes(GetAnonymousUnionPath(context));
#if NET6_0_OR_GREATER
            var digest = global::System.Security.Cryptography.SHA256.HashData(bytes);
#else
            using var hash = global::System.Security.Cryptography.SHA256.Create();
            var digest = hash.ComputeHash(bytes);
#endif
            context.Id += "_" + string.Concat(digest.Take(8).Select(value => value.ToString("x2", CultureInfo.InvariantCulture)));
            context.ClassName = context.Id;
        }
    }

    private static string GetAnonymousUnionPath(SchemaContext context)
    {
        var segments = new Stack<string>();
        for (var owner = context; owner != null; owner = owner.Parent)
        {
            // Length-prefix raw segments so separators in schema/property names cannot alias.
            var fields = new[]
            {
                owner.Hint?.ToString(), owner.ComponentId, owner.PropertyName,
                owner.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf ? owner.Index?.ToString(CultureInfo.InvariantCulture) : null,
                owner.OperationType?.ToString(), owner.OperationPath, owner.Operation?.OperationId,
                owner.Parameter?.Name, owner.ResponseStatusCode, owner.ContentType,
            };
            segments.Push(string.Concat(fields.Select(field => $"{field?.Length ?? 0}:{field}")));
            if (owner.ComponentId != null)
            {
                break;
            }
        }
        return string.Concat(segments);
    }

    private static int CountNonBasicTypes(IList<SchemaContext>? children)
    {
        if (children == null) return 0;
        var count = 0;
        for (var i = 0; i < children.Count; i++)
        {
            var x = children[i];
            if (x.IsEnum || x.IsClass || (x.IsAnyOf && x.IsComponent))
            {
                count++;
            }
        }
        return count;
    }

    private static int CountNonRefEnums(IList<SchemaContext>? children)
    {
        if (children == null) return 0;
        var count = 0;
        for (var i = 0; i < children.Count; i++)
        {
            if (children[i].IsEnum && !children[i].IsReference)
            {
                count++;
            }
        }
        return count;
    }

    public static void ResolveCollisions(IReadOnlyCollection<OperationContext> contexts)
    {
        contexts = contexts ?? throw new ArgumentNullException(nameof(contexts));

        var groups = new Dictionary<(string, string), List<OperationContext>>();
        while (true)
        {
            groups.Clear();
            var hasCollisions = false;
            foreach (var context in contexts)
            {
                var firstTag = string.Empty;
                foreach (var tag in context.Tags)
                {
                    firstTag = tag;
                    break;
                }
                var key = (context.MethodName, firstTag);
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

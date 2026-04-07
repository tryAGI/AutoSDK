using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Naming.Models;

public sealed class CSharpNamespacedTypeName
{
    public CSharpNamespacedTypeName(
        string className,
        string namespaceSuffix,
        string generatedNamespace,
        string generatedQualifiedName,
        string externalQualifiedName)
    {
        ClassName = className;
        NamespaceSuffix = namespaceSuffix;
        GeneratedNamespace = generatedNamespace;
        GeneratedQualifiedName = generatedQualifiedName;
        ExternalQualifiedName = externalQualifiedName;
    }

    public string ClassName { get; }

    public string NamespaceSuffix { get; }

    public string GeneratedNamespace { get; }

    public string GeneratedQualifiedName { get; }

    public string ExternalQualifiedName { get; }

    public string GetQualifiedName(ExcludedModelNamespaceMode mode)
    {
        return mode switch
        {
            ExcludedModelNamespaceMode.SdkRoot => GeneratedQualifiedName,
            _ => ExternalQualifiedName,
        };
    }
}

public static class CSharpNamespacedTypeNameResolver
{
    public static string GetGlobalClassName(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        return $"global::{context.GetGeneratedNamespace()}.{context.Id}";
    }

    public static string GetComponentClassName(string rawId, SchemaNamingSettings settings)
    {
        return TryResolve(rawId, settings, rootNamespace: string.Empty, out var resolved)
            ? resolved!.ClassName
            : rawId.ToCSharpName(settings, parent: null).ToClassName();
    }

    public static string GetGeneratedNamespace(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var componentId = FindOwningComponentId(context);
        return componentId != null &&
               TryResolve(componentId, context.Settings.ToSchemaNamingSettings(), context.Settings.Namespace, out var resolved)
            ? resolved!.GeneratedNamespace
            : context.Settings.Namespace;
    }

    public static bool TryResolve(
        string rawId,
        SchemaContextSettings settings,
        out CSharpNamespacedTypeName? resolved)
    {
        return TryResolve(rawId, settings.ToSchemaNamingSettings(), settings.Namespace, out resolved);
    }

    public static bool TryResolve(
        string rawId,
        SchemaNamingSettings settings,
        string rootNamespace,
        out CSharpNamespacedTypeName? resolved)
    {
        rawId = rawId ?? throw new ArgumentNullException(nameof(rawId));

        var delimiter = settings.NamespaceDelimiter;
        if (string.IsNullOrEmpty(delimiter))
        {
            resolved = default;
            return false;
        }

        if (delimiter.Length != 1)
        {
            throw new ArgumentException("NamespaceDelimiter must be empty or a single character.", nameof(settings));
        }

        var delimiterChar = delimiter[0];
        if (rawId.IndexOf(delimiterChar) < 0)
        {
            resolved = default;
            return false;
        }

        var segments = rawId
            .Split([delimiterChar], StringSplitOptions.RemoveEmptyEntries)
            .Select(segment => SanitizeSegment(segment.Trim(), settings))
            .Where(static segment => !string.IsNullOrWhiteSpace(segment))
            .ToArray();

        if (segments.Length < 2)
        {
            resolved = default;
            return false;
        }

        var className = segments[segments.Length - 1];
        var namespaceSuffix = string.Join(".", segments, 0, segments.Length - 1);
        var generatedNamespace = string.IsNullOrWhiteSpace(rootNamespace)
            ? namespaceSuffix
            : $"{rootNamespace}.{namespaceSuffix}";
        var generatedQualifiedName = $"{generatedNamespace}.{className}";
        var externalQualifiedName = $"{namespaceSuffix}.{className}";

        resolved = new CSharpNamespacedTypeName(
            className: className,
            namespaceSuffix: namespaceSuffix,
            generatedNamespace: generatedNamespace,
            generatedQualifiedName: generatedQualifiedName,
            externalQualifiedName: externalQualifiedName);
        return true;
    }

    private static string? FindOwningComponentId(SchemaContext? context)
    {
        while (context != null)
        {
            if (!string.IsNullOrWhiteSpace(context.ComponentId))
            {
                return context.ComponentId;
            }

            context = context.Parent;
        }

        return null;
    }

    private static string SanitizeSegment(string segment, SchemaNamingSettings settings)
    {
        var name = segment.ToPropertyName();
        name = CSharpPropertyNameGenerator.HandleWordSeparators(name);
        return CSharpPropertyNameGenerator.SanitizeName(
            name,
            settings.ClsCompliantEnumPrefix,
            skipHandlingWordSeparators: true,
            identifierCharacterSet: settings.IdentifierCharacterSet);
    }
}

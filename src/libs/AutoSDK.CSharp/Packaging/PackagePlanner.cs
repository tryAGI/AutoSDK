using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;

namespace AutoSDK.Packaging;

/// <summary>
/// Turns an enriched <see cref="Data"/> model into a deterministic package graph.
/// </summary>
/// <remarks>
/// Pure and I/O-free so it can be unit tested directly against a <see cref="Data"/> value. Reading
/// the tag override file is the caller's job — the CLI parses it and passes the result in, because
/// this assembly also targets netstandard2.0/net462 where System.Text.Json is unavailable.
/// </remarks>
public static class PackagePlanner
{
    /// <summary>
    /// Package id suffix appended to a tag whose package would otherwise collide with the base or
    /// core package id.
    /// </summary>
    private const string ReservedNameSuffix = "Api";

    /// <summary>
    /// Suffix appended to the base package id to form the shared package.
    /// </summary>
    public const string CoreSuffix = "Core";

    /// <summary>
    /// Builds the package graph, or explains why the document cannot be split.
    /// </summary>
    /// <param name="data">The enriched model produced by the C# pipeline.</param>
    /// <param name="tagPackageOverrides">
    /// Optional OpenAPI tag name to package suffix overrides. Several tags may map to the same
    /// suffix to group them into one package.
    /// </param>
    /// <param name="plan">The resulting plan when this method returns <see langword="true"/>.</param>
    /// <param name="error">A user-facing explanation when this method returns <see langword="false"/>.</param>
    public static bool TryCreate(
        Data data,
        IReadOnlyDictionary<string, string>? tagPackageOverrides,
        out PackagePlan? plan,
        out string? error)
    {
        plan = null;
        error = null;

        var settings = data.Converters.Settings;

        if (string.IsNullOrWhiteSpace(settings.Namespace))
        {
            error = "Split-by-tags generation requires --namespace.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(settings.ClassName))
        {
            error = "Split-by-tags generation requires --clientClassName so the root client's files can be routed to the base package.";
            return false;
        }

        // CorePipeline turns GroupByTags off for documents with fewer than two tags, which would
        // otherwise produce a "family" of one package plus an empty Core.
        if (!settings.GroupByTags || data.Tags.Length < 2)
        {
            error =
                "Split-by-tags generation needs a specification with at least two OpenAPI tags and tag grouping enabled. " +
                $"This specification produced {data.Tags.Length} tag(s). Generate it as a single project instead.";
            return false;
        }

        var namespaceValue = settings.Namespace;
        var basePackageId = string.IsNullOrWhiteSpace(settings.BasePackageId)
            ? namespaceValue
            : settings.BasePackageId.Trim();
        var corePackageId = $"{basePackageId}.{CoreSuffix}";
        var rootClassName = settings.ClassName.Replace(".", string.Empty);

        var tagPackageIds = BuildTagPackageIds(
            data.Tags,
            tagPackageOverrides,
            basePackageId,
            corePackageId);

        var fileToPackageId = new Dictionary<string, string>(StringComparer.Ordinal);
        var clientClassNamesByPackage = new Dictionary<string, SortedSet<string>>(StringComparer.Ordinal);
        var tagNamesByPackage = new Dictionary<string, SortedSet<string>>(StringComparer.Ordinal);

        foreach (var tag in data.Tags)
        {
            if (tag.Name is null || !tagPackageIds.TryGetValue(tag.Name, out var tagPackageId))
            {
                continue;
            }

            if (!tagNamesByPackage.TryGetValue(tagPackageId, out var tagNames))
            {
                tagNames = new SortedSet<string>(StringComparer.Ordinal);
                tagNamesByPackage[tagPackageId] = tagNames;
            }

            tagNames.Add(tag.Name);
        }

        // Tag clients: one `Client` per tag, plus its interface.
        foreach (var client in data.Clients)
        {
            if (!string.Equals(client.Id, "Constructors", StringComparison.Ordinal))
            {
                continue;
            }

            var tagPackageId = ResolveClientPackageId(client.ClassName, data.Tags, tagPackageIds);
            if (tagPackageId is null)
            {
                continue;
            }

            Assign(fileToPackageId, $"{client.FileNameWithoutExtension}.g.cs", tagPackageId);
            Assign(fileToPackageId, $"{client.InterfaceFileNameWithoutExtension}.g.cs", tagPackageId);
            AddClientClassName(clientClassNamesByPackage, tagPackageId, client.ClassName);
        }

        // Operation partials. Untagged operations are partials of the root client class, so they
        // are deliberately left unmapped and fall through to the facade.
        foreach (var endPoint in data.Methods)
        {
            if (string.IsNullOrEmpty(endPoint.Tag.Name) ||
                !tagPackageIds.TryGetValue(endPoint.Tag.Name!, out var tagPackageId))
            {
                continue;
            }

            Assign(fileToPackageId, $"{endPoint.FileNameWithoutExtension}.g.cs", tagPackageId);
            Assign(fileToPackageId, $"{endPoint.InterfaceFileNameWithoutExtension}.g.cs", tagPackageId);
        }

        AssignModelFiles(data, tagPackageIds, fileToPackageId);

        var packages = ImmutableArray.CreateBuilder<PackageDescriptor>();
        packages.Add(new PackageDescriptor(
            PackageId: corePackageId,
            Kind: PackageKind.Core,
            Tags: ImmutableArray<string>.Empty,
            ClientClassNames: ImmutableArray<string>.Empty));

        foreach (var tagPackageId in tagPackageIds.Values.Distinct(StringComparer.Ordinal).OrderBy(static x => x, StringComparer.Ordinal))
        {
            packages.Add(new PackageDescriptor(
                PackageId: tagPackageId,
                Kind: PackageKind.Tag,
                Tags: tagNamesByPackage.TryGetValue(tagPackageId, out var tagNames)
                    ? tagNames.ToImmutableArray()
                    : ImmutableArray<string>.Empty,
                ClientClassNames: clientClassNamesByPackage.TryGetValue(tagPackageId, out var classNames)
                    ? classNames.ToImmutableArray()
                    : ImmutableArray<string>.Empty));
        }

        packages.Add(new PackageDescriptor(
            PackageId: basePackageId,
            Kind: PackageKind.Facade,
            Tags: ImmutableArray<string>.Empty,
            ClientClassNames: [rootClassName]));

        plan = new PackagePlan(
            BasePackageId: basePackageId,
            Namespace: namespaceValue,
            TargetFramework: settings.TargetFramework,
            RootClientFilePrefixes: BuildRootClientFilePrefixes(namespaceValue, rootClassName, settings.ClassName),
            Packages: packages.ToImmutable(),
            FileToPackageId: fileToPackageId);
        return true;
    }

    /// <summary>
    /// Routes the files of every model a single tag exclusively owns into that tag's package.
    /// </summary>
    /// <remarks>
    /// A model contributes more than one file and they are not all under the same name prefix --
    /// an enum's converters sit under <c>{Namespace}.JsonConverters.</c> rather than
    /// <c>{Namespace}.Models.</c> -- so the names are derived from the emitters rather than matched
    /// by prefix. Assigning a name no emitter produces is harmless: the map is consulted per
    /// emitted file.
    /// </remarks>
    private static void AssignModelFiles(
        Data data,
        Dictionary<string, string> tagPackageIds,
        Dictionary<string, string> fileToPackageId)
    {
        var owners = ModelOwnershipResolver.Resolve(data);
        if (owners.Count == 0)
        {
            return;
        }

        foreach (var model in data.Classes.Concat(data.Enums))
        {
            if (!owners.TryGetValue(model.GlobalClassName, out var tag) ||
                !tagPackageIds.TryGetValue(tag, out var packageId))
            {
                continue;
            }

            Assign(fileToPackageId, $"{model.FileNameWithoutExtension}.g.cs", packageId);
            Assign(fileToPackageId, $"{model.FileNameWithoutExtension}.Json.g.cs", packageId);
            Assign(fileToPackageId, $"{model.FileNameWithoutExtension}.IValidatableObject.g.cs", packageId);
            Assign(fileToPackageId, $"{model.FileNameWithoutExtension}.BinaryPayloads.g.cs", packageId);

            if (model.Style == ModelStyle.Enumeration)
            {
                Assign(fileToPackageId, $"{model.Namespace}.JsonConverters.{model.ClassName}.g.cs", packageId);
                Assign(fileToPackageId, $"{model.Namespace}.JsonConverters.{model.ClassName}Nullable.g.cs", packageId);
            }
        }

        foreach (var anyOf in data.AnyOfs)
        {
            if (!anyOf.IsNamed ||
                !owners.TryGetValue($"global::{anyOf.Namespace}.{anyOf.Name}", out var tag) ||
                !tagPackageIds.TryGetValue(tag, out var packageId))
            {
                continue;
            }

            var name = $"{anyOf.Namespace}.Models.{anyOf.Name}";
            Assign(fileToPackageId, $"{name}.g.cs", packageId);
            Assign(fileToPackageId, $"{name}.Json.g.cs", packageId);
            Assign(fileToPackageId, $"{name}.IValidatableObject.g.cs", packageId);
            Assign(fileToPackageId, $"{anyOf.Namespace}.JsonConverters.{anyOf.Name}.g.cs", packageId);
        }

        // Each tag that owns models gets its own serializer context, chained onto Core's. Their
        // file names sit outside the root-client prefixes, so they need routing explicitly; the
        // facade's context is named after the root client and already falls through to the base
        // package on the prefix rule.
        var settings = data.Converters.Settings;
        var owningTags = new HashSet<string>(owners.Values, StringComparer.Ordinal);
        foreach (var tag in data.Tags)
        {
            if (tag.Name is null ||
                !owningTags.Contains(tag.Name) ||
                !tagPackageIds.TryGetValue(tag.Name, out var packageId))
            {
                continue;
            }

            Assign(fileToPackageId, $"{settings.Namespace}.{tag.SafeName}.JsonSerializerContext.g.cs", packageId);
        }
    }

    private static ImmutableArray<string> BuildRootClientFilePrefixes(
        string namespaceValue,
        string rootClassName,
        string rawClassName)
    {
        // `Sources.Client` names files from the dot-stripped class name while
        // `Sources.Authorization` uses the raw `Settings.ClassName`, so both spellings can appear.
        var prefixes = new SortedSet<string>(StringComparer.Ordinal)
        {
            $"{namespaceValue}.{rootClassName}.",
            $"{namespaceValue}.I{rootClassName}.",
        };

        if (!string.Equals(rootClassName, rawClassName, StringComparison.Ordinal))
        {
            prefixes.Add($"{namespaceValue}.{rawClassName}.");
            prefixes.Add($"{namespaceValue}.I{rawClassName}.");
        }

        return prefixes.ToImmutableArray();
    }

    private static Dictionary<string, string> BuildTagPackageIds(
        EquatableArray<Tag> tags,
        IReadOnlyDictionary<string, string>? tagPackageOverrides,
        string basePackageId,
        string corePackageId)
    {
        var result = new Dictionary<string, string>(StringComparer.Ordinal);

        foreach (var tag in tags.OrderBy(static x => x.SafeName, StringComparer.Ordinal))
        {
            if (tag.Name is null)
            {
                continue;
            }

            string? overrideSuffix = null;
            tagPackageOverrides?.TryGetValue(tag.Name, out overrideSuffix);

            var suffix = SanitizeSuffix(overrideSuffix) ?? tag.SafeName;
            if (string.IsNullOrEmpty(suffix))
            {
                continue;
            }

            var packageId = $"{basePackageId}.{suffix}";

            // A tag literally called "Core" (or one whose override says so) would shadow the
            // shared package; a tag whose suffix collapses onto the base id would shadow the
            // facade. Both are resolved the same deterministic way.
            if (string.Equals(packageId, corePackageId, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(packageId, basePackageId, StringComparison.OrdinalIgnoreCase))
            {
                packageId = $"{basePackageId}.{suffix}{ReservedNameSuffix}";
            }

            result[tag.Name] = packageId;
        }

        return result;
    }

    /// <summary>
    /// Keeps an override suffix to characters that are valid in both a NuGet package id and a
    /// directory name, so a hand-written override file cannot produce an unbuildable tree.
    /// </summary>
    private static string? SanitizeSuffix(string? suffix)
    {
        if (string.IsNullOrWhiteSpace(suffix))
        {
            return null;
        }

        var builder = new StringBuilder(suffix!.Length);
        foreach (var character in suffix)
        {
            if (char.IsLetterOrDigit(character) || character == '_' || character == '.' || character == '-')
            {
                builder.Append(character);
            }
        }

        var sanitized = builder.ToString().Trim('.', '-');

        return sanitized.Length == 0 || char.IsDigit(sanitized[0])
            ? null
            : sanitized;
    }

    private static string? ResolveClientPackageId(
        string clientClassName,
        EquatableArray<Tag> tags,
        Dictionary<string, string> tagPackageIds)
    {
        foreach (var tag in tags)
        {
            if (tag.Name is not null &&
                string.Equals(CSharpClientNameGenerator.Generate(tag), clientClassName, StringComparison.Ordinal) &&
                tagPackageIds.TryGetValue(tag.Name, out var packageId))
            {
                return packageId;
            }
        }

        return null;
    }

    private static void Assign(
        Dictionary<string, string> fileToPackageId,
        string fileName,
        string packageId)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return;
        }

        fileToPackageId[fileName] = packageId;
    }

    private static void AddClientClassName(
        Dictionary<string, SortedSet<string>> clientClassNamesByPackage,
        string packageId,
        string clientClassName)
    {
        if (!clientClassNamesByPackage.TryGetValue(packageId, out var classNames))
        {
            classNames = new SortedSet<string>(StringComparer.Ordinal);
            clientClassNamesByPackage[packageId] = classNames;
        }

        classNames.Add(clientClassName);
    }
}

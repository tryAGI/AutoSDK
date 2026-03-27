using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Parameters;

namespace AutoSDK.Enrichment;

public static class CSharpModelDataFactory
{
    public static ModelData CreateModelData(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var parentCount = 0;
        var parent = context.Parent;
        while (parent != null)
        {
            if (parent.ClassData.HasValue)
            {
                parentCount++;
            }

            parent = parent.Parent;
        }

        var boxedParents = ImmutableArray<Box>.Empty;
        if (parentCount > 0)
        {
            var builder = ImmutableArray.CreateBuilder<Box>(parentCount);
            var parentArray = new ModelData[parentCount];
            var index = parentCount - 1;
            parent = context.Parent;
            while (parent != null)
            {
                if (parent.ClassData.HasValue)
                {
                    parentArray[index--] = parent.ClassData!.Value;
                }

                parent = parent.Parent;
            }

            foreach (var item in parentArray)
            {
                builder.Add(item.Box());
            }

            boxedParents = builder.MoveToImmutable();
        }

        var mapping = context.Schema.Discriminator?.Mapping;
        EquatableArray<(string ClassName, string Discriminator)> derivedTypes = default;
        if (mapping is { Count: > 0 })
        {
            var builder = ImmutableArray.CreateBuilder<(string ClassName, string Discriminator)>(mapping.Count);
            foreach (var kvp in mapping.OrderBy(x => x.Key, StringComparer.Ordinal))
            {
                builder.Add((ClassName: kvp.Value.Reference?.Id ?? string.Empty, Discriminator: kvp.Key));
            }

            derivedTypes = builder.MoveToImmutable().AsEquatableArray();
        }

        var className = context.Id;
        var externalClassName = context.Settings.NamingConvention switch
        {
            NamingConvention.ConcatNames => className,
            NamingConvention.InnerClasses => string.Join(
                ".",
                boxedParents.Select(x => x.Unbox<ModelData>().ClassName).Concat([className])),
            _ => string.Empty,
        };

        return new ModelData(
            SchemaContext: context,
            Id: context.Id,
            Parents: boxedParents,
            Namespace: context.Settings.Namespace,
            Settings: context.Settings.ToEmitterSettings(),
            Style: context.Schema.IsEnum() ? ModelStyle.Enumeration : context.Settings.ModelStyle,
            Properties: GetVisibleProperties(context),
            EnumValues: context.Schema.IsEnum()
                ? ToImmutablePropertyDataArray(context.ComputeEnum())
                : [],
            Summary: context.Schema.GetSummary(),
            Description: context.Schema.Description ?? string.Empty,
            IsDeprecated: context.Schema.IsDeprecated(),
            DeprecationMessage: context.Schema.GetDeprecationMessage(),
            BaseClass: context.IsDerivedClass
                ? context.BaseClassContext.Id
                : string.Empty,
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
            DiscriminatorPropertyName: context.Schema.Discriminator?.PropertyName ?? string.Empty,
            DerivedTypes: derivedTypes,
            ClassName: className,
            GlobalClassName: $"global::{context.Settings.Namespace}.{className}",
            ExternalClassName: externalClassName,
            FileNameWithoutExtension: $"{context.Settings.Namespace}.Models.{externalClassName}");
    }

    private static ImmutableArray<PropertyData> GetVisibleProperties(SchemaContext context)
    {
        var source = context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : !context.Schema.IsEnum()
                ? context.Children
                : null;

        if (source == null || source.Count == 0)
        {
            return [];
        }

        var discriminatorPropertyName = context.IsBaseClass
            ? context.Schema.Discriminator?.PropertyName
            : null;
        var hasDiscriminator = !string.IsNullOrWhiteSpace(discriminatorPropertyName);

        var builder = ImmutableArray.CreateBuilder<PropertyData>(source.Count);
        for (var i = 0; i < source.Count; i++)
        {
            var child = source[i];
            if (child is not { IsProperty: true, PropertyData: not null })
            {
                continue;
            }

            foreach (var prop in child.ComputedProperties)
            {
                if (!hasDiscriminator || prop.Id != discriminatorPropertyName)
                {
                    builder.Add(prop);
                }
            }
        }

        return DeduplicatePropertyNamesCaseInsensitive(builder.ToImmutable());
    }

    private static ImmutableArray<PropertyData> DeduplicatePropertyNamesCaseInsensitive(
        ImmutableArray<PropertyData> properties)
    {
        if (properties.Length <= 1)
        {
            return properties;
        }

        var nameCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        for (var i = 0; i < properties.Length; i++)
        {
            nameCounts.TryGetValue(properties[i].Name, out var count);
            nameCounts[properties[i].Name] = count + 1;
        }

        var hasCaseCollision = false;
        foreach (var kvp in nameCounts)
        {
            if (kvp.Value > 1)
            {
                hasCaseCollision = true;
                break;
            }
        }

        if (!hasCaseCollision)
        {
            return properties;
        }

        var suffixCounters = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var builder = ImmutableArray.CreateBuilder<PropertyData>(properties.Length);
        for (var i = 0; i < properties.Length; i++)
        {
            var prop = properties[i];
            if (nameCounts[prop.Name] > 1)
            {
                suffixCounters.TryGetValue(prop.Name, out var suffix);
                suffix++;
                suffixCounters[prop.Name] = suffix;
                builder.Add(suffix == 1
                    ? prop
                    : (prop with { Name = $"{prop.Name}{suffix}" }).WithCSharpParameterName());
            }
            else
            {
                builder.Add(prop);
            }
        }

        return builder.MoveToImmutable();
    }

    private static ImmutableArray<PropertyData> ToImmutablePropertyDataArray(Dictionary<string, PropertyData> dict)
    {
        if (dict.Count == 0)
        {
            return [];
        }

        var builder = ImmutableArray.CreateBuilder<PropertyData>(dict.Count);
        foreach (var kvp in dict.OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            builder.Add(kvp.Value);
        }

        return builder.MoveToImmutable();
    }
}

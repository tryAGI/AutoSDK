using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.AnyOfs;
using AutoSDK.Naming.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Json;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.Enrichment;

public static class CSharpSchemaDataFactory
{
    public static PropertyData CreatePropertyData(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var type = context.TypeData;

        if (context.IsAllOfForMetadata &&
            !type.SubTypes.IsEmpty)
        {
            var subType = type.SubTypes[0].Unbox<TypeData>();
            type = subType.CSharpTypeNullability != type.CSharpTypeNullability
                ? (subType with { CSharpTypeNullability = type.CSharpTypeNullability }).WithCSharpComputedValues()
                : subType;
        }

        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var parentRequired = context.Parent?.Schema.Required;
        var isRequired =
            parentRequired != null &&
            parentRequired.Contains(propertyName) &&
            context.Schema is { WriteOnly: false };
        if (isRequired && type is { IsEnum: true, EnumValues.Length: 1 })
        {
            isRequired = false;
        }
        if (isRequired && context.Schema.IsConst())
        {
            isRequired = false;
        }
        if (isRequired && type.CSharpTypeNullability)
        {
            isRequired = false;
        }

        var isWriteOnly = context.Schema is { WriteOnly: true };
        var finalType = isWriteOnly && !type.CSharpTypeNullability
            ? (type with { CSharpTypeNullability = true }).WithCSharpComputedValues()
            : type;

        return new PropertyData(
            Id: propertyName,
            Name: CSharpPropertyNameGenerator.ComputePropertyName(context),
            ParameterName: string.Empty,
            Type: finalType,
            IsRequired: isRequired && context.Schema is { ReadOnly: false },
            IsReadOnly: context.Schema.ReadOnly,
            IsWriteOnly: context.Schema.WriteOnly,
            IsMultiPartFormDataFilename: false,
            Settings: context.Settings.ToEmitterSettings(),
            IsDeprecated: context.Schema.IsDeprecated(),
            DefaultValue: context.Schema is { ReadOnly: true } && !type.CSharpTypeNullability
                ? "default!"
                : context.GetDefaultValue(),
            Example: context.Schema.Example?.GetString() is { } example &&
                     !string.IsNullOrWhiteSpace(example)
                ? example.ClearForXml()
                : null,
            MinLength: context.Schema.MinLength,
            MaxLength: context.Schema.MaxLength,
            MinItems: context.Schema.MinItems,
            MaxItems: context.Schema.MaxItems,
            Pattern: context.Schema.Pattern ?? string.Empty,
            Minimum: context.Schema.Minimum ?? string.Empty,
            Maximum: context.Schema.Maximum ?? string.Empty,
            ExclusiveMinimum: context.Schema.ExclusiveMinimum ?? string.Empty,
            ExclusiveMaximum: context.Schema.ExclusiveMaximum ?? string.Empty,
            Summary: context.Schema.GetSummary(),
            Description: context.Schema.Description ?? string.Empty,
            ConverterType: type.ConverterType,
            DiscriminatorValue: string.Empty,
            JsonPropertyNames: ImmutableArray<string>.Empty.AsEquatableArray())
            .WithCSharpParameterName();
    }

    public static MethodParameter CreateMethodParameter(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var parameter = context.Parameter ?? throw new InvalidOperationException("Parameter or parameter data is required.");
        var parameterName = context.ParameterName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        var type = context.TypeData;
        if (parameter.In == ParameterLocation.Query &&
            (context.IsClass || context.ResolvedReference?.IsClass == true))
        {
            var props = (context.ResolvedReference?.ClassData ?? context.ClassData)?.Properties;
            if (props is { Length: > 0 })
            {
                for (var i = 0; i < props.Value.Length; i++)
                {
                    if (props.Value[i].Id == parameterName)
                    {
                        type = props.Value[i].Type;
                        break;
                    }
                }
            }
        }

        var name = parameterName.ToPropertyName();
        name = CSharpPropertyNameGenerator.HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = CSharpPropertyNameGenerator.SanitizeName(
            name,
            context.Settings.ClsCompliantEnumPrefix,
            true,
            context.Settings.IdentifierCharacterSet);

        var isRequired =
            parameter.Required ||
            parameter.In == ParameterLocation.Path;

        return new MethodParameter(
            Id: parameterName,
            Name: name,
            ParameterName: string.Empty,
            ArgumentName: string.Empty,
            Value: string.Empty,
            Delimiter: string.Empty,
            Selector: string.Empty,
            Type: type,
            IsRequired: isRequired,
            IsMultiPartFormDataFilename: false,
            Location: parameter.In,
            Style: parameter.Style,
            Explode: parameter.Explode,
            Settings: context.Settings.ToEmitterSettings(),
            IsDeprecated: context.Schema.IsDeprecated(),
            DefaultValue: context.GetDefaultValue(),
            Summary: context.Schema.GetSummary(),
            Description:
                context.Parameter?.Description ??
                context.Schema.Description ??
                string.Empty,
            ConverterType: type.ConverterType,
            Properties: context.ClassData?.Properties ?? [],
            HasSchemaDefault: false,
            ParameterDefaultValue: "default",
            ProducesDeprecationWarning: false,
            DisableDeprecationWarningIfRequired: " ")
            .WithCSharpParameterNames()
            .WithCSharpComputedValues();
    }

    public static AnyOfData CreateAnyOfData(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        var targetHint = context.IsAnyOf
            ? Hint.AnyOf
            : context.IsOneOf
                ? Hint.OneOf
                : Hint.AllOf;

        var children = new List<SchemaContext>();
        for (var i = 0; i < context.Children.Count; i++)
        {
            if (context.Children[i].Hint == targetHint)
            {
                children.Add(context.Children[i]);
            }
        }

        var className = context.Id.ToClassName();
        TypeData? discriminatorType = null;
        string? discriminatorPropertyName = null;

        if (context.Schema.Discriminator != null &&
            (context.Schema.Discriminator.Mapping?.Count ?? 0) != 0)
        {
            for (var i = 0; i < context.Children.Count; i++)
            {
                if (context.Children[i].Hint == Hint.Discriminator)
                {
                    discriminatorType = context.Children[i].TypeData;
                    break;
                }
            }

            discriminatorPropertyName = (context.Schema.Discriminator.PropertyName ?? string.Empty).ToPropertyName()
                .ToCSharpName(context.Settings, context.Parent);
        }

        var count = context.IsAnyOf
            ? context.Schema.AnyOf?.Count ?? 0
            : context.IsOneOf
                ? context.Schema.OneOf?.Count ?? 0
                : context.Schema.AllOf?.Count ?? 0;
        var discriminatorPropName = context.Schema.Discriminator?.PropertyName ?? string.Empty;
        EquatableArray<PropertyData> properties;
        if (context.IsNamedAnyOfLike)
        {
            var builder = ImmutableArray.CreateBuilder<PropertyData>(children.Count);
            for (var i = 0; i < children.Count; i++)
            {
                var child = children[i];
                var discriminatorValue = ComputeDiscriminatorValue(context, child, discriminatorPropName);

                var titleName = !string.IsNullOrWhiteSpace(child.Schema.Title)
                    ? child.Schema.Title!.ToClassName()
                    : null;
                var name = !string.IsNullOrWhiteSpace(discriminatorValue)
                    ? discriminatorValue
                    : titleName != null && !string.Equals(titleName, className, StringComparison.OrdinalIgnoreCase)
                        ? titleName
                        : SmartNamedAnyOfNames.ComputePropertyName(children, className, i, context.Settings.IdentifierCharacterSet);
                name = name.ToCSharpName(context.Settings, context.Parent);
                name = CSharpPropertyNameGenerator.AvoidObjectMemberNameCollision(name);
                name = AvoidNamedAnyOfMemberNameCollision(name);

                var resolvedSchema = child.Schema.ResolveIfRequired();
                var jsonPropertyNames = ImmutableArray<string>.Empty;
                if (resolvedSchema.Properties is { Count: > 0 } props)
                {
                    var jpnBuilder = ImmutableArray.CreateBuilder<string>(props.Count);
                    foreach (var key in props.Keys.OrderBy(x => x, StringComparer.Ordinal))
                    {
                        jpnBuilder.Add(key);
                    }

                    jsonPropertyNames = jpnBuilder.MoveToImmutable();
                }

                builder.Add((PropertyData.Default with
                {
                    Type = child.TypeData,
                    Name = name,
                    Summary = child.Schema.GetSummary(),
                    DiscriminatorValue = discriminatorValue,
                    JsonPropertyNames = jsonPropertyNames.AsEquatableArray(),
                }).WithCSharpParameterName());
            }

            properties = builder.MoveToImmutable().AsEquatableArray();
        }
        else
        {
            var builder = ImmutableArray.CreateBuilder<PropertyData>(count);
            for (var i = 1; i <= count; i++)
            {
                builder.Add((PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = (TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                        GeneratedNamespace = context.GetGeneratedNamespace(),
                    }).WithCSharpComputedValues(),
                }).WithCSharpParameterName());
            }

            properties = builder.MoveToImmutable().AsEquatableArray();
        }

        if (context.IsNamedAnyOfLike && !properties.IsEmpty)
        {
            properties = DeduplicatePropertyNames(properties);
        }

        return new AnyOfData(
            SubType: context.IsAnyOf
                ? "AnyOf"
                : context.IsOneOf
                    ? "OneOf"
                    : "AllOf",
            Count: count,
            DiscriminatorType: discriminatorType,
            DiscriminatorPropertyName: discriminatorPropertyName,
            IsTrimming: context.Settings.UsesSystemTextJsonContext(),
            Namespace: context.GetGeneratedNamespace(),
            Name: context.IsNamedAnyOfLike
                ? context.Id
                : string.Empty,
            Summary: context.IsNamedAnyOfLike
                ? context.Schema.GetSummary()
                : string.Empty,
            Properties: properties,
            Settings: context.Settings.ToEmitterSettings());
    }

    private static string ComputeDiscriminatorValue(
        SchemaContext context,
        SchemaContext child,
        string discriminatorPropName)
    {
        if (string.IsNullOrEmpty(discriminatorPropName))
        {
            return string.Empty;
        }

        var hasChildDiscProp = child.Schema.Properties?.ContainsKey(discriminatorPropName) == true;
        var childDiscProp = hasChildDiscProp ? child.Schema.Properties![discriminatorPropName] : null;

        var mapping = context.Schema.Discriminator?.Mapping;
        if (mapping != null)
        {
            string? childEnumStr = null;
            if (childDiscProp != null && (childDiscProp.Enum?.Count ?? 0) == 1)
            {
                childEnumStr = childDiscProp.Enum![0]?.GetString();
            }

            foreach (var kvp in mapping)
            {
                if (kvp.Value.Reference?.Id?.Contains(child.Id) == true ||
                    childEnumStr != null && childEnumStr == kvp.Key)
                {
                    return kvp.Key.ToEnumValue(string.Empty, context.Settings.ToEnumNamingSettings()).Name;
                }
            }
        }

        if (childDiscProp != null)
        {
            if (!string.IsNullOrEmpty(childDiscProp.Const))
            {
                return childDiscProp.Const!.ToEnumValue(string.Empty, context.Settings.ToEnumNamingSettings()).Name;
            }

            if ((childDiscProp.Enum?.Count ?? 0) == 1)
            {
                var enumValue = childDiscProp.Enum![0]?.GetString();
                if (!string.IsNullOrEmpty(enumValue))
                {
                    return enumValue!.ToEnumValue(string.Empty, context.Settings.ToEnumNamingSettings()).Name;
                }
            }
        }

        return string.Empty;
    }

    private static EquatableArray<PropertyData> DeduplicatePropertyNames(
        EquatableArray<PropertyData> properties)
    {
        var names = new string[properties.Length];
        var nameCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        for (var i = 0; i < properties.Length; i++)
        {
            names[i] = properties[i].Name;
            nameCounts.TryGetValue(names[i], out var count);
            nameCounts[names[i]] = count + 1;
        }

        var hasDuplicates = false;
        foreach (var kvp in nameCounts)
        {
            if (kvp.Value > 1)
            {
                hasDuplicates = true;
                break;
            }
        }
        if (!hasDuplicates)
        {
            return properties;
        }

        var suffixes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        for (var i = 0; i < names.Length; i++)
        {
            if (nameCounts[names[i]] > 1)
            {
                suffixes.TryGetValue(names[i], out var suffix);
                suffix++;
                suffixes[names[i]] = suffix;
                names[i] = $"{names[i]}{suffix}";
            }
        }

        var builder = ImmutableArray.CreateBuilder<PropertyData>(properties.Length);
        for (var i = 0; i < properties.Length; i++)
        {
            builder.Add(properties[i].Name != names[i]
                ? (properties[i] with { Name = names[i] }).WithCSharpParameterName()
                : properties[i]);
        }

        return builder.MoveToImmutable().AsEquatableArray();
    }

    private static string AvoidNamedAnyOfMemberNameCollision(string name)
    {
        return name switch
        {
            "Object" => "ObjectValue",
            "Match" => "MatchValue",
            "Validate" => "ValidateValue",
            _ => name,
        };
    }
}

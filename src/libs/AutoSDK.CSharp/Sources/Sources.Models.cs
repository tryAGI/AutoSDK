using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var suppressObsoleteWarnings =
            HasDeprecatedTypeReferences(modelData) ||
            HasDeprecatedBaseClass(modelData);

        return $@"
{(suppressObsoleteWarnings ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : TrimmedLine)}
#nullable enable

namespace {modelData.Namespace}
{{
{GenerateModel(modelData, level: 0, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateModel(
        ModelData modelData,
        int level,
        CancellationToken cancellationToken = default)
    {
        if (modelData.Settings.NamingConvention == NamingConvention.ConcatNames ||
            level == modelData.Parents.AsSpan().Length)
        {
            return modelData.Style switch
            {
                ModelStyle.Class => GenerateClassModel(modelData, cancellationToken),
                ModelStyle.Enumeration =>
                    GenerateEnumerationModel(modelData, cancellationToken) + "\n\n" +
                    GenerateEnumExtensions(modelData, cancellationToken),
                _ => throw new NotSupportedException($"Model style {modelData.Style} is not supported."),
            };
        }

        return $@" 
public sealed partial class {modelData.Parents[level].Unbox<ModelData>().ClassName}
{{
{GenerateModel(modelData, level + 1, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces().AddIndent(level: 1);
    }

    private static bool IsSupported(SdkFeatureUsage usage, string targetFramework)
    {
        return usage switch
        {
            SdkFeatureUsage.Always => true,
            SdkFeatureUsage.InSupportedTargetFrameworks
                when IsNetVersionAtLeast(targetFramework, 8) => true,
            _ => false,
        };
    }

    private static bool IsNetVersionAtLeast(string targetFramework, int minMajor)
    {
        // Match "net" followed by digits (e.g., "net8.0", "net10.0")
        // Exclude "netstandard" and "netcoreapp" prefixes
        if (!targetFramework.StartsWith("net", StringComparison.OrdinalIgnoreCase) ||
            targetFramework.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase) ||
            targetFramework.StartsWith("netcoreapp", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var versionPart = targetFramework.Substring(3); // Remove "net"
        var dotIndex = versionPart.IndexOf('.');
        var majorStr = dotIndex >= 0 ? versionPart.Substring(0, dotIndex) : versionPart;

        return int.TryParse(majorStr, out var major) && major >= minMajor;
    }

    private static string GetDefaultValue(PropertyData property, bool isRequiredKeywordSupported)
    {
        if (property.IsRequired && !isRequiredKeywordSupported)
        {
            return " = default!;";
        }

        if (!property.Type.IsValueType &&
            !property.Type.CSharpTypeNullability &&
            string.IsNullOrWhiteSpace(property.DefaultValue) &&
            !(property.IsRequired && isRequiredKeywordSupported))
        {
            return " = default!;";
        }

        return property.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(property.DefaultValue)
            ? string.Empty
            : $" = {property.DefaultValue};";
    }

    private static string GeneratePropertyConverterAttribute(
        IJsonSerializer jsonSerializer,
        EmitterSettings settings,
        PropertyData property)
    {
        if (settings.UsesNewtonsoftJson() &&
            !property.Type.IsEnum &&
            !property.Type.IsUnixTimestamp)
        {
            return string.Empty;
        }

        return jsonSerializer.GenerateConverterAttribute(property.ConverterType);
    }

    private static bool HasDeprecatedTypeReferences(ModelData modelData)
    {
        for (var i = 0; i < modelData.Properties.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(modelData.Properties[i].Type))
            {
                return true;
            }
        }

        return false;
    }

    private static bool TypeUsesDeprecatedMembers(TypeData type)
    {
        if (type.IsDeprecated)
        {
            return true;
        }

        for (var i = 0; i < type.SubTypes.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(type.SubTypes[i].Unbox<TypeData>()))
            {
                return true;
            }
        }

        return false;
    }

    private static bool HasDeprecatedBaseClass(ModelData modelData)
    {
        return modelData.IsDerivedClass && modelData.HasDeprecatedBaseClass;
    }

    private static IEnumerable<PropertyData> GetDirectProperties(SchemaContext context)
    {
        var source = context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : !context.Schema.IsEnum()
                ? context.Children
                : null;

        if (source == null || source.Count == 0)
        {
            yield break;
        }

        var discriminatorPropertyName = context.IsBaseClass
            ? context.Schema.Discriminator?.PropertyName
            : null;
        var hasDiscriminator = !string.IsNullOrWhiteSpace(discriminatorPropertyName);

        for (var i = 0; i < source.Count; i++)
        {
            var child = source[i];
            if (child is not { IsProperty: true, PropertyData: not null })
            {
                continue;
            }

            foreach (var property in child.ComputedProperties)
            {
                if (!hasDiscriminator || property.Id != discriminatorPropertyName)
                {
                    yield return property;
                }
            }
        }
    }

    private static IEnumerable<PropertyData> GetInheritedProperties(ModelData modelData, bool requiredOnly = false)
    {
        if (!modelData.IsDerivedClass)
        {
            yield break;
        }

        var seenNames = new HashSet<string>(StringComparer.Ordinal);
        SchemaContext? current = modelData.SchemaContext;

        while (current is not null && current.IsDerivedClass)
        {
            var baseContext = current.BaseClassContext;
            if (baseContext.ReferenceId is string baseReferenceId &&
                !string.IsNullOrWhiteSpace(baseReferenceId) &&
                current.ComponentSchemas?.TryGetValue(baseReferenceId, out var componentBaseContext) == true)
            {
                baseContext = componentBaseContext;
            }
            else
            {
                baseContext = baseContext.ResolvedReference ?? baseContext;
            }

            foreach (var property in GetDirectProperties(baseContext))
            {
                if ((requiredOnly && !property.IsRequired) || !seenNames.Add(property.Name))
                {
                    continue;
                }

                yield return property;
            }

            current = baseContext;
        }
    }

    private static string GetConstructorParameter(
        PropertyData property,
        bool isRequiredKeywordSupported,
        bool forceRequired = false,
        string? parameterName = null)
    {
        parameterName ??= property.ParameterName;

        if (forceRequired || property.IsRequired)
        {
            return $@"
            {property.Type.CSharpType} {parameterName}";
        }

        return property.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(property.DefaultValue)
            ? $@"
            {property.Type.CSharpType} {parameterName}"
            : $@"
            {property.Type.CSharpType} {parameterName}{GetDefaultValue(property, isRequiredKeywordSupported).TrimEnd(';')}";
    }

    private static string GetConstructorAssignment(
        string target,
        PropertyData property,
        string? parameterName = null,
        bool forceRequired = false)
    {
        parameterName ??= property.ParameterName;

        return forceRequired || property.IsRequired
            ? $@"
            {target}.{property.Name} = {parameterName}{(property.Type.IsValueType ? string.Empty : $" ?? throw new global::System.ArgumentNullException(nameof({parameterName}))")};"
            : $@"
            {target}.{property.Name} = {parameterName};";
    }

    public static string GenerateClassModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var jsonSerializer = modelData.Settings.GetSerializer();
        var isRequiredKeywordSupported = IsSupported(modelData.Settings.UseRequiredKeyword, modelData.Settings.TargetFramework);
        var requiredKeyword = isRequiredKeywordSupported
            ? " required"
            : string.Empty;
        var properties = modelData.Properties;
        var hasAdditionalPropertiesProperty = properties.Any(x => x.Name == "AdditionalProperties");
        var additionalPropertiesPostfix = modelData.ClassName == "AdditionalProperties" || hasAdditionalPropertiesProperty
            ? "2"
            : string.Empty;
        var additionalPropertiesValueType = GetAdditionalPropertiesValueType(modelData.Settings);
        var additionalPropertiesSummary = modelData.Settings.GenerateRawModelData
            ? "Raw JSON properties that are not explicitly defined in the schema"
            : "Additional properties that are not explicitly defined in the schema";

        var inheritedPropertyNames = new HashSet<string>(
            modelData.InheritedPropertyNames,
            StringComparer.Ordinal);
        var inheritedRequiredPropertiesByName = modelData.InheritedRequiredProperties
            .ToDictionary(static x => x.Name, static x => x, StringComparer.Ordinal);

        var constructorProperties = properties
            .Where(x => x.IsRequired || !x.IsDeprecated || inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var constructorBaseOnlyRequiredProperties = inheritedRequiredPropertiesByName.Values
            .Where(x => properties.All(y => !string.Equals(y.Name, x.Name, StringComparison.Ordinal)))
            .ToArray();
        var requiredConstructorProperties = constructorProperties
            .Where(x => x.IsRequired || inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var optionalConstructorProperties = constructorProperties
            .Where(x => !x.IsRequired && !inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var optionalConstructorPropertiesWithoutDefaults = optionalConstructorProperties
            .Where(x => x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        var optionalConstructorPropertiesWithDefaults = optionalConstructorProperties
            .Where(x => !x.Type.CSharpTypeNullability && !string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        var orderedConstructorProperties = requiredConstructorProperties
            .Concat(optionalConstructorPropertiesWithoutDefaults)
            .Concat(optionalConstructorPropertiesWithDefaults)
            .ToArray();
        var hasConstructor = constructorProperties.Length > 0 || constructorBaseOnlyRequiredProperties.Length > 0;

        var propertyDeclarations = properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {property.DefaultValue?.ClearForXml().ToXmlDocumentationDefault(level: 8)}
        {property.Example?.ToXmlDocumentationExample(level: 8)}
        {GenerateValidationAttributes(modelData, property)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {GeneratePropertyConverterAttribute(jsonSerializer, modelData.Settings, property)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired) ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This property marked as deprecated.")}\")]" : TrimmedLine)}
        public{(inheritedPropertyNames.Contains(property.Name) ? " new" : string.Empty)}{(property.IsRequired ? requiredKeyword : string.Empty)} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject();

        var constructorParameterDocumentation = requiredConstructorProperties
            .Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}")
            .Concat(constructorBaseOnlyRequiredProperties.Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}"))
            .Concat(optionalConstructorPropertiesWithoutDefaults.Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}"))
            .Concat(optionalConstructorPropertiesWithDefaults.Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}"))
            .Inject();

        var constructorParameters = string.Join(
            ",",
            requiredConstructorProperties.Select(x =>
            {
                var shareParameterWithBase = inheritedRequiredPropertiesByName.TryGetValue(x.Name, out var inheritedRequiredProperty) &&
                                             string.Equals(inheritedRequiredProperty.Type.CSharpType, x.Type.CSharpType, StringComparison.Ordinal);

                return GetConstructorParameter(
                    x,
                    isRequiredKeywordSupported,
                    forceRequired: x.IsRequired || shareParameterWithBase);
            }).Concat(
                constructorBaseOnlyRequiredProperties.Select(x => GetConstructorParameter(
                    x,
                    isRequiredKeywordSupported,
                    forceRequired: true)))
            .Concat(optionalConstructorPropertiesWithoutDefaults.Select(x => GetConstructorParameter(
                x,
                isRequiredKeywordSupported)))
            .Concat(optionalConstructorPropertiesWithDefaults.Select(x => GetConstructorParameter(
                x,
                isRequiredKeywordSupported))));

        var constructorAssignments = constructorProperties.Select(x =>
        {
            var assignments = new List<string>(capacity: 2)
            {
                GetConstructorAssignment(
                    target: "this",
                    property: x,
                    forceRequired: x.IsRequired || inheritedRequiredPropertiesByName.ContainsKey(x.Name)),
            };

            if (inheritedRequiredPropertiesByName.TryGetValue(x.Name, out var inheritedRequiredProperty) &&
                string.Equals(inheritedRequiredProperty.Type.CSharpType, x.Type.CSharpType, StringComparison.Ordinal))
            {
                assignments.Add(GetConstructorAssignment(
                    target: "base",
                    property: inheritedRequiredProperty,
                    parameterName: x.ParameterName,
                    forceRequired: true));
            }

            return string.Concat(assignments);
        }).Concat(
            constructorBaseOnlyRequiredProperties.Select(x => GetConstructorAssignment(
                target: "base",
                property: x,
                forceRequired: true)))
            .Inject();

        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This model marked as deprecated.")}\")]" : TrimmedLine)}
    {(modelData.Settings.UsesSystemTextJson() && modelData.IsBaseClass ? @$" 
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = ""{modelData.DiscriminatorPropertyName}"",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
{modelData.DerivedTypes.Select(x => $@"
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof({x.GlobalClassName}), typeDiscriminator: ""{x.Discriminator}"")]").Inject()}" : TrimmedLine)}
    public{(modelData.IsBaseClass ? "" : " sealed")} partial class {modelData.ClassName}{(!string.IsNullOrWhiteSpace(modelData.BaseClass) ? $" : {modelData.BaseClass}" : string.Empty)}
    {{
{propertyDeclarations}

{(!modelData.IsDerivedClass ? $@" 
        {additionalPropertiesSummary.ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, {additionalPropertiesValueType}> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, {additionalPropertiesValueType}>();
 " : TrimmedLine)}
 
{(hasConstructor ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
{constructorParameterDocumentation}
{(modelData.Settings.UseSetsRequiredMembersAttributes is SdkFeatureUsage.Always or SdkFeatureUsage.InSupportedTargetFrameworks ? @$" 
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET7_0_OR_GREATER" : TrimmedLine)}
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : TrimmedLine)}
 " : TrimmedLine)}
        public {modelData.ClassName}(
 {constructorParameters})
        {{
{constructorAssignments}
        }}
 " : TrimmedLine)}
{(properties.Any(static x => !x.IsDeprecated) ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
        public {modelData.ClassName}()
        {{
        }}
 " : TrimmedLine)}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetAdditionalPropertiesValueType(
        EmitterSettings settings)
    {
        if (!settings.GenerateRawModelData)
        {
            return "object";
        }

        if (settings.UsesSystemTextJson())
        {
            return "global::System.Text.Json.JsonElement";
        }

        if (settings.UsesNewtonsoftJson())
        {
            return "global::Newtonsoft.Json.Linq.JToken";
        }

        return "object";
    }
}

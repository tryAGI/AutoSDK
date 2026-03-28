using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static readonly HashSet<string> ObjectMemberNames = new(StringComparer.Ordinal)
    {
        "Equals",
        "GetHashCode",
        "GetType",
        "ToString",
    };

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
        if (!modelData.IsDerivedClass)
        {
            return false;
        }

        return modelData.SchemaContext.BaseClassContext.Schema.IsDeprecated();
    }

    private static bool RequiresNewModifier(ModelData modelData, PropertyData property)
    {
        if (ObjectMemberNames.Contains(property.Name))
        {
            return true;
        }

        if (!modelData.IsDerivedClass)
        {
            return false;
        }

        var current = modelData.SchemaContext;
        while (current.IsDerivedClass)
        {
            var baseContext = current.BaseClassContext;
            if (baseContext.ClassData is { } baseClassData)
            {
                for (var i = 0; i < baseClassData.Properties.Length; i++)
                {
                    if (string.Equals(baseClassData.Properties[i].Name, property.Name, StringComparison.Ordinal))
                    {
                        return true;
                    }
                }
            }

            current = baseContext;
        }

        return false;
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
        var hasAdditionalPropertiesProperty = properties.Any(x =>
            x.Name == "AdditionalProperties");
        var additionalPropertiesPostfix = modelData.ClassName == "AdditionalProperties" || hasAdditionalPropertiesProperty
            ? "2"
            : string.Empty;

        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This model marked as deprecated.")}\")]" : TrimmedLine)}
    {(modelData.Settings.UsesSystemTextJson() && modelData.IsBaseClass ? @$" 
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = ""{modelData.DiscriminatorPropertyName}"",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
{modelData.DerivedTypes.Select(x => $@"
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof({modelData.Namespace}.{x.ClassName}), typeDiscriminator: ""{x.Discriminator}"")]").Inject()}" : TrimmedLine)}
    public{(modelData.IsBaseClass ? "" : " sealed")} partial class {modelData.ClassName}{(!string.IsNullOrWhiteSpace(modelData.BaseClass) ? $" : {modelData.BaseClass}" : "")}
    {{
{properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {property.DefaultValue?.ClearForXml().ToXmlDocumentationDefault(level: 8)}
        {property.Example?.ToXmlDocumentationExample(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {jsonSerializer.GenerateConverterAttribute(property.ConverterType)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired) ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This property marked as deprecated.")}\")]" : TrimmedLine)}
        public{(RequiresNewModifier(modelData, property) ? " new" : string.Empty)}{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

{(!modelData.IsDerivedClass ? $@" 
        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
 " : TrimmedLine)}
 
{(properties.Any(static x => x.IsRequired || !x.IsDeprecated) ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
{properties.Where(static x => x.IsRequired || !x.IsDeprecated).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
{(modelData.Settings.UseSetsRequiredMembersAttributes is SdkFeatureUsage.Always or SdkFeatureUsage.InSupportedTargetFrameworks ? @$" 
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET7_0_OR_GREATER" : TrimmedLine)}
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : TrimmedLine)}
 " : TrimmedLine)}
        public {modelData.ClassName}(
 {string.Join(",",
     properties.Where(static x => x.IsRequired).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}").Concat(
         properties.Where(static x => x is { IsRequired: false, IsDeprecated: false } && (x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}")).Concat(
         properties.Where(static x => x is { IsRequired: false, IsDeprecated: false } && !(x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}{GetDefaultValue(x, isRequiredKeywordSupported).TrimEnd(';')}")))})
        {{
{properties.Where(static x => x.IsRequired).Select(x => $@"
            this.{x.Name} = {x.ParameterName}{(x.Type.IsValueType ? "" : $" ?? throw new global::System.ArgumentNullException(nameof({x.ParameterName}))")};").Inject()}
{properties.Where(static x => x is { IsRequired: false, IsDeprecated: false }).Select(x => $@"
            this.{x.Name} = {x.ParameterName};").Inject()}
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
}

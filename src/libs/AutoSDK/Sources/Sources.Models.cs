using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return $@"
{(modelData.Properties.Any(x => x.Type.CSharpType.Contains("AnyOf<") || x.Type.CSharpType.Contains("OneOf<") || x.Type.CSharpType.Contains("AllOf<")) ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : " ")}
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
public sealed partial class {modelData.Parents[level].ClassName}
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
                when targetFramework.StartsWith("net8", StringComparison.OrdinalIgnoreCase) => true,
            SdkFeatureUsage.InSupportedTargetFrameworks
                when targetFramework.StartsWith("net9", StringComparison.OrdinalIgnoreCase) => true,
            _ => false,
        };
    }

    private static string GetDefaultValue(PropertyData property, bool isRequiredKeywordSupported)
    {
        if (property.IsRequired && !isRequiredKeywordSupported)
        {
            return " = default!;";
        }
        
        return property.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(property.DefaultValue)
            ? string.Empty
            : $" = {property.DefaultValue};";
    }
    
    public static string GenerateClassModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var jsonSerializer = modelData.Settings.JsonSerializerType.GetSerializer();
        var isRequiredKeywordSupported = IsSupported(modelData.Settings.UseRequiredKeyword, modelData.Settings.TargetFramework);
        var requiredKeyword = isRequiredKeywordSupported
            ? " required"
            : string.Empty;
        var additionalPropertiesPostfix = modelData.ClassName == "AdditionalProperties"
            ? "2"
            : string.Empty;
        var properties = modelData.Properties.Where(x =>
            !modelData.IsBaseClass ||
            x.Id != modelData.DiscriminatorPropertyName).ToArray();
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? "[global::System.Obsolete(\"This model marked as deprecated.\")]" : " ")}
    {(modelData.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson && modelData.IsBaseClass ? @$" 
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = ""{modelData.DiscriminatorPropertyName}"",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
{modelData.DerivedTypes.Select(x => $@"
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof({modelData.Namespace}.{x.ClassName}), typeDiscriminator: ""{x.Discriminator}"")]").Inject()}" : " ")}
    public{(modelData.IsBaseClass ? "" : " sealed")} partial class {modelData.ClassName}{(!string.IsNullOrWhiteSpace(modelData.BaseClass) ? $" : {modelData.BaseClass}" : "")}
    {{
{properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {property.DefaultValue?.ClearForXml().ToXmlDocumentationDefault(level: 8)}
        {property.Example?.ToXmlDocumentationExample(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {jsonSerializer.GenerateConverterAttribute(property.ConverterType)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired) ? "[global::System.Obsolete(\"This property marked as deprecated.\")]" : " ")}
        public{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

{(!modelData.IsDerivedClass ? $@" 
        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
 " : " ")}
 
{( properties.Any(static x => x.IsRequired || !x.IsDeprecated) ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
{properties.Where(static x => x.IsRequired || !x.IsDeprecated).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
{(modelData.Settings.UseSetsRequiredMembersAttributes is SdkFeatureUsage.Always or SdkFeatureUsage.InSupportedTargetFrameworks ? @$" 
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET7_0_OR_GREATER" : " ")}
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : " ")}
 " : " ")}
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
 " : " ")}
{(properties.Any(static x => !x.IsDeprecated) ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
        public {modelData.ClassName}()
        {{
        }}
 " : " ")}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
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
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? "[global::System.Obsolete(\"This model marked as deprecated.\")]" : " ")}
    public sealed partial class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {property.DefaultValue?.ToXmlDocumentationDefault(level: 8)}
        {property.Example?.ToXmlDocumentationExample(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {jsonSerializer.GenerateConverterAttribute(property.ConverterType)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired) ? "[global::System.Obsolete(\"This property marked as deprecated.\")]" : " ")}
        public{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
{modelData.Properties.Where(static x => x.IsRequired || !x.IsDeprecated).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
        {(modelData.Settings.TargetFramework.StartsWith("net8", StringComparison.OrdinalIgnoreCase) ? "[global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]" : " ")}
        public {modelData.ClassName}(
 {string.Join(",",
    modelData.Properties.Where(static x => x.IsRequired).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}").Concat(
    modelData.Properties.Where(static x => x is { IsRequired: false, IsDeprecated: false } && (x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}")).Concat(
        modelData.Properties.Where(static x => x is { IsRequired: false, IsDeprecated: false } && !(x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName}{GetDefaultValue(x, isRequiredKeywordSupported).TrimEnd(';')}")))})
        {{
{modelData.Properties.Where(static x => x.IsRequired).Select(x => $@"
            this.{x.Name} = {x.ParameterName}{(x.Type.IsValueType ? "" : $" ?? throw new global::System.ArgumentNullException(nameof({x.ParameterName}))")};").Inject()}
{modelData.Properties.Where(static x => x is { IsRequired: false, IsDeprecated: false }).Select(x => $@"
            this.{x.Name} = {x.ParameterName};").Inject()}
        }}
{(modelData.Properties.Any(static x => !x.IsDeprecated) ? $@"
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
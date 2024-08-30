using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Serialization.Json;

namespace OpenApiGenerator.Core.Generation;

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
        
        return property.IsRequired || string.IsNullOrWhiteSpace(property.DefaultValue) ? string.Empty : $" = {property.DefaultValue};";
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
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? "[global::System.Obsolete(\"This model marked as deprecated.\")]" : " ")}
    public sealed partial class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {jsonSerializer.GenerateConverterAttribute(property.ConverterType)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOf: false } && !property.IsRequired) ? "[global::System.Obsolete(\"This property marked as deprecated.\")]" : " ")}
        public{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
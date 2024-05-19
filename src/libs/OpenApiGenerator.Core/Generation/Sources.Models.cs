using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return $@"
#nullable enable

namespace {modelData.Namespace}
{{
{GenerateModel(modelData, level: 0, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateSuperClass(
        EquatableArray<ModelData> models,
        CancellationToken cancellationToken = default)
    {
        if (models.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {models[0].Namespace}
{{
    public sealed partial class OpenApiGeneratorTrimmableSupport
    {{
{models.Select(model => @$"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {model.ClassName}? {model.ClassName} {{ get; set; }}").Inject()}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    private static string GenerateModel(
        ModelData modelData,
        int level,
        CancellationToken cancellationToken = default)
    {
        if (modelData.NamingConvention == NamingConvention.ConcatNames ||
            level == modelData.Parents.AsSpan().Length)
        {
            return modelData.Style switch
            {
                ModelStyle.Class => GenerateClassModel(modelData, cancellationToken),
                ModelStyle.Enumeration => GenerateEnumerationModel(modelData, cancellationToken),
                _ => throw new NotSupportedException($"Model style {modelData.Style} is not supported."),
            };
        }
        
        return $@" 
public sealed partial class {modelData.Parents[level].ClassName}
{{
{GenerateModel(modelData, level + 1, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces().AddIndent(level: 1);
    }
    
    public static string GenerateEnumerationModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        // Only Newtonsoft.Json supports EnumMemberAttribute
        if (modelData.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    [global::System.Runtime.Serialization.DataContract]
    public enum {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Runtime.Serialization.EnumMember(Value=""{property.Id}"")]
        {property.Name},
    ").Inject()}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    public abstract class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        public const string {property.Name} = ""{property.Id}"";
    ").Inject()}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
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
        var jsonSerializer = modelData.JsonSerializerType.GetSerializer();
        var isRequiredKeywordSupported = IsSupported(modelData.UseRequiredKeyword, modelData.TargetFramework);
        var requiredKeyword = isRequiredKeywordSupported
            ? " required"
            : string.Empty;
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        public{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
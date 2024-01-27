using OpenApiGenerator.Core.Extensions;
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
    
    public static string GenerateClassModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Text.Json.Serialization.JsonPropertyName(""{property.Id}"")]
        public{(property.IsRequired ? " required" : "")} {property.Type} {property.Name} {{ get; set; }}{(property.IsRequired || property.DefaultValue == null ? string.Empty : $" = {property.DefaultValue};")}
").Inject()}

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
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
    public enum {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {property.Name},
    ").Inject()}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
//         
//         return $@" 
//     {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
//     public abstract class {modelData.ClassName}
//     {{
// {modelData.Properties.Select(property => @$"
//         {property.Summary.ToXmlDocumentationSummary(level: 8)}
//         public const string {property.Name} = ""{property.Id}"";
//     ").Inject()}
//     }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateEnumExtensions(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return $@" 
    {"Enum extensions to do fast conversions without the reflection.".ToXmlDocumentationSummary(level: 4)}
    public static class {modelData.ClassName}Extensions
    {{
        {"Converts an enum to a string.".ToXmlDocumentationSummary(level: 8)}
        public static string ToValueString(this {modelData.ClassName} value)
        {{
            return value switch
            {{
{modelData.Properties.Select(property => @$" 
                {modelData.ClassName}.{property.Name} => ""{property.Id}"",
 ").Inject()}
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            }};
        }}
        
        {"Converts an string to a enum.".ToXmlDocumentationSummary(level: 8)}
        public static {modelData.ClassName}? ToEnum(string value)
        {{
            return value switch
            {{
{modelData.Properties.Select(property => @$" 
                ""{property.Id}"" => {modelData.ClassName}.{property.Name},
 ").Inject()}
                _ => null,
            }};
        }}
    }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
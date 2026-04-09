using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateEnumerationModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        if (modelData.IsOpenEnum)
        {
            return @$"
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    public readonly partial struct {modelData.ClassName} : global::System.IEquatable<{modelData.ClassName}>
    {{
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {modelData.ClassName}(string value)
        {{
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public string Value {{ get; }}
{modelData.EnumValues.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        public static {modelData.ClassName} {property.Name} {{ get; }} = new({property.Id.ToCSharpStringLiteral()});
").Inject()}
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static {modelData.ClassName} FromValue(string value)
        {{
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {{
{modelData.EnumValues.Select(property => @$"
                {property.Id.ToCSharpStringLiteral()} => {property.Name},
 ").Inject()}
                _ => new {modelData.ClassName}(value),
            }};
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool IsKnown => Value switch
        {{
{modelData.EnumValues.Select(property => @$"
            {property.Id.ToCSharpStringLiteral()} => true,
 ").Inject()}
            _ => false,
        }};

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override string ToString() => Value ?? string.Empty;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Equals({modelData.ClassName} other)
        {{
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override bool Equals(object? obj)
        {{
            return obj is {modelData.ClassName} other && Equals(other);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override int GetHashCode()
        {{
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator ==({modelData.ClassName} left, {modelData.ClassName} right) => left.Equals(right);

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator !=({modelData.ClassName} left, {modelData.ClassName} right) => !left.Equals(right);
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        // Only Newtonsoft.Json supports EnumMemberAttribute
        if (modelData.Settings.UsesNewtonsoftJson())
        {
            return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    [global::System.Runtime.Serialization.DataContract]
    public enum {modelData.ClassName}
    {{
{modelData.EnumValues.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Runtime.Serialization.EnumMember(Value={property.Id.ToCSharpStringLiteral()})]
        {property.Name},
    ").Inject()}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    public enum {modelData.ClassName}
    {{
{modelData.EnumValues.Select(property => @$"
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
        if (modelData.IsOpenEnum)
        {
            return @$"
    {"Enum extensions to do fast conversions without the reflection.".ToXmlDocumentationSummary(level: 4)}
    public static class {modelData.ClassName}Extensions
    {{
        {"Converts an enum to a string.".ToXmlDocumentationSummary(level: 8)}
        public static string ToValueString(this {modelData.ClassName} value)
        {{
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }}

        {"Converts an string to a enum.".ToXmlDocumentationSummary(level: 8)}
        public static {modelData.ClassName}? ToEnum(string value)
        {{
            return {modelData.ClassName}.FromValue(value);
        }}
    }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        return $@" 
    {"Enum extensions to do fast conversions without the reflection.".ToXmlDocumentationSummary(level: 4)}
    public static class {modelData.ClassName}Extensions
    {{
        {"Converts an enum to a string.".ToXmlDocumentationSummary(level: 8)}
        public static string ToValueString(this {modelData.ClassName} value)
        {{
            return value switch
            {{
{modelData.EnumValues.Select(property => @$" 
                {modelData.ClassName}.{property.Name} => {property.Id.ToCSharpStringLiteral()},
 ").Inject()}
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            }};
        }}
        
        {"Converts an string to a enum.".ToXmlDocumentationSummary(level: 8)}
        public static {modelData.ClassName}? ToEnum(string value)
        {{
            return value switch
            {{
{modelData.EnumValues.Select(property => @$" 
                {property.Id.ToCSharpStringLiteral()} => {modelData.ClassName}.{property.Name},
 ").Inject()}
                _ => null,
            }};
        }}
    }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}

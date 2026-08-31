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
            return NormalizedString.Create($@"
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
    }}");
        }

        // Only Newtonsoft.Json supports EnumMemberAttribute
        return GenerateClosedEnumerationModel(
            modelData,
            includeEnumMemberAttributes: modelData.Settings.UsesNewtonsoftJson());
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
            return NormalizedString.Create($@"
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
 ");
        }

        return GenerateClosedEnumExtensions(modelData);
    }

    private static string GenerateClosedEnumerationModel(
        ModelData modelData,
        bool includeEnumMemberAttributes)
    {
        using var builder = new PooledStringBuilder(256 + (modelData.EnumValues.Length * 160));
        AppendClosedEnumerationModel(builder, modelData, includeEnumMemberAttributes);
        return builder.ToString();
    }

    private static void AppendClosedEnumerationModel(
        PooledStringBuilder builder,
        ModelData modelData,
        bool includeEnumMemberAttributes)
    {
        builder.Append("    ");
        AppendXmlDocumentationSummary(builder, modelData.Summary, level: 4);
        builder.Append('\n');
        if (includeEnumMemberAttributes)
        {
            builder.Append("    [global::System.Runtime.Serialization.DataContract]\n");
        }
        builder.Append("    public enum ");
        builder.Append(modelData.ClassName);
        builder.Append("\n    {\n");
        foreach (var property in modelData.EnumValues)
        {
            builder.Append("        ");
            AppendXmlDocumentationSummary(builder, property.Summary, level: 8);
            builder.Append('\n');
            if (includeEnumMemberAttributes)
            {
                builder.Append("        [global::System.Runtime.Serialization.EnumMember(Value=");
                builder.Append(property.Id.ToCSharpStringLiteral());
                builder.Append(")]\n");
            }
            builder.Append("        ");
            builder.Append(property.Name);
            builder.Append(",\n");
        }
        builder.Append("    }");
    }

    private static string GenerateClosedEnumExtensions(ModelData modelData)
    {
        using var builder = new PooledStringBuilder(768 + (modelData.EnumValues.Length * 220));
        AppendClosedEnumExtensions(builder, modelData);
        return builder.ToString();
    }

    private static void AppendClosedEnumExtensions(
        PooledStringBuilder builder,
        ModelData modelData)
    {
        var valueLiterals = new string[modelData.EnumValues.Length];
        for (var index = 0; index < modelData.EnumValues.Length; index++)
        {
            valueLiterals[index] = modelData.EnumValues[index].Id.ToCSharpStringLiteral();
        }

        builder.Append("    ");
        AppendXmlDocumentationSummary(
            builder,
            "Enum extensions to do fast conversions without the reflection.",
            level: 4);
        builder.Append("\n    public static class ");
        builder.Append(modelData.ClassName);
        builder.Append("Extensions\n    {\n        ");
        AppendXmlDocumentationSummary(builder, "Converts an enum to a string.", level: 8);
        builder.Append("\n        public static string ToValueString(this ");
        builder.Append(modelData.ClassName);
        builder.Append(" value)\n        {\n            return value switch\n            {\n");
        for (var index = 0; index < modelData.EnumValues.Length; index++)
        {
            var property = modelData.EnumValues[index];
            builder.Append("                ");
            builder.Append(modelData.ClassName);
            builder.Append('.');
            builder.Append(property.Name);
            builder.Append(" => ");
            builder.Append(valueLiterals[index]);
            builder.Append(",\n");
        }
        builder.Append("                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),\n            };\n        }\n        ");
        AppendXmlDocumentationSummary(builder, "Converts an string to a enum.", level: 8);
        builder.Append("\n        public static ");
        builder.Append(modelData.ClassName);
        builder.Append("? ToEnum(string value)\n        {\n            return value switch\n            {\n");
        for (var index = 0; index < modelData.EnumValues.Length; index++)
        {
            var property = modelData.EnumValues[index];
            builder.Append("                ");
            builder.Append(valueLiterals[index]);
            builder.Append(" => ");
            builder.Append(modelData.ClassName);
            builder.Append('.');
            builder.Append(property.Name);
            builder.Append(",\n");
        }
        builder.Append("                _ => null,\n            };\n        }\n    }");
    }
}

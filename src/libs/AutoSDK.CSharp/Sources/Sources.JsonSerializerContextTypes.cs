using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Text;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty)
        {
            return string.Empty;
        }

        var distinctTypes = new List<string>(types.Length);
        var distinctTypesSet = new HashSet<string>();
        for (var i = 0; i < types.Length; i++)
        {
            var type = types[i].CSharpTypeWithNullability;
            if (distinctTypesSet.Add(type))
            {
                distinctTypes.Add(type);
            }
        }

        var concreteListTypes = GetConcreteListTypes(distinctTypes);
        var summary4 = string.Empty.ToXmlDocumentationSummary(level: 4);
        var summary8 = string.Empty.ToXmlDocumentationSummary(level: 8);
        var builder = new StringBuilder(
            256 +
            (distinctTypes.Count + concreteListTypes.Length + 3) * 192);

        builder.AppendLine();
        builder.AppendLine("#nullable enable");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS0618 // Type or member is obsolete");
        builder.AppendLine();
        builder.Append("namespace ").Append(types[0].Namespace).AppendLine();
        builder.AppendLine("{");
        builder.Append("    ").Append(summary4).AppendLine();
        builder.AppendLine("    public sealed partial class JsonSerializerContextTypes");
        builder.AppendLine("    {");
        AppendProperty(builder, summary8, "global::System.Collections.Generic.Dictionary<string, string>?", "StringStringDictionary");
        builder.AppendLine();
        AppendProperty(builder, summary8, "global::System.Collections.Generic.Dictionary<string, object>?", "StringObjectDictionary");
        builder.AppendLine();
        AppendProperty(builder, summary8, "global::System.Text.Json.JsonElement?", "JsonElement");

        if (distinctTypes.Count > 0)
        {
            builder.AppendLine();
            for (var i = 0; i < distinctTypes.Count; i++)
            {
                AppendProperty(builder, summary8, distinctTypes[i], $"Type{i}");
            }
        }

        if (concreteListTypes.Length > 0)
        {
            builder.AppendLine();
            for (var i = 0; i < concreteListTypes.Length; i++)
            {
                AppendProperty(builder, summary8, concreteListTypes[i], $"ListType{i}");
            }
        }

        if (concreteListTypes.Length == 0)
        {
            builder.AppendLine();
        }

        builder.AppendLine("    }");
        builder.Append('}');
        return builder.ToString();

        static void AppendProperty(StringBuilder builder, string summary, string type, string propertyName)
        {
            builder.Append("        ").Append(summary).AppendLine();
            builder.Append("        public ").Append(type).Append(' ').Append(propertyName).AppendLine(" { get; set; }");
        }
    }
}

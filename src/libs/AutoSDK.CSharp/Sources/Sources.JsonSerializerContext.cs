using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Text;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContext(
        Client client,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!client.Settings.FromCli ||
            !client.Settings.ShouldGenerateJsonSerializerContextTypes())
        {
            return string.Empty;
        }

        // Extract class name from fully-qualified JsonSerializerContext setting
        var contextClassName = client.Settings.JsonSerializerContext.Contains(".")
            ? client.Settings.JsonSerializerContext.Substring(client.Settings.JsonSerializerContext.LastIndexOf('.') + 1)
            : "SourceGenerationContext";

        var summary4 = string.Empty.ToXmlDocumentationSummary(level: 4);
        var builder = new StringBuilder(256 + client.Converters.Length * 48 + types.Length * 72);

        builder.AppendLine();
        builder.AppendLine("#nullable enable");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS0618 // Type or member is obsolete");
        builder.AppendLine("#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant");
        builder.AppendLine();
        builder.Append("namespace ").Append(client.Settings.Namespace).AppendLine();
        builder.AppendLine("{");
        builder.Append("    ").Append(summary4).AppendLine();
        builder.AppendLine("    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(");
        builder.AppendLine("        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,");
        builder.AppendLine("        Converters = new global::System.Type[]");
        builder.AppendLine("        {");

        for (var i = 0; i < client.Converters.Length; i++)
        {
            builder.Append("            typeof(").Append(client.Converters[i]).AppendLine("),");
        }

        builder.AppendLine("        })]");

        if (!types.IsEmpty)
        {
            builder.AppendLine(GenerateJsonSerializableAttributes(client, types));
        }

        builder.Append("    public sealed partial class ").Append(contextClassName).AppendLine(" : global::System.Text.Json.Serialization.JsonSerializerContext");
        builder.AppendLine("    {");
        builder.AppendLine("    }");
        builder.Append('}');
        return builder.ToString();
    }

    private static string GenerateJsonSerializableAttributes(
        Client client,
        EquatableArray<TypeData> types)
    {
        var distinctTypes = types
            .Select(x => x.CSharpTypeWithoutNullability)
            .Distinct()
            .ToArray();

        var concreteListTypes = GetConcreteListTypes(distinctTypes);
        var builder = new StringBuilder(64 + (distinctTypes.Length + concreteListTypes.Length + 1) * 88);

        builder
            .Append("    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::")
            .Append(client.Settings.Namespace)
            .AppendLine(".JsonSerializerContextTypes))]");

        foreach (var type in distinctTypes)
        {
            builder
                .Append("    [global::System.Text.Json.Serialization.JsonSerializable(typeof(")
                .Append(type)
                .AppendLine("))]");
        }

        foreach (var type in concreteListTypes)
        {
            builder
                .Append("    [global::System.Text.Json.Serialization.JsonSerializable(typeof(")
                .Append(type)
                .AppendLine("))]");
        }

        if (builder.Length > 0)
        {
            builder.Length--;
        }

        return builder.ToString();
    }

    /// <summary>
    /// Returns concrete List&lt;T&gt; counterparts for IList&lt;T&gt; types,
    /// excluding any that already exist in <paramref name="distinctTypes"/>.
    /// </summary>
    public static string[] GetConcreteListTypes(string[] distinctTypes)
    {
        var distinctTypesSet = new HashSet<string>(distinctTypes);
        return distinctTypes
            .Where(x => x.Contains("System.Collections.Generic.IList<"))
            .Select(x => x.Replace(
                "System.Collections.Generic.IList<",
                "System.Collections.Generic.List<"))
            .Distinct()
            .Where(x => !distinctTypesSet.Contains(x))
            .ToArray();
    }
}

using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Text;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextConverters(
        Client client)
    {
        if (!client.Settings.ShouldGenerateJsonSerializerContextTypes())
        {
            return string.Empty;
        }

        var summary4 = string.Empty.ToXmlDocumentationSummary(level: 4);
        var builder = new StringBuilder(192 + client.Converters.Length * 48);

        builder.AppendLine();
        builder.AppendLine("#nullable enable");
        builder.AppendLine();
        builder.Append("namespace ").Append(client.Settings.Namespace).AppendLine();
        builder.AppendLine("{");
        builder.Append("    ").Append(summary4).AppendLine();
        builder.AppendLine("    internal sealed partial class JsonSerializerContextConverters");
        builder.AppendLine("    {");
        builder.AppendLine("        private readonly global::System.Type[] _types = new global::System.Type[]");
        builder.AppendLine("        {");

        for (var i = 0; i < client.Converters.Length; i++)
        {
            builder.Append("            typeof(").Append(client.Converters[i]).AppendLine("),");
        }

        builder.AppendLine("        };");
        builder.AppendLine("    }");
        builder.Append('}');
        return builder.ToString();
    }
}

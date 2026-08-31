using AutoSDK.Extensions;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static void AppendXmlDocumentationSummary(
        PooledStringBuilder builder,
        string text,
        int level)
    {
        if (text.Contains('\n'))
        {
            builder.Append(text.ToXmlDocumentationSummary(level));
            return;
        }

        builder.Append("/// <summary>\n");
        builder.Append(' ', level);
        builder.Append("/// ");
        builder.Append(text);
        builder.Append('\n');
        builder.Append(' ', level);
        builder.Append("/// </summary>");
    }

    private static void AppendXmlDocumentationForParam(
        PooledStringBuilder builder,
        string text,
        string parameterName,
        int level)
    {
        if (text.Contains('\n'))
        {
            builder.Append(text.ToXmlDocumentationForParam(parameterName, level));
            return;
        }

        var parameterNameStart = parameterName.Length > 0 && parameterName[0] == '@' ? 1 : 0;
        builder.Append("/// <param name=\"");
        builder.Append(parameterName, parameterNameStart, parameterName.Length - parameterNameStart);
        if (string.IsNullOrWhiteSpace(text))
        {
            builder.Append("\"></param>");
            return;
        }

        builder.Append("\">\n");
        builder.Append(' ', level);
        builder.Append("/// ");
        builder.Append(text);
        builder.Append('\n');
        builder.Append(' ', level);
        builder.Append("/// </param>");
    }
}

using AutoSDK.Extensions;
using AutoSDK.Models;
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
        
        return $@"
#nullable enable

namespace {client.Settings.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    internal sealed partial class JsonSerializerContextConverters
    {{
        private readonly global::System.Type[] _types = new global::System.Type[]
        {{
{client.Converters.Select(x => $@" 
            typeof({x}),
").Inject()}
        }};
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}

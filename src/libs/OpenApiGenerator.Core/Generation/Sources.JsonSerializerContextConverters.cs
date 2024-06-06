using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextConverters(
        EndPoint endPoint)
    {
        if (!endPoint.GenerateJsonSerializerContextTypes ||
            endPoint.JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }
        
        var serializer = endPoint.JsonSerializerType.GetSerializer();
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    internal sealed partial class JsonSerializerContextConverters
    {{
        private readonly {serializer.GetOptionsType()} _jsonSerializerOptions = {serializer.CreateDefaultSettings(endPoint.Converters)}; 
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
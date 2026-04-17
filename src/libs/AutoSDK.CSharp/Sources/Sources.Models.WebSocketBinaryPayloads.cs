using System.Linq;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName ClassWebSocketBinaryPayloadHelpers(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var text = GenerateClassWebSocketBinaryPayloadHelpers(modelData);
        if (string.IsNullOrWhiteSpace(text))
        {
            return FileWithName.Empty;
        }

        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.BinaryPayloads.g.cs",
            Text: text);
    }

    public static string GenerateClassWebSocketBinaryPayloadHelpers(
        ModelData modelData)
    {
        var properties = GetWebSocketBinaryPayloadProperties(modelData)
            .Where(IsStringBackedWebSocketBinaryPayloadProperty)
            .ToArray();
        if (properties.Length == 0)
        {
            return string.Empty;
        }

        var jsonSerializer = modelData.Settings.GetSerializer();
        var declarations = properties.Select(property =>
        {
            var propertyName = GetWebSocketBinaryPayloadBytesPropertyName(modelData, property);
            return $@"
        /// <summary>
        /// Gets the decoded bytes for <see cref=""{property.Name}"" />.
        /// </summary>
        {jsonSerializer.GenerateIgnoreAttribute()}
        public global::System.ReadOnlyMemory<byte> {propertyName} => {property.Name} is null
            ? default
            : global::System.Convert.FromBase64String({property.Name});
";
        }).Inject();

        return $@"
#nullable enable

namespace {modelData.Namespace}
{{
    public{(modelData.IsBaseClass ? "" : " sealed")} partial class {modelData.ClassName}
    {{
{declarations}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}

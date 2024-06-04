using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAnyOfJsonConverter(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var (subType, count, jsonSerializerType) = anyOfData;
        if (jsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"T{x}"))}>";
        
        return $@"#nullable enable

namespace OpenApiGenerator.JsonConverters
{{
    /// <inheritdoc />
    public class {subType}JsonConverter{types} : global::System.Text.Json.Serialization.JsonConverter<global::System.{subType}{types}>
    {{
        /// <inheritdoc />
        public override global::System.{subType}{types} Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            var
{Enumerable.Range(1, count).Select(x => $@"
            readerCopy = reader;
            T{x}? value{x} = default;
            try
            {{
                value{x} = global::System.Text.Json.JsonSerializer.Deserialize<T{x}>(ref readerCopy, options);
            }}
            catch (global::System.Text.Json.JsonException)
            {{
            }}
").Inject()}
        
            var result = new global::System.{subType}{types}(
{Enumerable.Range(1, count).Select(x => $@"
                value{x},
").Inject().TrimEnd(',')}
                );
            if (!result.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {subType}<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"{{typeof(T{x}).Name}}"))}>"");
            }}

{Enumerable.Range(1, count).Select(x => $@"
            {(x == 1 ? "" : "else ")}if (value{x} != null)
            {{
                _ = global::System.Text.Json.JsonSerializer.Deserialize<T{x}>(ref reader, options);
            }}
").Inject().TrimEnd(',')}
        
            return result;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.{subType}{types} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            if (!value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid {subType}<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"{{typeof(T{x}).Name}}"))}> object."");
            }}

{Enumerable.Range(1, count).Select(x => $@"
            {(x == 1 ? "" : "else ")}if (value.IsValue{x})
            {{
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value{x}, value.Value{x}!.GetType(), options);
            }}
").Inject().TrimEnd(',')}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
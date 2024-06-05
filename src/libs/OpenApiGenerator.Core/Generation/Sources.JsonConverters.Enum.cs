using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateEnumJsonConverter(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        if (model.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return string.Empty;
        }

        return $@"#nullable enable

namespace OpenApiGenerator.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}JsonConverter : global::System.Text.Json.Serialization.JsonConverter<{model.GlobalClassName}>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName} Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            switch (reader.TokenType)
            {{
                case global::System.Text.Json.JsonTokenType.String:
                {{
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue) ?? default;
                    }}
                    
                    break;
                }}
                case global::System.Text.Json.JsonTokenType.Number:
                {{
                    var numValue = reader.GetInt32();
                    return ({model.GlobalClassName})numValue;
                }}
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {model.GlobalClassName} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue({model.GlobalClassName}Extensions.ToValueString(value));
        }}
    }}
}}
";
    }
}
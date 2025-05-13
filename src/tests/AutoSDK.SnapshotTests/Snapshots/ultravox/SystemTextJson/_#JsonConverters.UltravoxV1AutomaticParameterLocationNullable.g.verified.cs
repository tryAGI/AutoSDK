//HintName: JsonConverters.UltravoxV1AutomaticParameterLocationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1AutomaticParameterLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UltravoxV1AutomaticParameterLocation?>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1AutomaticParameterLocation? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.UltravoxV1AutomaticParameterLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UltravoxV1AutomaticParameterLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UltravoxV1AutomaticParameterLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UltravoxV1AutomaticParameterLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UltravoxV1AutomaticParameterLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}

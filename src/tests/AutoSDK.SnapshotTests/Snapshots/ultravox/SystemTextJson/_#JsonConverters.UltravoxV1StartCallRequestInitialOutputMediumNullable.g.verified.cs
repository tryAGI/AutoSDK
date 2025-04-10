//HintName: JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1StartCallRequestInitialOutputMediumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UltravoxV1StartCallRequestInitialOutputMedium?>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1StartCallRequestInitialOutputMedium? Read(
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
                        return global::G.UltravoxV1StartCallRequestInitialOutputMediumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UltravoxV1StartCallRequestInitialOutputMedium)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UltravoxV1StartCallRequestInitialOutputMedium? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UltravoxV1StartCallRequestInitialOutputMediumExtensions.ToValueString(value.Value));
            }
        }
    }
}

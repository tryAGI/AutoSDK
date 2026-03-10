//HintName: G.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Read(
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
                        return global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}

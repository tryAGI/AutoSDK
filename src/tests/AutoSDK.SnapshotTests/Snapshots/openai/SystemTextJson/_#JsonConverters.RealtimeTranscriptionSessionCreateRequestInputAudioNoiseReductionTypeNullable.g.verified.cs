//HintName: JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType?>
    {
        /// <inheritdoc />
        public override global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType? Read(
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
                        return global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

//HintName: JsonConverters.RealtimeSessionCreateRequestInputAudioNoiseReductionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeSessionCreateRequestInputAudioNoiseReductionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionType>
    {
        /// <inheritdoc />
        public override global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionType Read(
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
                        return global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.RealtimeSessionCreateRequestInputAudioNoiseReductionTypeExtensions.ToValueString(value));
        }
    }
}

//HintName: G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId?>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId? Read(
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
                        return global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdExtensions.ToValueString(value.Value));
            }
        }
    }
}

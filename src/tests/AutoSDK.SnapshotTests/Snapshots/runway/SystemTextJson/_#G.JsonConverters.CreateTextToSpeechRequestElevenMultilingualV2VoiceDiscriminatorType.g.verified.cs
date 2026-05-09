//HintName: G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType Read(
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
                        return global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}

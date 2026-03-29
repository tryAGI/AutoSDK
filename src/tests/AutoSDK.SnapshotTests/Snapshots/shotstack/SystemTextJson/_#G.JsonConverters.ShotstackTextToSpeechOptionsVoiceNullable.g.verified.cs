//HintName: G.JsonConverters.ShotstackTextToSpeechOptionsVoiceNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ShotstackTextToSpeechOptionsVoiceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ShotstackTextToSpeechOptionsVoice?>
    {
        /// <inheritdoc />
        public override global::G.ShotstackTextToSpeechOptionsVoice? Read(
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
                        return global::G.ShotstackTextToSpeechOptionsVoiceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ShotstackTextToSpeechOptionsVoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ShotstackTextToSpeechOptionsVoice?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ShotstackTextToSpeechOptionsVoice? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ShotstackTextToSpeechOptionsVoiceExtensions.ToValueString(value.Value));
            }
        }
    }
}

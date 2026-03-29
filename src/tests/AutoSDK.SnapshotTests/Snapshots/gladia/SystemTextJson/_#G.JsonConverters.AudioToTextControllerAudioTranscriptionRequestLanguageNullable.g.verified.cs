//HintName: G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioToTextControllerAudioTranscriptionRequestLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AudioToTextControllerAudioTranscriptionRequestLanguage?>
    {
        /// <inheritdoc />
        public override global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? Read(
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
                        return global::G.AudioToTextControllerAudioTranscriptionRequestLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AudioToTextControllerAudioTranscriptionRequestLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AudioToTextControllerAudioTranscriptionRequestLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AudioToTextControllerAudioTranscriptionRequestLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}

//HintName: G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage>
    {
        /// <inheritdoc />
        public override global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage Read(
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
                        return global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageExtensions.ToValueString(value));
        }
    }
}

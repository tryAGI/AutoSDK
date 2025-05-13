//HintName: JsonConverters.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat Read(
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
                        return global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatExtensions.ToValueString(value));
        }
    }
}

//HintName: G.JsonConverters.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat?>
    {
        /// <inheritdoc />
        public override global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat? Read(
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
                        return global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}

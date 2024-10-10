//HintName: JsonConverters.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType>
    {
        /// <inheritdoc />
        public override global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType Read(
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
                        return global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions.ToValueString(value));
        }
    }
}

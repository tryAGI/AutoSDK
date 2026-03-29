//HintName: G.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind>
    {
        /// <inheritdoc />
        public override global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind Read(
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
                        return global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions.ToValueString(value));
        }
    }
}

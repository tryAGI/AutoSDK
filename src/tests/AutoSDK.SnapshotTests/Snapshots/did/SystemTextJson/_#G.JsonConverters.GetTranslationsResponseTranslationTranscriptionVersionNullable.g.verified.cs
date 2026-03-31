//HintName: G.JsonConverters.GetTranslationsResponseTranslationTranscriptionVersionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTranslationsResponseTranslationTranscriptionVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetTranslationsResponseTranslationTranscriptionVersion?>
    {
        /// <inheritdoc />
        public override global::G.GetTranslationsResponseTranslationTranscriptionVersion? Read(
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
                        return global::G.GetTranslationsResponseTranslationTranscriptionVersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetTranslationsResponseTranslationTranscriptionVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetTranslationsResponseTranslationTranscriptionVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetTranslationsResponseTranslationTranscriptionVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetTranslationsResponseTranslationTranscriptionVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}

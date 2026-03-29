//HintName: G.JsonConverters.TransliterateRequestSpokenFormNumeralsLanguage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransliterateRequestSpokenFormNumeralsLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransliterateRequestSpokenFormNumeralsLanguage>
    {
        /// <inheritdoc />
        public override global::G.TransliterateRequestSpokenFormNumeralsLanguage Read(
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
                        return global::G.TransliterateRequestSpokenFormNumeralsLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TransliterateRequestSpokenFormNumeralsLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TransliterateRequestSpokenFormNumeralsLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransliterateRequestSpokenFormNumeralsLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TransliterateRequestSpokenFormNumeralsLanguageExtensions.ToValueString(value));
        }
    }
}

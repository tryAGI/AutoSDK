//HintName: G.JsonConverters.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion Read(
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
                        return global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionExtensions.ToValueString(value));
        }
    }
}

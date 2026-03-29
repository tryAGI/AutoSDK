//HintName: G.JsonConverters.ConfiguredRulesSpellingAndGrammarQuotationModificationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesSpellingAndGrammarQuotationModificationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfiguredRulesSpellingAndGrammarQuotationModification?>
    {
        /// <inheritdoc />
        public override global::G.ConfiguredRulesSpellingAndGrammarQuotationModification? Read(
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
                        return global::G.ConfiguredRulesSpellingAndGrammarQuotationModificationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfiguredRulesSpellingAndGrammarQuotationModification)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfiguredRulesSpellingAndGrammarQuotationModification?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfiguredRulesSpellingAndGrammarQuotationModification? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConfiguredRulesSpellingAndGrammarQuotationModificationExtensions.ToValueString(value.Value));
            }
        }
    }
}
